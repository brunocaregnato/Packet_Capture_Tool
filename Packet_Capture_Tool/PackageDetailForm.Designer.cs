namespace Packet_Capture_Tool
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
            this.acknowledgmentNumberText = new System.Windows.Forms.Label();
            this.dataOffsetText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package ID:";
            // 
            // packageId
            // 
            this.packageId.Location = new System.Drawing.Point(113, 7);
            this.packageId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.packageId.Name = "packageId";
            this.packageId.Size = new System.Drawing.Size(132, 22);
            this.packageId.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(249, 4);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checksumText
            // 
            this.checksumText.AutoSize = true;
            this.checksumText.Location = new System.Drawing.Point(16, 137);
            this.checksumText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checksumText.Name = "checksumText";
            this.checksumText.Size = new System.Drawing.Size(77, 16);
            this.checksumText.TabIndex = 4;
            this.checksumText.Text = "Checksum: ";
            // 
            // windowsSizeText
            // 
            this.windowsSizeText.AutoSize = true;
            this.windowsSizeText.Location = new System.Drawing.Point(276, 137);
            this.windowsSizeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowsSizeText.Name = "windowsSizeText";
            this.windowsSizeText.Size = new System.Drawing.Size(98, 16);
            this.windowsSizeText.TabIndex = 10;
            this.windowsSizeText.Text = "Windows Size: ";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(16, 94);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(60, 16);
            this.headerText.TabIndex = 12;
            this.headerText.Text = "Header: ";
            // 
            // sequenceNumberText
            // 
            this.sequenceNumberText.AutoSize = true;
            this.sequenceNumberText.Location = new System.Drawing.Point(508, 137);
            this.sequenceNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sequenceNumberText.Name = "sequenceNumberText";
            this.sequenceNumberText.Size = new System.Drawing.Size(127, 16);
            this.sequenceNumberText.TabIndex = 14;
            this.sequenceNumberText.Text = "Sequence Number: ";
            // 
            // flagsText
            // 
            this.flagsText.AccessibleName = "";
            this.flagsText.BackColor = System.Drawing.SystemColors.Control;
            this.flagsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagsText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flagsText.Location = new System.Drawing.Point(16, 200);
            this.flagsText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flagsText.Name = "flagsText";
            this.flagsText.Size = new System.Drawing.Size(757, 152);
            this.flagsText.TabIndex = 20;
            this.flagsText.Text = "---------------------------------------------------------------------------------" +
    "---> FLAGS <--------------------------------------------------------------------" +
    "----------------";
            // 
            // sourceAndDestinationText
            // 
            this.sourceAndDestinationText.AutoSize = true;
            this.sourceAndDestinationText.Location = new System.Drawing.Point(16, 55);
            this.sourceAndDestinationText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceAndDestinationText.Name = "sourceAndDestinationText";
            this.sourceAndDestinationText.Size = new System.Drawing.Size(57, 16);
            this.sourceAndDestinationText.TabIndex = 21;
            this.sourceAndDestinationText.Text = "Source: ";
            // 
            // acknowledgmentNumberText
            // 
            this.acknowledgmentNumberText.AutoSize = true;
            this.acknowledgmentNumberText.Location = new System.Drawing.Point(16, 173);
            this.acknowledgmentNumberText.Name = "acknowledgmentNumberText";
            this.acknowledgmentNumberText.Size = new System.Drawing.Size(168, 16);
            this.acknowledgmentNumberText.TabIndex = 22;
            this.acknowledgmentNumberText.Text = "Acknowledgment Number: ";
            // 
            // dataOffsetText
            // 
            this.dataOffsetText.AutoSize = true;
            this.dataOffsetText.Location = new System.Drawing.Point(276, 173);
            this.dataOffsetText.Name = "dataOffsetText";
            this.dataOffsetText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataOffsetText.Size = new System.Drawing.Size(77, 16);
            this.dataOffsetText.TabIndex = 23;
            this.dataOffsetText.Text = "DataOffset: ";
            this.dataOffsetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PackageDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 360);
            this.Controls.Add(this.dataOffsetText);
            this.Controls.Add(this.acknowledgmentNumberText);
            this.Controls.Add(this.sourceAndDestinationText);
            this.Controls.Add(this.flagsText);
            this.Controls.Add(this.sequenceNumberText);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.windowsSizeText);
            this.Controls.Add(this.checksumText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.packageId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PackageDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label acknowledgmentNumberText;
        private System.Windows.Forms.Label dataOffsetText;
    }
}