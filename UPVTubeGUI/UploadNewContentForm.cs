﻿using System;
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
                DialogResult result = MessageBox.Show(Messages.InfoUploadContentSuccess, "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedCount = checkedListBox1.CheckedItems.Count;

            if (e.NewValue == CheckState.Checked && selectedCount >= 3)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show(Messages.ErrorMoreThan3Subjects, "Subjects selection limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
