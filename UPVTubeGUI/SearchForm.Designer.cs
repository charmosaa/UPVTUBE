namespace UPVTubeGUI
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatedSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastViewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByDateLbl = new System.Windows.Forms.Label();
            this.startingDateLbl = new System.Windows.Forms.Label();
            this.startingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.searchByAuthorLbl = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.searchByTitleLbl = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.searchBySubjectLbl = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.author,
            this.description,
            this.isPublic,
            this.uploadDate,
            this.relatedSubject,
            this.lastViewDate});
            this.dataGridView1.DataSource = this.contentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 190);
            this.dataGridView1.TabIndex = 4;
            // 
            // title
            // 
            this.title.DataPropertyName = "ds_title";
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // author
            // 
            this.author.DataPropertyName = "ds_author";
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "ds_description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // isPublic
            // 
            this.isPublic.DataPropertyName = "ds_isPublic";
            this.isPublic.HeaderText = "Public?";
            this.isPublic.MinimumWidth = 6;
            this.isPublic.Name = "isPublic";
            this.isPublic.Width = 125;
            // 
            // uploadDate
            // 
            this.uploadDate.DataPropertyName = "ds_uploadDate";
            this.uploadDate.HeaderText = "Upload Date";
            this.uploadDate.MinimumWidth = 6;
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.Width = 125;
            // 
            // relatedSubject
            // 
            this.relatedSubject.DataPropertyName = "ds_relatedSubjects";
            this.relatedSubject.HeaderText = "Related Subjects";
            this.relatedSubject.MinimumWidth = 6;
            this.relatedSubject.Name = "relatedSubject";
            this.relatedSubject.Width = 125;
            // 
            // lastViewDate
            // 
            this.lastViewDate.DataPropertyName = "ds_lastViewDate";
            this.lastViewDate.HeaderText = "Last Viewed";
            this.lastViewDate.MinimumWidth = 6;
            this.lastViewDate.Name = "lastViewDate";
            this.lastViewDate.Width = 125;
            // 
            // searchByDateLbl
            // 
            this.searchByDateLbl.AutoSize = true;
            this.searchByDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDateLbl.Location = new System.Drawing.Point(9, 40);
            this.searchByDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchByDateLbl.Name = "searchByDateLbl";
            this.searchByDateLbl.Size = new System.Drawing.Size(99, 13);
            this.searchByDateLbl.TabIndex = 5;
            this.searchByDateLbl.Text = "Search by Date:";
            // 
            // startingDateLbl
            // 
            this.startingDateLbl.AutoSize = true;
            this.startingDateLbl.Location = new System.Drawing.Point(127, 40);
            this.startingDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startingDateLbl.Name = "startingDateLbl";
            this.startingDateLbl.Size = new System.Drawing.Size(30, 13);
            this.startingDateLbl.TabIndex = 6;
            this.startingDateLbl.Text = "from:";
            // 
            // startingDatePicker
            // 
            this.startingDatePicker.Checked = false;
            this.startingDatePicker.CustomFormat = " dd/MM/yyyy";
            this.startingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startingDatePicker.Location = new System.Drawing.Point(161, 37);
            this.startingDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startingDatePicker.Name = "startingDatePicker";
            this.startingDatePicker.ShowCheckBox = true;
            this.startingDatePicker.Size = new System.Drawing.Size(91, 20);
            this.startingDatePicker.TabIndex = 7;
            this.startingDatePicker.Value = new System.DateTime(2023, 12, 21, 0, 0, 0, 0);
            this.startingDatePicker.ValueChanged += new System.EventHandler(this.updateSearchResults);
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(257, 40);
            this.endDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(19, 13);
            this.endDateLbl.TabIndex = 8;
            this.endDateLbl.Text = "to:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Checked = false;
            this.endDatePicker.CustomFormat = " dd/MM/yyyy";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(280, 37);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.ShowCheckBox = true;
            this.endDatePicker.Size = new System.Drawing.Size(91, 20);
            this.endDatePicker.TabIndex = 9;
            this.endDatePicker.Value = new System.DateTime(2023, 12, 22, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.updateSearchResults);
            // 
            // searchByAuthorLbl
            // 
            this.searchByAuthorLbl.AutoSize = true;
            this.searchByAuthorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByAuthorLbl.Location = new System.Drawing.Point(9, 70);
            this.searchByAuthorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchByAuthorLbl.Name = "searchByAuthorLbl";
            this.searchByAuthorLbl.Size = new System.Drawing.Size(109, 13);
            this.searchByAuthorLbl.TabIndex = 10;
            this.searchByAuthorLbl.Text = "Search by Author:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(130, 67);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(241, 20);
            this.authorTextBox.TabIndex = 11;
            this.authorTextBox.TextChanged += new System.EventHandler(this.updateSearchResults);
            // 
            // searchByTitleLbl
            // 
            this.searchByTitleLbl.AutoSize = true;
            this.searchByTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByTitleLbl.Location = new System.Drawing.Point(9, 100);
            this.searchByTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchByTitleLbl.Name = "searchByTitleLbl";
            this.searchByTitleLbl.Size = new System.Drawing.Size(97, 13);
            this.searchByTitleLbl.TabIndex = 12;
            this.searchByTitleLbl.Text = "Search by Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(130, 97);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(241, 20);
            this.titleTextBox.TabIndex = 13;
            this.titleTextBox.TextChanged += new System.EventHandler(this.updateSearchResults);
            // 
            // searchBySubjectLbl
            // 
            this.searchBySubjectLbl.AutoSize = true;
            this.searchBySubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubjectLbl.Location = new System.Drawing.Point(9, 130);
            this.searchBySubjectLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchBySubjectLbl.Name = "searchBySubjectLbl";
            this.searchBySubjectLbl.Size = new System.Drawing.Size(115, 13);
            this.searchBySubjectLbl.TabIndex = 14;
            this.searchBySubjectLbl.Text = "Search by Subject:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(130, 127);
            this.subjectComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(241, 21);
            this.subjectComboBox.TabIndex = 15;
            this.subjectComboBox.TextChanged += new System.EventHandler(this.updateSearchResults);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.searchBySubjectLbl);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.searchByTitleLbl);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.searchByAuthorLbl);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateLbl);
            this.Controls.Add(this.startingDatePicker);
            this.Controls.Add(this.startingDateLbl);
            this.Controls.Add(this.searchByDateLbl);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.searchByDateLbl, 0);
            this.Controls.SetChildIndex(this.startingDateLbl, 0);
            this.Controls.SetChildIndex(this.startingDatePicker, 0);
            this.Controls.SetChildIndex(this.endDateLbl, 0);
            this.Controls.SetChildIndex(this.endDatePicker, 0);
            this.Controls.SetChildIndex(this.searchByAuthorLbl, 0);
            this.Controls.SetChildIndex(this.authorTextBox, 0);
            this.Controls.SetChildIndex(this.searchByTitleLbl, 0);
            this.Controls.SetChildIndex(this.titleTextBox, 0);
            this.Controls.SetChildIndex(this.searchBySubjectLbl, 0);
            this.Controls.SetChildIndex(this.subjectComboBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contentsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label searchByDateLbl;
        private System.Windows.Forms.Label startingDateLbl;
        private System.Windows.Forms.DateTimePicker startingDatePicker;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label searchByAuthorLbl;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label searchByTitleLbl;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label searchBySubjectLbl;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn relatedSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastViewDate;
    }
}