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

namespace UPVTubeGUI
{
    public partial class SingleContent : UPVTubeBase
    {
        private Content content;

        private void UpdateEvaluationButtonsVisibility()
        {
            this.evaluationButton.Visible = this.content.Authorized == Authorized.Pending && service.isTeacherLogged();
        }

        public SingleContent(IUPVTubeService service, Content content) : base(service)
        {
            InitializeComponent();
            this.content = content;
            this.contentTitle.Text = content.Title;
            this.contentDetails.Text = "By " + content.Owner.Nick + " (" + content.UploadDate.Date.ToShortDateString() + ")";
            this.contentDescription.Text = content.Description;
            this.contentUrl.Text = content.ContentURI;
            UpdateEvaluationButtonsVisibility();
        }
    }
}
