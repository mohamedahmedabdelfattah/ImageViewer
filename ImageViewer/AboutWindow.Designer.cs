namespace ImageViewer
{
    partial class AboutWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.abouttxt = new System.Windows.Forms.Label();
            this.producttxt = new System.Windows.Forms.Label();
            this.developrtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abouttxt
            // 
            this.abouttxt.BackColor = System.Drawing.Color.Transparent;
            this.abouttxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abouttxt.Location = new System.Drawing.Point(29, 35);
            this.abouttxt.Name = "abouttxt";
            this.abouttxt.Size = new System.Drawing.Size(243, 100);
            this.abouttxt.TabIndex = 1;
            this.abouttxt.Text = "Features:\r\n- Drag && Drop Support.\r\n- Resizing.\r\n- Flipping.\r\n- Channels.\r\n- Addi" +
                "tion && Subtraction.";
            this.abouttxt.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // producttxt
            // 
            this.producttxt.BackColor = System.Drawing.Color.Transparent;
            this.producttxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producttxt.ForeColor = System.Drawing.Color.Blue;
            this.producttxt.Location = new System.Drawing.Point(65, 2);
            this.producttxt.Name = "producttxt";
            this.producttxt.Size = new System.Drawing.Size(170, 26);
            this.producttxt.TabIndex = 2;
            this.producttxt.Text = "ImagaViewer v1.91";
            this.producttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.producttxt.Click += new System.EventHandler(this.producttxt_Click);
            // 
            // developrtxt
            // 
            this.developrtxt.BackColor = System.Drawing.Color.Transparent;
            this.developrtxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developrtxt.ForeColor = System.Drawing.Color.Navy;
            this.developrtxt.Location = new System.Drawing.Point(4, 131);
            this.developrtxt.Name = "developrtxt";
            this.developrtxt.Size = new System.Drawing.Size(293, 40);
            this.developrtxt.TabIndex = 3;
            this.developrtxt.Text = "Developed by Mohamed Ahmed Abdel Fattah\r\nE-Mail:eng.mafattah@hotmail.com";
            this.developrtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.developrtxt.Click += new System.EventHandler(this.developrtxt_Click);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 177);
            this.Controls.Add(this.developrtxt);
            this.Controls.Add(this.producttxt);
            this.Controls.Add(this.abouttxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.About_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.About_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label abouttxt;
        private System.Windows.Forms.Label producttxt;
        private System.Windows.Forms.Label developrtxt;

    }
}