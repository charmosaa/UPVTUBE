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
    public partial class UploadNewContentForm : UPVTubeBase
    {
        public UploadNewContentForm(IUPVTubeService service) : base(service)
        {
            InitializeComponent();
            InitializeSubjectsListBox();
        }

        private void InitializeSubjectsListBox()
        {
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "Code";

            foreach (var s in service.GetAllSubjects())
            {
                checkedListBox1.Items.Add(s);
            }
        }

        private void ClearInputs()
        {
            titleInput.Text = "";
            descriptionInput.Text = "";
            uriInput.Text = "";
            isPublicCheckbox.Checked = false;
            checkedListBox1.ClearSelected();
        }


        private void addNewContentButton_Click(object sender, EventArgs e)
        {
            string contentURI = uriInput.Text;
            string description = descriptionInput.Text;
            bool isPublic = isPublicCheckbox.Checked;
            string title = titleInput.Text;

            List<Subject> selectedSubjects = new List<Subject>();
            foreach (var s in checkedListBox1.CheckedItems)
            {
                selectedSubjects.Add((Subject)s);
            }

            try
            {
                service.UploadNewContent(contentURI, description, isPublic, title, selectedSubjects);
                DialogResult result = MessageBox.Show("New Content Uploaded Successfully!\nWould you like to add another one?\nIf not, the content list will open.", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ClearInputs();
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                    SearchForm searchForm = new SearchForm(service, UPVTube.Entities.Authorized.Yes);
                    searchForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCount = checkedListBox1.CheckedItems.Count;
            if (selectedCount > 3)
            {
                MessageBox.Show("You can only select up to 3 subjects.", "Subjects selection limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
