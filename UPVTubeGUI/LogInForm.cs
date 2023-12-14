﻿using System;
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
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.Login(nickInput.Text, passwordInput.Text);
                DialogResult answer = MessageBox.Show(this, "user logged in", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ServiceException ex)
            {
                DialogResult answer = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }
    }
}