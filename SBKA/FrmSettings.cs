namespace SBKA
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
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
    }
}