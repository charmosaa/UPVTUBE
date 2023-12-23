namespace UPVTubeGUI
{
    partial class UploadNewContentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.isPublicCheckbox = new System.Windows.Forms.CheckBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.uriInput = new System.Windows.Forms.TextBox();
            this.addNewContentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "URI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Public";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subjects";
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.ItemHeight = 20;
            this.subjectsListBox.Location = new System.Drawing.Point(145, 251);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.subjectsListBox.Size = new System.Drawing.Size(303, 104);
            this.subjectsListBox.TabIndex = 11;
            this.subjectsListBox.SelectedIndexChanged += new System.EventHandler(this.subjectsListBox_SelectedIndexChanged);
            // 
            // isPublicCheckbox
            // 
            this.isPublicCheckbox.AutoSize = true;
            this.isPublicCheckbox.Location = new System.Drawing.Point(145, 209);
            this.isPublicCheckbox.Name = "isPublicCheckbox";
            this.isPublicCheckbox.Size = new System.Drawing.Size(22, 21);
            this.isPublicCheckbox.TabIndex = 10;
            this.isPublicCheckbox.UseVisualStyleBackColor = true;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(145, 77);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(303, 26);
            this.titleInput.TabIndex = 7;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(145, 121);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(303, 26);
            this.descriptionInput.TabIndex = 8;
            // 
            // uriInput
            // 
            this.uriInput.Location = new System.Drawing.Point(145, 165);
            this.uriInput.Name = "uriInput";
            this.uriInput.Size = new System.Drawing.Size(303, 26);
            this.uriInput.TabIndex = 9;
            // 
            // addNewContentButton
            // 
            this.addNewContentButton.Location = new System.Drawing.Point(232, 443);
            this.addNewContentButton.Name = "addNewContentButton";
            this.addNewContentButton.Size = new System.Drawing.Size(95, 41);
            this.addNewContentButton.TabIndex = 12;
            this.addNewContentButton.Text = "Submit";
            this.addNewContentButton.UseVisualStyleBackColor = true;
            this.addNewContentButton.Click += new System.EventHandler(this.addNewContentButton_Click);
            // 
            // UploadNewContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 537);
            this.Controls.Add(this.subjectsListBox);
            this.Controls.Add(this.addNewContentButton);
            this.Controls.Add(this.uriInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.isPublicCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UploadNewContentForm";
            this.Text = "UploadNewContentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.CheckBox isPublicCheckbox;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox uriInput;
        private System.Windows.Forms.Button addNewContentButton;
    }
}