﻿namespace Packet_Capture_Tool
{
    partial class PackageDetailForm
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
            this.packageId = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.checksumText = new System.Windows.Forms.Label();
            this.windowsSizeText = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.sequenceNumberText = new System.Windows.Forms.Label();
            this.flagsText = new System.Windows.Forms.RichTextBox();
            this.sourceAndDestinationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package ID:";
            // 
            // packageId
            // 
            this.packageId.Location = new System.Drawing.Point(85, 6);
            this.packageId.Name = "packageId";
            this.packageId.Size = new System.Drawing.Size(100, 20);
            this.packageId.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(191, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checksumText
            // 
            this.checksumText.AutoSize = true;
            this.checksumText.Location = new System.Drawing.Point(12, 108);
            this.checksumText.Name = "checksumText";
            this.checksumText.Size = new System.Drawing.Size(63, 13);
            this.checksumText.TabIndex = 4;
            this.checksumText.Text = "Checksum: ";
            // 
            // windowsSizeText
            // 
            this.windowsSizeText.AutoSize = true;
            this.windowsSizeText.Location = new System.Drawing.Point(132, 108);
            this.windowsSizeText.Name = "windowsSizeText";
            this.windowsSizeText.Size = new System.Drawing.Size(80, 13);
            this.windowsSizeText.TabIndex = 10;
            this.windowsSizeText.Text = "Windows Size: ";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(12, 76);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(48, 13);
            this.headerText.TabIndex = 12;
            this.headerText.Text = "Header: ";
            // 
            // sequenceNumberText
            // 
            this.sequenceNumberText.AutoSize = true;
            this.sequenceNumberText.Location = new System.Drawing.Point(268, 108);
            this.sequenceNumberText.Name = "sequenceNumberText";
            this.sequenceNumberText.Size = new System.Drawing.Size(102, 13);
            this.sequenceNumberText.TabIndex = 14;
            this.sequenceNumberText.Text = "Sequence Number: ";
            // 
            // flagsText
            // 
            this.flagsText.AccessibleName = "";
            this.flagsText.BackColor = System.Drawing.SystemColors.Control;
            this.flagsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagsText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flagsText.Location = new System.Drawing.Point(12, 131);
            this.flagsText.Name = "flagsText";
            this.flagsText.Size = new System.Drawing.Size(569, 124);
            this.flagsText.TabIndex = 20;
            this.flagsText.Text = "---------------------------------------------------------------------------------" +
    "---> FLAGS <--------------------------------------------------------------------" +
    "----------------";
            // 
            // sourceAndDestinationText
            // 
            this.sourceAndDestinationText.AutoSize = true;
            this.sourceAndDestinationText.Location = new System.Drawing.Point(12, 45);
            this.sourceAndDestinationText.Name = "sourceAndDestinationText";
            this.sourceAndDestinationText.Size = new System.Drawing.Size(47, 13);
            this.sourceAndDestinationText.TabIndex = 21;
            this.sourceAndDestinationText.Text = "Source: ";
            // 
            // PackageDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.sourceAndDestinationText);
            this.Controls.Add(this.flagsText);
            this.Controls.Add(this.sequenceNumberText);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.windowsSizeText);
            this.Controls.Add(this.checksumText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.packageId);
            this.Controls.Add(this.label1);
            this.Name = "PackageDetailForm";
            this.Text = "Package Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox packageId;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label checksumText;
        private System.Windows.Forms.Label windowsSizeText;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label sequenceNumberText;
        private System.Windows.Forms.RichTextBox flagsText;
        private System.Windows.Forms.Label sourceAndDestinationText;
    }
}