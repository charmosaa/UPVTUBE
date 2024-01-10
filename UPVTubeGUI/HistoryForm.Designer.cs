namespace UPVTubeGUI
{
    partial class HistoryForm
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
            this.contentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatedSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastViewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.relatedSubjects,
            this.lastViewDate});
            this.dataGridView1.DataSource = this.contentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 373);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // title
            // 
            this.title.DataPropertyName = "ds_title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // author
            // 
            this.author.DataPropertyName = "ds_author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // description
            // 
            this.description.DataPropertyName = "ds_description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // isPublic
            // 
            this.isPublic.DataPropertyName = "ds_isPublic";
            this.isPublic.HeaderText = "Public?";
            this.isPublic.Name = "isPublic";
            // 
            // uploadDate
            // 
            this.uploadDate.DataPropertyName = "ds_uploadDate";
            this.uploadDate.HeaderText = "Upload Date";
            this.uploadDate.Name = "uploadDate";
            // 
            // relatedSubjects
            // 
            this.relatedSubjects.DataPropertyName = "ds_relatedSubjects";
            this.relatedSubjects.HeaderText = "Related Subjects";
            this.relatedSubjects.Name = "relatedSubjects";
            // 
            // lastViewDate
            // 
            this.lastViewDate.DataPropertyName = "ds_lastViewDate";
            this.lastViewDate.HeaderText = "Last Viewed";
            this.lastViewDate.Name = "lastViewDate";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 436);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(528, 360);
            this.Name = "HistoryForm";
            this.Text = "History";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contentsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn relatedSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastViewDate;
    }
}