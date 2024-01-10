namespace UPVTubeGUI
{
    partial class SubscriptionsForm
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
            this.contentTable = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatedSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastViewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTable
            // 
            this.contentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentTable.Location = new System.Drawing.Point(14, 74);
            this.contentTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentTable.Name = "contentTable";
            this.contentTable.RowHeadersWidth = 51;
            this.contentTable.RowTemplate.Height = 24;
            this.contentTable.Size = new System.Drawing.Size(796, 429);
            this.contentTable.TabIndex = 4;
            this.contentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentTable_CellClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ds_title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ds_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ds_isPublic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Public?";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ds_uploadDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Upload Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ds_relatedSubjects";
            this.dataGridViewTextBoxColumn6.HeaderText = "Related Subjects";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ds_lastViewDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Viewed";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // SubscriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.contentTable);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SubscriptionsForm";
            this.Text = "Subscribed creators\' content";
            this.Load += new System.EventHandler(this.SubscriptionsForm_Load);
            this.Controls.SetChildIndex(this.contentTable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.contentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView contentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn relatedSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastViewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}