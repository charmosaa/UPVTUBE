using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpvTube.BusinessLogic.Services;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class LogInForm : UPVTubeBase
    {
        public LogInForm(IUPVTubeService service): base(service)
        {
            InitializeComponent();
            this.KeyPress += LoginForm_EnterPress;
            this.AcceptButton = logInButton;
        }

        private void LoginForm_EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logInButton.PerformClick();
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.Login(nickInput.Text, passwordInput.Text);
                DialogResult answer = MessageBox.Show(this, "User logged in", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ServiceException ex)
            {
                DialogResult answer = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                base.UpdateMenuBarVisibility();
            }
        }
    }
}
