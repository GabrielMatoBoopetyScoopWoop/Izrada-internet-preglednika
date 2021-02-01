namespace WebBrowser
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.NaprijedButton = new System.Windows.Forms.Button();
            this.NatragButton = new System.Windows.Forms.Button();
            this.IdiButton = new System.Windows.Forms.Button();
            this.AdresaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IspisButton = new System.Windows.Forms.Button();
            this.WebmailButton = new System.Windows.Forms.Button();
            this.GmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1692, 854);
            this.webBrowser1.TabIndex = 0;
            // 
            // NaprijedButton
            // 
            this.NaprijedButton.Location = new System.Drawing.Point(12, 12);
            this.NaprijedButton.Name = "NaprijedButton";
            this.NaprijedButton.Size = new System.Drawing.Size(75, 23);
            this.NaprijedButton.TabIndex = 1;
            this.NaprijedButton.Text = "Naprijed";
            this.NaprijedButton.UseVisualStyleBackColor = true;
            this.NaprijedButton.Click += new System.EventHandler(this.NaprijedButton_Click);
            // 
            // NatragButton
            // 
            this.NatragButton.Location = new System.Drawing.Point(93, 12);
            this.NatragButton.Name = "NatragButton";
            this.NatragButton.Size = new System.Drawing.Size(75, 23);
            this.NatragButton.TabIndex = 2;
            this.NatragButton.Text = "Natrag";
            this.NatragButton.UseVisualStyleBackColor = true;
            this.NatragButton.Click += new System.EventHandler(this.NatragButton_Click);
            // 
            // IdiButton
            // 
            this.IdiButton.Location = new System.Drawing.Point(385, 11);
            this.IdiButton.Name = "IdiButton";
            this.IdiButton.Size = new System.Drawing.Size(75, 23);
            this.IdiButton.TabIndex = 3;
            this.IdiButton.Text = "Idi";
            this.IdiButton.UseVisualStyleBackColor = true;
            this.IdiButton.Click += new System.EventHandler(this.IdiButton_Click);
            // 
            // AdresaText
            // 
            this.AdresaText.Location = new System.Drawing.Point(220, 13);
            this.AdresaText.Name = "AdresaText";
            this.AdresaText.Size = new System.Drawing.Size(159, 20);
            this.AdresaText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresa";
            // 
            // IspisButton
            // 
            this.IspisButton.Location = new System.Drawing.Point(628, 12);
            this.IspisButton.Name = "IspisButton";
            this.IspisButton.Size = new System.Drawing.Size(75, 23);
            this.IspisButton.TabIndex = 6;
            this.IspisButton.Text = "Ispis";
            this.IspisButton.UseVisualStyleBackColor = true;
            this.IspisButton.Click += new System.EventHandler(this.IspisButton_Click);
            // 
            // WebmailButton
            // 
            this.WebmailButton.Location = new System.Drawing.Point(547, 11);
            this.WebmailButton.Name = "WebmailButton";
            this.WebmailButton.Size = new System.Drawing.Size(75, 23);
            this.WebmailButton.TabIndex = 7;
            this.WebmailButton.Text = "Webmail";
            this.WebmailButton.UseVisualStyleBackColor = true;
            this.WebmailButton.Click += new System.EventHandler(this.WebmailButton_Click);
            // 
            // GmailButton
            // 
            this.GmailButton.Location = new System.Drawing.Point(466, 11);
            this.GmailButton.Name = "GmailButton";
            this.GmailButton.Size = new System.Drawing.Size(75, 23);
            this.GmailButton.TabIndex = 8;
            this.GmailButton.Text = "Gmail";
            this.GmailButton.UseVisualStyleBackColor = true;
            this.GmailButton.Click += new System.EventHandler(this.GmailButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 902);
            this.Controls.Add(this.GmailButton);
            this.Controls.Add(this.WebmailButton);
            this.Controls.Add(this.IspisButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresaText);
            this.Controls.Add(this.IdiButton);
            this.Controls.Add(this.NatragButton);
            this.Controls.Add(this.NaprijedButton);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button NaprijedButton;
        private System.Windows.Forms.Button NatragButton;
        private System.Windows.Forms.Button IdiButton;
        private System.Windows.Forms.TextBox AdresaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IspisButton;
        private System.Windows.Forms.Button WebmailButton;
        private System.Windows.Forms.Button GmailButton;
    }
}

