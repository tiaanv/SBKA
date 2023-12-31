using CoreAudioApi;
using System.Data;

namespace SBKA
{
    public partial class FrmSettings : Form
    {
        private MMDevice _sndDevice;
        public FrmSettings()
        {
            InitializeComponent();
            populate_devicelist();
            populate_intervalslider();
            populate_checkboxes();
            tmrLevelIndicator.Enabled = true;
        }


        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            lblLastSound.Text = Globals.lastheardsound.ToString();
            lblLastPlayed.Text = Globals.lastplayedsound.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Globals.PlayBeep(100, 3000);
        }

        private void populate_devicelist()
        {
            var sndDevEnum = new MMDeviceEnumerator();
            cbDevices.Items.Clear();
            cbDevices.Items.Add("Default");
            var devices = sndDevEnum.EnumerateAudioEndPoints(EDataFlow.eRender, EDeviceState.DEVICE_STATE_ACTIVE);
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
            chkDisableDetection.Checked = !Properties.Settings.Default.DetectSound;
            chkDisablewithmonitor.Checked = Properties.Settings.Default.DisableWithMonitor;
            chkDisableWhenLocked.Checked = Properties.Settings.Default.DisableWhenLocked;
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
    }
}