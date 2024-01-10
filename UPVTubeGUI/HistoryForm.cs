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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTubeGUI
{
    public partial class HistoryForm : UPVTubeBase
    {
        public HistoryForm(IUPVTubeService service) : base(service)
        {
            InitializeComponent();
            refreshHistory();
        }

        private void refreshHistory()
        {
            // Get the user's view history from the database
            List<Content> watchedContent = service.GetViewsHistory().ToList();
            
            // Clear the data source of the grid view
            contentsBindingSource.DataSource = null;

            // Populate a new empty list with anonymous objects that represent matching contents
            BindingList<object> bindingList = new BindingList<object>();
            foreach (Content c in watchedContent)
            {
                // Get the last view the logged in user has made for this content
                Visualization lastView = service.GetLastUserVisualization(c);

                // Add an anonymous object with the content info in the bindingList
                bindingList.Add(new
                {
                    ds_title = c.Title,
                    ds_author = c.Owner.Nick,
                    ds_description = c.Description,
                    ds_isPublic = c.IsPublic ? "Yes" : "No",
                    ds_uploadDate = c.UploadDate.ToShortDateString(),
                    ds_lastViewDate = lastView == null ? null : lastView.VisualizationDate.Date.ToShortDateString(),
                    ds_relatedSubjects = string.Join(", ", c.Subjects.Select(s => s.Name)),
                });
            }
            // Use the just populated bindingList as data source for the grid view
            contentsBindingSource.DataSource = bindingList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Content c = service.SearchContent(
                    startDate: DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["uploadDate"].Value.ToString()),
                    endDate: DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["uploadDate"].Value.ToString()),
                    ownerNick: dataGridView1.Rows[e.RowIndex].Cells["author"].Value.ToString(),
                    titleKeyword: dataGridView1.Rows[e.RowIndex].Cells["title"].Value.ToString(),
                    subject: null,
                    status: null,
                    exactTitleMatch: true
                ).ToList()[0];

                if (c != null)
                {
                    SingleContent singleContentForm = new SingleContent(service, c);
                    DialogResult result = singleContentForm.ShowDialog();
                    refreshHistory();
                }
            }
        }
    }
}
