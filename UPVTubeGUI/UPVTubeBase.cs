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

namespace UPVTubeGUI
{
    public partial class UPVTubeBase : Form
    {

        public IUPVTubeService service;
        private LogInForm logInForm;
        private RegisterForm registerForm;

        public UPVTubeBase()
        {
            InitializeComponent();
        }
    
        public UPVTubeBase(IUPVTubeService Service):this()
        {
            this.service = Service;
            UpdateMenuBarVisibility();
        }

        protected void UpdateMenuBarVisibility()
        {
            menuStripLoggedIn.Visible = service.IsLoggedIn();
            menuStripLoggedOut.Visible = !service.IsLoggedIn();
        }

        private void initializeDBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            service.DBInitialization();
            MessageBox.Show(this, "Database has been initialized", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInForm = new LogInForm(service);
            logInForm.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UPVTubeBase_Load(object sender, EventArgs e)
        {
         
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service.Logout();
            UpdateMenuBarVisibility();
            MessageBox.Show(this, "You have been logged out", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            logInForm = new LogInForm(service);
            logInForm.ShowDialog();
            this.Close();
        }

        private void clearDBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            service.RemoveAllData();
            UpdateMenuBarVisibility();
            MessageBox.Show(this, "Database has been cleared", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm = new RegisterForm(service);
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
