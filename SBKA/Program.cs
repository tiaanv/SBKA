using CoreAudioApi;
using NAudio;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Resources;
using System.Threading;

namespace SBKA
{
    public static class Globals
    {
        public static DateTime lastheardsound;
        public static DateTime lastplayedsound;
        public static bool MonitorOn = true;

        public static string getdeviceid(string devicefriendlyname)
        {
            var sndDevEnum = new MMDeviceEnumerator();

            //Get Default Snd Device
            string deviceid = sndDevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia).ID;

            if (Properties.Settings.Default.AudioDevice != "Default")
            {
                var devices = sndDevEnum.EnumerateAudioEndPoints(EDataFlow.eRender, EDeviceState.DEVICE_STATE_ACTIVE);
                for (int i = 0; i < devices.Count; i++)
                {
                    if (devices[i].FriendlyName == devicefriendlyname)
                        deviceid = devices[i].ID;
                }
            }

            return deviceid;
        }


        public static void PlayBeep(UInt16 frequency, int msDuration, UInt16 volume = 16383)
        {
            var mStrm = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(mStrm);

            const double TAU = 2 * Math.PI;
            int formatChunkSize = 16;
            int headerSize = 8;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int samples = (int)((decimal)samplesPerSecond * msDuration / 1000);
            int rampsamples = (int)((decimal)samplesPerSecond * msDuration / 4000);
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            // var encoding = new System.Text.UTF8Encoding();
            writer.Write(0x46464952); // = encoding.GetBytes("RIFF")
            writer.Write(fileSize);
            writer.Write(0x45564157); // = encoding.GetBytes("WAVE")
            writer.Write(0x20746D66); // = encoding.GetBytes("fmt ")
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(0x61746164); // = encoding.GetBytes("data")
            writer.Write(dataChunkSize);
            {
                double theta = frequency * TAU / (double)samplesPerSecond;
                // 'volume' is UInt16 with range 0 thru Uint16.MaxValue ( = 65 535)
                // we need 'amp' to have the range of 0 thru Int16.MaxValue ( = 32 767)
                UInt16 rampvol = 0;
                double amp = volume >> 2; // so we simply set amp = volume / 2
                for (int step = 0; step < samples; step++)
                {
                    if (step < rampsamples)
                    {
                        rampvol = (UInt16)((float)volume * ((float)step / (float)rampsamples));
                        amp = rampvol >> 2;
                    }
                    if (step >= samples - rampsamples)
                    {
                        rampvol = (UInt16)((float)volume * ((float)(samples - step) / (float)rampsamples));
                        amp = rampvol >> 2;
                    }
                    short s = (short)(amp * Math.Sin(theta * (double)step));
                    writer.Write(s);
                }
            }

            mStrm.Seek(0, SeekOrigin.Begin);

            int devicenumber = -1;
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var devicecap = WaveOut.GetCapabilities(i);
                if (devicecap.ProductName.Contains(Properties.Settings.Default.AudioDevice))
                    devicenumber = i;
            }

            var output = new WaveOutEvent { DeviceNumber = devicenumber };

            var wav = new RawSourceWaveStream(mStrm, new WaveFormat(samplesPerSecond, bitsPerSample, 1));
            output.Init(wav);
            output.Play();
            while (output.PlaybackState == PlaybackState.Playing)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            wav.Dispose();
            output.Dispose();

            writer.Close();
            mStrm.Close();
            lastplayedsound = DateTime.Now;
            lastheardsound = DateTime.Now;
        }

    }

    public partial class MsgForm : Form 
    {
        private IntPtr unRegPowerNotify = IntPtr.Zero;

        public MsgForm()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ShowInTaskbar = false;
            Opacity = 0;
            Size = new Size(0, 0);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var settingGuid = new NativeMethods.PowerSettingGuid();
            Guid powerGuid = IsWindows8Plus()
                           ? settingGuid.ConsoleDisplayState
                           : settingGuid.MonitorPowerGuid;

            unRegPowerNotify = NativeMethods.RegisterPowerSettingNotification(
                this.Handle, powerGuid, NativeMethods.DEVICE_NOTIFY_WINDOW_HANDLE);
        }

        private bool IsWindows8Plus()
        {
            var version = Environment.OSVersion.Version;
            if (version.Major > 6) return true; // Windows 10+
            if (version.Major == 6 && version.Minor > 1) return true; // Windows 8+
            return false;  // Windows 7 or less
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case NativeMethods.WM_POWERBROADCAST:
                    if (m.WParam == (IntPtr)NativeMethods.PBT_POWERSETTINGCHANGE)
                    {
                        var settings = (NativeMethods.POWERBROADCAST_SETTING)m.GetLParam(
                            typeof(NativeMethods.POWERBROADCAST_SETTING));
                        switch (settings.Data)
                        {
                            case 0:
                                Globals.MonitorOn = false;
                                break;
                            case 1:
                                Globals.MonitorOn = true;
                                break;
                            case 2:
                                //Console.WriteLine("Monitor Dimmed");
                                break;
                        }
                    }
                    m.Result = (IntPtr)1;
                    break;
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            NativeMethods.UnregisterPowerSettingNotification(unRegPowerNotify);
            base.OnFormClosing(e);
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MyCustomApplicationContext());
        }
        public class MyCustomApplicationContext : ApplicationContext
        {
            private NotifyIcon trayIcon;
            MsgForm msgForm;

            public MyCustomApplicationContext()
            {
                //Initialize MsgForm (to detect Monitor state)
                if (Properties.Settings.Default.DisableWithMonitor == true)
                {
                    msgForm = new MsgForm();
                    msgForm.Show();
                }

                // Initialize Tray Icon
                Bitmap bmp = SBKA.Properties.Resources.soundbar;
                trayIcon = new NotifyIcon()
                {
                    Icon = Icon.FromHandle(bmp.GetHicon()),
                    ContextMenuStrip = new ContextMenuStrip(),
                    Visible = true
                };
                trayIcon.ContextMenuStrip.Items.Add("Settings", null, Settings);
                trayIcon.ContextMenuStrip.Items.Add("Exit", null, Exit);
                Sound();
            }

            public static async Task Sound()
            {
                Ears ears = new Ears();
                var cancellationtkn = new System.Threading.CancellationToken();

                while (true)
                {
                    int interval = Properties.Settings.Default.Interval;
                    bool detectsound = Properties.Settings.Default.DetectSound;

                    if (detectsound)
                    {
                        var heardsound = await ears.Listen(2000, cancellationtkn);
                        if (heardsound) Globals.lastheardsound = DateTime.Now;
                    }
                    else
                    {
                        await Task.Delay(2000, cancellationtkn);
                    }

                    var diffInSeconds = (DateTime.Now - Globals.lastheardsound).TotalSeconds;
                    if (diffInSeconds > interval && Globals.MonitorOn)
                    {
                        Globals.PlayBeep(10, 3000);
                    }
                }
            }

            private void Settings(object? sender, EventArgs e)
            {
                FrmSettings frmsettings = new FrmSettings();
                frmsettings.ShowDialog();
                frmsettings.Dispose();

                if (Properties.Settings.Default.DisableWithMonitor == true && msgForm == null) 
                {   
                    msgForm = new MsgForm();
                    msgForm.Show();
                }

            }

            void Exit(object? sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }
        }
    }
}