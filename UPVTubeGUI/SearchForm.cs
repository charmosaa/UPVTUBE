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
    public partial class SearchForm : UPVTubeBase
    {

        private Authorized? statusFilter;

        public SearchForm(IUPVTubeService service) : base(service)
        {
            InitializeComponent();
            LoadSubjects();
            this.dataGridView1.AllowUserToAddRows = false;
            this.statusFilter = null;
        }

        public SearchForm(IUPVTubeService service, Authorized statusFilter) : base(service)
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            this.statusFilter = statusFilter;
            LoadSubjects();
        }

        private List<Subject> subjects;

        private void LoadSubjects()
        {
            subjects = service.GetAllSubjects().ToList();
            subjectComboBox.Items.Clear();
            foreach (Subject s in subjects)
            {
                subjectComboBox.Items.Add(s.FullName+" ("+s.Name+")");
            }
            subjectComboBox.SelectedIndex = -1;
            subjectComboBox.ResetText();
            updateSearchResults(); 
        }

        private void updateSearchResults()
        {
            this.updateSearchResults(null, null);
        }
        private void updateSearchResults(object sender, EventArgs e)
        {
            // Get contents in the database that match current searching filters
            List<Content> matchingContents = service.SearchContent(
                startDate: startingDatePicker.Checked ? startingDatePicker.Value : startingDatePicker.MinDate,
                endDate: endDatePicker.Checked ? endDatePicker.Value : endDatePicker.MaxDate,
                ownerNick: authorTextBox.Text,
                titleKeyword: titleTextBox.Text,
                subject: subjectComboBox.SelectedIndex == -1 ? null : subjects[subjectComboBox.SelectedIndex],
                status: statusFilter
            ).ToList();

            // Sort the matching content by upload date (more recent goes first)
            matchingContents.Sort((x, y) => DateTime.Compare(y.UploadDate, x.UploadDate));

            // Clear the data source of the grid view
            contentsBindingSource.DataSource = null;

            // Populate a new empty list with anonymous objects that represent matching contents
            BindingList<object> bindingList = new BindingList<object>();
            foreach (Content c in matchingContents)
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
                    ds_lastViewDate = lastView == null ? null : lastView.VisualizationDate.Date.ToString(),
                    ds_relatedSubjects = string.Join(", ", c.Subjects.Select(s => s.Name)),
                });
            }
            // Use the just populated bindingList as data source for the grid view
            contentsBindingSource.DataSource = bindingList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content c = service.SearchContent(
                startDate: startingDatePicker.MinDate,
                endDate: startingDatePicker.MaxDate,
                ownerNick: dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                titleKeyword: dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                subject: null,
                status: statusFilter // This filter here does not change anything particular, just have to be defined.
            ).ToList()[0];

            if (c != null)
            {
                SingleContent singleContentForm = new SingleContent(service, c);
                DialogResult result = singleContentForm.ShowDialog();
                updateSearchResults(); // Updating the results, because the content could become authorized.
            }
        }
    }
}
