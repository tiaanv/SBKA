using System;
using System.Diagnostics;
using System.Resources;

namespace SBKA
{
    public static class Globals
    {
        public static DateTime lastheardsound;
        public static DateTime lastplayedsound;
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
                        rampvol = (UInt16)((float)volume * ((float)(samples-step) / (float)rampsamples));
                        amp = rampvol >> 2;
                    }
                    short s = (short)(amp * Math.Sin(theta * (double)step));
                    writer.Write(s);
                }
            }

            mStrm.Seek(0, SeekOrigin.Begin);
            new System.Media.SoundPlayer(mStrm).Play();
            writer.Close();
            mStrm.Close();
            lastplayedsound = DateTime.Now;
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

            public MyCustomApplicationContext()
            {
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
                    var heardsound = await ears.Listen(2000, cancellationtkn);
                    if (heardsound) Globals.lastheardsound = DateTime.Now;
                    var diffInSeconds = (DateTime.Now - Globals.lastheardsound).TotalSeconds;
                    if (diffInSeconds > 600)
                    {
                        Globals.PlayBeep(10, 3000);
                    }
                }
            }

            private void Settings(object? sender, EventArgs e)
            {
                FrmSettings frmsettings = new FrmSettings();
                frmsettings.ShowDialog();
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