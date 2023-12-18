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
            this.evaluationAcceptButton = new System.Windows.Forms.Button();
            this.evaluationRejectButton = new System.Windows.Forms.Button();
            this.authLabel = new System.Windows.Forms.Label();
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
            // evaluationAcceptButton
            // 
            this.evaluationAcceptButton.Location = new System.Drawing.Point(88, 258);
            this.evaluationAcceptButton.Name = "evaluationAcceptButton";
            this.evaluationAcceptButton.Size = new System.Drawing.Size(96, 34);
            this.evaluationAcceptButton.TabIndex = 8;
            this.evaluationAcceptButton.Text = "Accept";
            this.evaluationAcceptButton.UseVisualStyleBackColor = true;
            this.evaluationAcceptButton.Click += new System.EventHandler(this.evaluationButton_Click);
            // 
            // evaluationRejectButton
            // 
            this.evaluationRejectButton.Location = new System.Drawing.Point(190, 258);
            this.evaluationRejectButton.Name = "evaluationRejectButton";
            this.evaluationRejectButton.Size = new System.Drawing.Size(96, 34);
            this.evaluationRejectButton.TabIndex = 9;
            this.evaluationRejectButton.Text = "Reject";
            this.evaluationRejectButton.UseVisualStyleBackColor = true;
            this.evaluationRejectButton.Click += new System.EventHandler(this.evaluationRejectButton_Click);
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Location = new System.Drawing.Point(85, 239);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(151, 16);
            this.authLabel.TabIndex = 10;
            this.authLabel.Text = "Content is not authorized";
            // 
            // SingleContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.evaluationRejectButton);
            this.Controls.Add(this.evaluationAcceptButton);
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
            this.Controls.SetChildIndex(this.evaluationAcceptButton, 0);
            this.Controls.SetChildIndex(this.evaluationRejectButton, 0);
            this.Controls.SetChildIndex(this.authLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contentTitle;
        private System.Windows.Forms.Label contentDetails;
        private System.Windows.Forms.Label contentDescription;
        private System.Windows.Forms.LinkLabel contentUrl;
        private System.Windows.Forms.Button evaluationAcceptButton;
        private System.Windows.Forms.Button evaluationRejectButton;
        private System.Windows.Forms.Label authLabel;
    }
}