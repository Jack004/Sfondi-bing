namespace bingPotd
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
            this.bEnable = new System.Windows.Forms.Button();
            this.bDisable = new System.Windows.Forms.Button();
            this.lUseless1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEnable
            // 
            this.bEnable.Location = new System.Drawing.Point(12, 25);
            this.bEnable.Name = "bEnable";
            this.bEnable.Size = new System.Drawing.Size(75, 23);
            this.bEnable.TabIndex = 0;
            this.bEnable.Text = "Enable";
            this.bEnable.UseVisualStyleBackColor = true;
            this.bEnable.Click += new System.EventHandler(this.bEnable_Click);
            // 
            // bDisable
            // 
            this.bDisable.Location = new System.Drawing.Point(93, 25);
            this.bDisable.Name = "bDisable";
            this.bDisable.Size = new System.Drawing.Size(75, 23);
            this.bDisable.TabIndex = 1;
            this.bDisable.Text = "Disable";
            this.bDisable.UseVisualStyleBackColor = true;
            this.bDisable.Click += new System.EventHandler(this.bDisable_Click);
            // 
            // lUseless1
            // 
            this.lUseless1.AutoSize = true;
            this.lUseless1.Location = new System.Drawing.Point(12, 9);
            this.lUseless1.Name = "lUseless1";
            this.lUseless1.Size = new System.Drawing.Size(102, 13);
            this.lUseless1.TabIndex = 2;
            this.lUseless1.Text = "Start at boot status: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Jack004";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(121, 9);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(35, 13);
            this.lStatus.TabIndex = 4;
            this.lStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 69);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lUseless1);
            this.Controls.Add(this.bDisable);
            this.Controls.Add(this.bEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BingPotd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnable;
        private System.Windows.Forms.Button bDisable;
        private System.Windows.Forms.Label lUseless1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lStatus;
    }
}