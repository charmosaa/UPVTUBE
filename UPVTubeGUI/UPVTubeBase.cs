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
    public partial class UPVTubeBase : Form
    {

        public IUPVTubeService service;
        private LogInForm logInForm;
        private RegisterForm registerForm;
        private SearchForm searchForm;
        private HistoryForm historyForm;
        private SubscriptionsForm subscriptionsForm;
        private UPVTubeApp upvTubeApp;
        private UploadNewContentForm uploadNewContentForm;

        public UPVTubeBase()
        {
            InitializeComponent();
        }

        public UPVTubeBase(IUPVTubeService Service) : this()
        {
            this.service = Service;
            UpdateMenuBarVisibility();
        }

        protected void UpdateMenuBarVisibility()
        {
            menuStripLoggedIn.Visible = service.IsLoggedIn();
            menuStripLoggedOut.Visible = !service.IsLoggedIn();
            pendingToolStripMenuItem.Visible = service.isTeacherLogged();
            addToolStripMenuItem.Visible = service.isUPVMemberLogged();
            historyToolStripMenuItem.Visible = service.isUPVMemberLogged();
        }

        protected void initializeDB()
        {
            try
            {
                service.DBInitialization();
                MessageBox.Show(this, "Database has been initialized", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initializeDBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            initializeDB();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goToLogIn();
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
            try
            {
                service.Logout();
                UpdateMenuBarVisibility();
                MessageBox.Show(this, "You have been logged out", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goToLogIn();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                service.RemoveAllData();
                UpdateMenuBarVisibility();
                MessageBox.Show(this, "Database has been cleared", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                upvTubeApp = new UPVTubeApp(service);
                upvTubeApp.ShowDialog();
                this.Close();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm = new RegisterForm(service);
            registerForm.ShowDialog();
            this.Close();
        }

        private void pendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchForm = new SearchForm(service, UPVTube.Entities.Authorized.Pending);
            searchForm.ShowDialog();
            this.Close();
        }

        protected void goToLogIn()
        {
            this.Hide();
            logInForm = new LogInForm(service);
            logInForm.ShowDialog();
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            uploadNewContentForm = new UploadNewContentForm(service);
            uploadNewContentForm.ShowDialog();
            this.Close();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchForm = new SearchForm(service, UPVTube.Entities.Authorized.Yes);
            searchForm.ShowDialog();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            historyForm = new HistoryForm(service);
            historyForm.ShowDialog();
            this.Close();
        }

        private void subscribedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            subscriptionsForm = new SubscriptionsForm(service);
            subscriptionsForm.ShowDialog();
            this.Close();
        }
    }
}
