namespace ImageViewer
{
    partial class CustomSizeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSizeWindow));
            this.Resizebtn = new System.Windows.Forms.Button();
            this.Widthlbl = new System.Windows.Forms.Label();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.widthtxt = new System.Windows.Forms.TextBox();
            this.heighttxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Resizebtn
            // 
            this.Resizebtn.Location = new System.Drawing.Point(78, 44);
            this.Resizebtn.Name = "Resizebtn";
            this.Resizebtn.Size = new System.Drawing.Size(75, 23);
            this.Resizebtn.TabIndex = 0;
            this.Resizebtn.Text = "Resize";
            this.Resizebtn.UseVisualStyleBackColor = true;
            this.Resizebtn.Click += new System.EventHandler(this.customsizesubmit_Click);
            // 
            // Widthlbl
            // 
            this.Widthlbl.AutoSize = true;
            this.Widthlbl.Location = new System.Drawing.Point(8, 17);
            this.Widthlbl.Name = "Widthlbl";
            this.Widthlbl.Size = new System.Drawing.Size(35, 13);
            this.Widthlbl.TabIndex = 1;
            this.Widthlbl.Text = "Width";
            // 
            // Heightlbl
            // 
            this.Heightlbl.AutoSize = true;
            this.Heightlbl.Location = new System.Drawing.Point(114, 17);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(38, 13);
            this.Heightlbl.TabIndex = 2;
            this.Heightlbl.Text = "Height";
            // 
            // widthtxt
            // 
            this.widthtxt.Location = new System.Drawing.Point(46, 14);
            this.widthtxt.Name = "widthtxt";
            this.widthtxt.Size = new System.Drawing.Size(53, 20);
            this.widthtxt.TabIndex = 3;
            // 
            // heighttxt
            // 
            this.heighttxt.Location = new System.Drawing.Point(154, 14);
            this.heighttxt.Name = "heighttxt";
            this.heighttxt.Size = new System.Drawing.Size(60, 20);
            this.heighttxt.TabIndex = 4;
            // 
            // CustomSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 77);
            this.Controls.Add(this.heighttxt);
            this.Controls.Add(this.widthtxt);
            this.Controls.Add(this.Heightlbl);
            this.Controls.Add(this.Widthlbl);
            this.Controls.Add(this.Resizebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomSizeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.CustomSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Resizebtn;
        private System.Windows.Forms.Label Widthlbl;
        private System.Windows.Forms.Label Heightlbl;
        private System.Windows.Forms.TextBox widthtxt;
        private System.Windows.Forms.TextBox heighttxt;
    }
}