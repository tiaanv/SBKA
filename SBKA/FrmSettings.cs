using Microsoft.Win32;
using NAudio.CoreAudioApi;
using System.Data;
using static SBKA.Globals;

namespace SBKA
{
    public partial class FrmSettings : Form
    {
        private MMDevice _sndDevice;
        private const string StartupKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private const string AppName = "SBKA";

        public FrmSettings()
        {
            InitializeComponent();
            populate_devicelist();
            populate_intervalslider();
            populate_checkboxes();
            populate_outputboost();
            populate_outputduration();
            populate_outputfreq();
            populate_trayicon();
            populate_outputrate();
            tmrLevelIndicator.Enabled = true;
        }


        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            lblLastSound.Text = Globals.lastheardsound.ToString();
            lblLastPlayed.Text = Globals.lastplayedsound.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Globals.PlayBeep();
        }

        private void populate_devicelist()
        {
            var sndDevEnum = new MMDeviceEnumerator();
            cbDevices.Items.Clear();
            cbDevices.Items.Add("Default");
            var devices = sndDevEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            for (int i = 0; i < devices.Count; i++)
            {
                cbDevices.Items.Add(devices[i].FriendlyName);
            }

            cbDevices.Text = Properties.Settings.Default.AudioDevice;

        }

        private void populate_intervalslider()
        {
            tbInterval.Value = Properties.Settings.Default.Interval;
        }

        private void populate_checkboxes()
        {
            chkStartup.Checked = !Properties.Settings.Default.Startup;
            chkDisableDetection.Checked = !Properties.Settings.Default.DetectSound;
            chkDisablewithmonitor.Checked = Properties.Settings.Default.DisableWithMonitor;
            chkDisableWhenLocked.Checked = Properties.Settings.Default.DisableWhenLocked;
        }

        private void populate_outputboost()
        {
            tbOutputBoost.Value = Properties.Settings.Default.OutputBoost;
        }

        private void populate_outputduration()
        {
            tbOutputDuration.Value = Properties.Settings.Default.OutputDuration;
        }

        private void populate_outputfreq()
        {
            tbOutputFreq.Value = Properties.Settings.Default.OutputFreq;
        }

        private void populate_trayicon()
        {
            cbTrayIcon.Text = Properties.Settings.Default.TrayIconMode;
        }
        private void populate_outputrate()
        {
            if (Properties.Settings.Default.OutputRate != "48000")
            {
                cbSampleRate.Text = "44100Hz";
            }
            else
            {
                cbSampleRate.Text = Properties.Settings.Default.OutputRate + "Hz";
            }
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AudioDevice = cbDevices.Text;
            Properties.Settings.Default.Save();
            var sndDevEnum = new MMDeviceEnumerator();
            _sndDevice = sndDevEnum.GetDevice(Globals.getdeviceid(Properties.Settings.Default.AudioDevice));
            tmrLevelIndicator.Enabled = true;
        }

        private void tbInterval_ValueChanged(object sender, EventArgs e)
        {
            lblInterval.Text = tbInterval.Value.ToString() + " seconds";
            Properties.Settings.Default.Interval = tbInterval.Value;
            Properties.Settings.Default.Save();
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Startup = !chkStartup.Checked;
            Properties.Settings.Default.Save();
            using var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (chkStartup.Checked)
            {
                key?.SetValue(
                    "SBKA",
                    $"\"{Application.ExecutablePath}\"");
            }
            else
            {
                key?.DeleteValue("SBKA", false);
            }
        }

        private void chkDisableDetection_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DetectSound = !chkDisableDetection.Checked;
            Properties.Settings.Default.Save();
        }

        private void tmrLevelIndicator_Tick(object sender, EventArgs e)
        {
            try
            {
                var currentVolumnLevel = (int)(_sndDevice.AudioMeterInformation.MasterPeakValue * 100);
                pbLevel.Value = currentVolumnLevel;
            }
            catch (Exception)
            {
                tmrLevelIndicator.Enabled = false;
                MessageBox.Show("Invalid Sound Device detected. Please review settings", "Warning");
            }
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrLevelIndicator.Enabled = false;
        }

        private void lblInterval_Click(object sender, EventArgs e)
        {

        }

        private void chkDisablewithmonitor_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DisableWithMonitor = chkDisablewithmonitor.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkDisableWhenLocked_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DisableWhenLocked = chkDisableWhenLocked.Checked;
            Properties.Settings.Default.Save();

        }
        private void tbOutputBoost_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputBoost = tbOutputBoost.Value;
            Properties.Settings.Default.Save();
        }
        private void tbOutputDuration_ValueChanged(object sender, EventArgs e)
        {
            lblDuration.Text = tbOutputDuration.Value.ToString() + " Seconds";
            Properties.Settings.Default.OutputDuration = tbOutputDuration.Value;
            Properties.Settings.Default.Save();
        }
        private void tbOutputFreq_ValueChanged(object sender, EventArgs e)
        {
            lblOutputFreq.Text = tbOutputFreq.Value.ToString() + "Hz";
            Properties.Settings.Default.OutputFreq = tbOutputFreq.Value;
            Properties.Settings.Default.Save();
        }
        private void cbTrayIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TrayIconMode = cbTrayIcon.Text;
            Properties.Settings.Default.Save();
            TrayEvents.RaiseTrayIconChanged();
        }
        private void cbSampleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSampleRate.Text != "44100Hz" && cbSampleRate.Text != "48000Hz")
            {
                cbSampleRate.Text = "44100Hz";
            }
            Properties.Settings.Default.OutputRate = cbSampleRate.Text;
            Properties.Settings.Default.Save();
        }

    }
}