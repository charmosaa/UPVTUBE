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
    public partial class RegisterForm : UPVTubeBase
    {
        public RegisterForm(IUPVTubeService service) : base(service)
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.RegisterNewUser(emailTextBox.Text,fullNameTextBox.Text,nickTextBox.Text, passwordTextBox.Text);
                DialogResult answer = MessageBox.Show(this, "user registered", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServiceException ex)
            {
                DialogResult answer = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
