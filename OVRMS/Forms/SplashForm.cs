using System;
using System.Windows.Forms;
using OVRMS.BLL;

namespace OVRMS
{
    public partial class SplashForm : Form
    {
        private Timer _hideTimer;
        private Forms.LoginForm _mainForm;


        public SplashForm()
        {
            InitializeComponent();

            _hideTimer = new Timer();
            _hideTimer.Interval = 2000;
            _hideTimer.Enabled = true;
            _hideTimer.Tick += hideTimer_Tick;
            _hideTimer.Start();

            _mainForm = new Forms.LoginForm();
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
            _hideTimer.Stop();
            this.Hide();
            _mainForm.Show();
        }

    }
}
