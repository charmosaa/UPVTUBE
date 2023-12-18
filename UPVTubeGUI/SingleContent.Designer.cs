namespace UPVTubeGUI
{
    partial class SingleContent
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
            this.contentTitle = new System.Windows.Forms.Label();
            this.contentDetails = new System.Windows.Forms.Label();
            this.contentDescription = new System.Windows.Forms.Label();
            this.contentUrl = new System.Windows.Forms.LinkLabel();
            this.evaluationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentTitle
            // 
            this.contentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTitle.AutoSize = true;
            this.contentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTitle.Location = new System.Drawing.Point(83, 87);
            this.contentTitle.Name = "contentTitle";
            this.contentTitle.Size = new System.Drawing.Size(68, 25);
            this.contentTitle.TabIndex = 4;
            this.contentTitle.Text = "Name";
            this.contentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentDetails
            // 
            this.contentDetails.AutoSize = true;
            this.contentDetails.Location = new System.Drawing.Point(85, 112);
            this.contentDetails.Name = "contentDetails";
            this.contentDetails.Size = new System.Drawing.Size(47, 16);
            this.contentDetails.TabIndex = 5;
            this.contentDetails.Text = "details";
            // 
            // contentDescription
            // 
            this.contentDescription.Location = new System.Drawing.Point(85, 132);
            this.contentDescription.Name = "contentDescription";
            this.contentDescription.Size = new System.Drawing.Size(350, 60);
            this.contentDescription.TabIndex = 6;
            this.contentDescription.Text = "description";
            // 
            // contentUrl
            // 
            this.contentUrl.AutoSize = true;
            this.contentUrl.Location = new System.Drawing.Point(85, 196);
            this.contentUrl.Name = "contentUrl";
            this.contentUrl.Size = new System.Drawing.Size(27, 16);
            this.contentUrl.TabIndex = 7;
            this.contentUrl.TabStop = true;
            this.contentUrl.Text = "link";
            // 
            // evaluationButton
            // 
            this.evaluationButton.Location = new System.Drawing.Point(88, 258);
            this.evaluationButton.Name = "evaluationButton";
            this.evaluationButton.Size = new System.Drawing.Size(96, 34);
            this.evaluationButton.TabIndex = 8;
            this.evaluationButton.Text = "Evaluate";
            this.evaluationButton.UseVisualStyleBackColor = true;
            // 
            // SingleContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.evaluationButton);
            this.Controls.Add(this.contentUrl);
            this.Controls.Add(this.contentDescription);
            this.Controls.Add(this.contentDetails);
            this.Controls.Add(this.contentTitle);
            this.Name = "SingleContent";
            this.Text = "SingleContent";
            this.Controls.SetChildIndex(this.contentTitle, 0);
            this.Controls.SetChildIndex(this.contentDetails, 0);
            this.Controls.SetChildIndex(this.contentDescription, 0);
            this.Controls.SetChildIndex(this.contentUrl, 0);
            this.Controls.SetChildIndex(this.evaluationButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contentTitle;
        private System.Windows.Forms.Label contentDetails;
        private System.Windows.Forms.Label contentDescription;
        private System.Windows.Forms.LinkLabel contentUrl;
        private System.Windows.Forms.Button evaluationButton;
    }
}