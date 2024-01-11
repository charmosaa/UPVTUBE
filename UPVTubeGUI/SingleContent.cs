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
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class SingleContent : Form
    {
        private Content content;
        private EvaluationRejectionForm evaluationRejectionForm;
        private IUPVTubeService service;

        private void UpdateEvaluationButtonsVisibility()
        {
            bool isVisible = this.content.Authorized == Authorized.Pending && service.isTeacherLogged();
            this.evaluationAcceptButton.Visible = isVisible;
            this.evaluationRejectButton.Visible = isVisible;
        }

        private void UpdateAuthorizationInfo()
        {
            this.authLabel.Text = content.Authorized == Authorized.Yes ? Messages.InfoContentIsAuthorized : Messages.InfoContentIsNotAuthorized;
        }

        public SingleContent(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
            this.contentTitle.Text = content.Title;
            this.contentDetails.Text = "By " + content.Owner.Nick + " (" + content.UploadDate.Date.ToShortDateString() + ")";
            this.contentDescription.Text = content.Description;
            this.contentUrl.Text = content.ContentURI;
            UpdateEvaluationButtonsVisibility();
            UpdateAuthorizationInfo();
            service.RegisterVisualization(content);
        }

        private void evaluationButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.AddReviewToPendingContent(content, null);
                MessageBox.Show(this, Messages.InfoEvaluationAddSuccess, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateEvaluationButtonsVisibility();
                UpdateAuthorizationInfo();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void evaluationRejectButton_Click(object sender, EventArgs e)
        {
            evaluationRejectionForm = new EvaluationRejectionForm(service, content);
            DialogResult result = evaluationRejectionForm.ShowDialog();
            UpdateEvaluationButtonsVisibility();
            UpdateAuthorizationInfo();
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.AddSubscription(content.Owner);
                MessageBox.Show(this, Messages.InfoCreatorSubscribed, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.RemoveSubscription(content.Owner);
                MessageBox.Show(this, Messages.InfoCreatorUnsubscribed, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
