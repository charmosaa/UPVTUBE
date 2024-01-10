using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpvTube.BusinessLogic.Services;
using UPVTube.Entities;

namespace UPVTubeGUI
{
    public partial class SubscriptionsForm : UPVTubeBase
    {
        private ICollection<Content> subscribedContents;
        public SubscriptionsForm(IUPVTubeService service): base(service)
        {
            InitializeComponent();
            subscribedContents = service.GetSubscribedContents();
            this.contentTable.AllowUserToAddRows = false;
        }
        private void ReloadData()
        {
            subscribedContents = service.GetSubscribedContents();
            AddData();
        }

        public void AddData()
        {
            BindingList<object> bindingList = new BindingList<object>();
            foreach (Content c in subscribedContents)
            {
                // Get the last view the logged in user has made for this content
                Visualization lastView = service.GetLastUserVisualization(c);

                // Add an anonymous object with the content info in the bindingList
                bindingList.Add(new
                {
                    Title = c.Title,
                    Author = c.Owner.Nick,
                    Description = c.Description,
                    isPublic = c.IsPublic ? "Yes" : "No",
                    UploadDate = c.UploadDate.ToShortDateString(),
                    LastViewDate = lastView == null ? null : lastView.VisualizationDate.Date.ToString(),
                    RelatedSubjects = string.Join(", ", c.Subjects.Select(s => s.Name)),
                });
            }
            // Use the just populated bindingList as data source for the grid view
            contentTable.DataSource = bindingList;
        }

        private void SubscriptionsForm_Load(object sender, EventArgs e)
        {
            AddData();
        }

        private void contentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < subscribedContents.ToList().Count)
            {
                Content content = subscribedContents.ToList()[e.RowIndex];
                SingleContent singleContentForm = new SingleContent(service, content);
                DialogResult result = singleContentForm.ShowDialog();
                ReloadData();
            }
        }
    }
}
