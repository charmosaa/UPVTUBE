using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpvTube;
using UpvTube.BusinessLogic.Services;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class RegisterForm : UPVTubeBase
    {
        public RegisterForm(IUPVTubeService service) : base(service)
        {
            InitializeComponent();
            this.KeyPress += RegisterForm_EnterPress;
            this.AcceptButton = registerButton;
        }

        private void RegisterForm_EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                registerButton.PerformClick();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.RegisterNewUser(emailTextBox.Text, fullNameTextBox.Text, nickTextBox.Text, passwordTextBox.Text);
                DialogResult answer = MessageBox.Show(this, Messages.InfoRegisterSuccess, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.goToLogIn();
            }
            catch (ServiceException ex)
            {
                DialogResult answer = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
