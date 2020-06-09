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
            this.label2 = new System.Windows.Forms.Label();
            this.checksumText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ackText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.synText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.windowsSizeText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checksum:";
            // 
            // checksumText
            // 
            this.checksumText.AutoSize = true;
            this.checksumText.Location = new System.Drawing.Point(67, 121);
            this.checksumText.Name = "checksumText";
            this.checksumText.Size = new System.Drawing.Size(84, 13);
            this.checksumText.TabIndex = 4;
            this.checksumText.Text = "Não encontrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACK:";
            // 
            // ackText
            // 
            this.ackText.AutoSize = true;
            this.ackText.Location = new System.Drawing.Point(67, 88);
            this.ackText.Name = "ackText";
            this.ackText.Size = new System.Drawing.Size(84, 13);
            this.ackText.TabIndex = 6;
            this.ackText.Text = "Não encontrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Syn:";
            // 
            // synText
            // 
            this.synText.AutoSize = true;
            this.synText.Location = new System.Drawing.Point(209, 88);
            this.synText.Name = "synText";
            this.synText.Size = new System.Drawing.Size(84, 13);
            this.synText.TabIndex = 8;
            this.synText.Text = "Não encontrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Windows Size:";
            // 
            // windowsSizeText
            // 
            this.windowsSizeText.AutoSize = true;
            this.windowsSizeText.Location = new System.Drawing.Point(258, 121);
            this.windowsSizeText.Name = "windowsSizeText";
            this.windowsSizeText.Size = new System.Drawing.Size(84, 13);
            this.windowsSizeText.TabIndex = 10;
            this.windowsSizeText.Text = "Não encontrado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Header:";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(67, 55);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(84, 13);
            this.headerText.TabIndex = 12;
            this.headerText.Text = "Não encontrado";
            // 
            // PackageDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.windowsSizeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.synText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ackText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checksumText);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checksumText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ackText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label synText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label windowsSizeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label headerText;
    }
}