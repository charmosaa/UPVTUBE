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
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class EvaluationRejectionForm : Form
    {

        Content content;
        IUPVTubeService service;

        public EvaluationRejectionForm(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.AddReviewToPendingContent(content, this.rejectTextBox.Text);
                MessageBox.Show(this, "Evaluation of the content has been added.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch(ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
