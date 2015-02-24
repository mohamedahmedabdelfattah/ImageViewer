namespace ImageViewer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.previewbox = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TestModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SubtractionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChannelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RedChannelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenChannelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueChannelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleChannelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontallyFlipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticallyFlipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._800X600 = new System.Windows.Forms.ToolStripMenuItem();
            this._1024X768 = new System.Windows.Forms.ToolStripMenuItem();
            this._1280x720 = new System.Windows.Forms.ToolStripMenuItem();
            this._1900x1080 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomSizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.opendialog = new System.Windows.Forms.OpenFileDialog();
            this.savedialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.previewbox)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewbox
            // 
            this.previewbox.BackgroundImage = global::ImageViewer.Properties.Resources.TestModeImage;
            this.previewbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewbox.ErrorImage = null;
            this.previewbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("previewbox.InitialImage")));
            this.previewbox.Location = new System.Drawing.Point(0, 28);
            this.previewbox.Name = "previewbox";
            this.previewbox.Size = new System.Drawing.Size(594, 372);
            this.previewbox.TabIndex = 3;
            this.previewbox.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ImageMenu,
            this.ChannelMenu,
            this.FlipMenu,
            this.ResizeMenu,
            this.AboutMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Size = new System.Drawing.Size(594, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            // 
            // FileMenu
            // 
            this.FileMenu.AutoToolTip = true;
            this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.CloseMenu,
            this.SaveMenu,
            this.TestModeMenu,
            this.RestartMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 24);
            this.FileMenu.Text = "&File";
            this.FileMenu.ToolTipText = "Standard files operations";
            // 
            // TestModeMenu
            // 
            this.TestModeMenu.AutoToolTip = true;
            this.TestModeMenu.ForeColor = System.Drawing.Color.Blue;
            this.TestModeMenu.Image = ((System.Drawing.Image)(resources.GetObject("TestModeMenu.Image")));
            this.TestModeMenu.Name = "TestModeMenu";
            this.TestModeMenu.Size = new System.Drawing.Size(175, 24);
            this.TestModeMenu.Text = "&Test Mode";
            this.TestModeMenu.ToolTipText = "Start Test Mode \"\"Requires Restart\"\"";
            this.TestModeMenu.Click += new System.EventHandler(this.TestModeMenu_Click);
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenu.Size = new System.Drawing.Size(175, 24);
            this.OpenMenu.Text = "&Open";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.CloseMenu.Size = new System.Drawing.Size(175, 24);
            this.CloseMenu.Text = "Close";
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenu.Size = new System.Drawing.Size(175, 24);
            this.SaveMenu.Text = "&Save";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // RestartMenu
            // 
            this.RestartMenu.Name = "RestartMenu";
            this.RestartMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.RestartMenu.Size = new System.Drawing.Size(175, 24);
            this.RestartMenu.Text = "Restart";
            this.RestartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitMenu.Size = new System.Drawing.Size(175, 24);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.AutoToolTip = true;
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenu,
            this.CopyMenu,
            this.ResetMenu});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(47, 24);
            this.EditMenu.Text = "&Edit";
            this.EditMenu.ToolTipText = "Undo, Reset or copy Image or Path to the clipboard";
            // 
            // UndoMenu
            // 
            this.UndoMenu.Name = "UndoMenu";
            this.UndoMenu.Size = new System.Drawing.Size(163, 24);
            this.UndoMenu.Text = "Undo";
            this.UndoMenu.Click += new System.EventHandler(this.UndoMenu_Click);
            // 
            // CopyMenu
            // 
            this.CopyMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyImageMenu,
            this.CopyPathMenu});
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenu.Size = new System.Drawing.Size(163, 24);
            this.CopyMenu.Text = "&Copy";
            // 
            // CopyImageMenu
            // 
            this.CopyImageMenu.Name = "CopyImageMenu";
            this.CopyImageMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.CopyImageMenu.Size = new System.Drawing.Size(166, 24);
            this.CopyImageMenu.Text = "&Image";
            this.CopyImageMenu.Click += new System.EventHandler(this.CopyImageMenu_Click);
            // 
            // CopyPathMenu
            // 
            this.CopyPathMenu.Name = "CopyPathMenu";
            this.CopyPathMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.CopyPathMenu.Size = new System.Drawing.Size(166, 24);
            this.CopyPathMenu.Text = "&Path";
            this.CopyPathMenu.Click += new System.EventHandler(this.CopyPathMenu_Click);
            // 
            // ResetMenu
            // 
            this.ResetMenu.Name = "ResetMenu";
            this.ResetMenu.Size = new System.Drawing.Size(163, 24);
            this.ResetMenu.Text = "Reset";
            this.ResetMenu.Click += new System.EventHandler(this.ResetMenu_Click);
            // 
            // ImageMenu
            // 
            this.ImageMenu.AutoToolTip = true;
            this.ImageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdditionMenu,
            this.SubtractionMenu,
            this.EdgeDetectionMenu});
            this.ImageMenu.Name = "ImageMenu";
            this.ImageMenu.Size = new System.Drawing.Size(63, 24);
            this.ImageMenu.Text = "&Image";
            this.ImageMenu.ToolTipText = "Advanced image operations";
            // 
            // AdditionMenu
            // 
            this.AdditionMenu.Name = "AdditionMenu";
            this.AdditionMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.A)));
            this.AdditionMenu.Size = new System.Drawing.Size(271, 24);
            this.AdditionMenu.Text = "Addition";
            this.AdditionMenu.Click += new System.EventHandler(this.AdditionMenu_Click);
            // 
            // SubtractionMenu
            // 
            this.SubtractionMenu.Name = "SubtractionMenu";
            this.SubtractionMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.SubtractionMenu.Size = new System.Drawing.Size(271, 24);
            this.SubtractionMenu.Text = "Subtraction";
            this.SubtractionMenu.Click += new System.EventHandler(this.SubtractionMenu_Click);
            // 
            // EdgeDetectionMenu
            // 
            this.EdgeDetectionMenu.Name = "EdgeDetectionMenu";
            this.EdgeDetectionMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.E)));
            this.EdgeDetectionMenu.Size = new System.Drawing.Size(271, 24);
            this.EdgeDetectionMenu.Text = "Edge Detection";
            this.EdgeDetectionMenu.Click += new System.EventHandler(this.EdgeDetectionMenu_Click);
            // 
            // ChannelMenu
            // 
            this.ChannelMenu.AutoToolTip = true;
            this.ChannelMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedChannelMenu,
            this.GreenChannelMenu,
            this.BlueChannelMenu,
            this.GrayscaleChannelMenu});
            this.ChannelMenu.Name = "ChannelMenu";
            this.ChannelMenu.Size = new System.Drawing.Size(74, 24);
            this.ChannelMenu.Text = "&Channel";
            this.ChannelMenu.ToolTipText = "Change image Channel in RGB Colorspace";
            // 
            // RedChannelMenu
            // 
            this.RedChannelMenu.Name = "RedChannelMenu";
            this.RedChannelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RedChannelMenu.Size = new System.Drawing.Size(194, 24);
            this.RedChannelMenu.Text = "&Red";
            this.RedChannelMenu.Click += new System.EventHandler(this.RedChannelMenu_Click);
            // 
            // GreenChannelMenu
            // 
            this.GreenChannelMenu.Name = "GreenChannelMenu";
            this.GreenChannelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GreenChannelMenu.Size = new System.Drawing.Size(194, 24);
            this.GreenChannelMenu.Text = "&Green";
            this.GreenChannelMenu.Click += new System.EventHandler(this.GreenChannelMenu_Click);
            // 
            // BlueChannelMenu
            // 
            this.BlueChannelMenu.Name = "BlueChannelMenu";
            this.BlueChannelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BlueChannelMenu.Size = new System.Drawing.Size(194, 24);
            this.BlueChannelMenu.Text = "&Blue";
            this.BlueChannelMenu.Click += new System.EventHandler(this.BlueChannelMenu_Click);
            // 
            // GrayscaleChannelMenu
            // 
            this.GrayscaleChannelMenu.Name = "GrayscaleChannelMenu";
            this.GrayscaleChannelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.GrayscaleChannelMenu.Size = new System.Drawing.Size(194, 24);
            this.GrayscaleChannelMenu.Text = "&Grayscale";
            this.GrayscaleChannelMenu.Click += new System.EventHandler(this.GrayChannelMenu_Click);
            // 
            // FlipMenu
            // 
            this.FlipMenu.AutoToolTip = true;
            this.FlipMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontallyFlipMenu,
            this.VerticallyFlipMenu});
            this.FlipMenu.Name = "FlipMenu";
            this.FlipMenu.Size = new System.Drawing.Size(45, 24);
            this.FlipMenu.Text = "&Flip";
            this.FlipMenu.ToolTipText = "Flip image in the basic two dimentions";
            // 
            // HorizontallyFlipMenu
            // 
            this.HorizontallyFlipMenu.Name = "HorizontallyFlipMenu";
            this.HorizontallyFlipMenu.Size = new System.Drawing.Size(159, 24);
            this.HorizontallyFlipMenu.Text = "&Horizontally";
            this.HorizontallyFlipMenu.Click += new System.EventHandler(this.HorizontallyFlipMenu_Click);
            // 
            // VerticallyFlipMenu
            // 
            this.VerticallyFlipMenu.Name = "VerticallyFlipMenu";
            this.VerticallyFlipMenu.Size = new System.Drawing.Size(159, 24);
            this.VerticallyFlipMenu.Text = "&Vertically";
            this.VerticallyFlipMenu.Click += new System.EventHandler(this.VerticallyFlipMenu_Click);
            // 
            // ResizeMenu
            // 
            this.ResizeMenu.AutoToolTip = true;
            this.ResizeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._800X600,
            this._1024X768,
            this._1280x720,
            this._1900x1080,
            this.CustomSizeMenu});
            this.ResizeMenu.Name = "ResizeMenu";
            this.ResizeMenu.Size = new System.Drawing.Size(63, 24);
            this.ResizeMenu.Text = "Resize";
            this.ResizeMenu.ToolTipText = "Resize image with preview";
            // 
            // _800X600
            // 
            this._800X600.Name = "_800X600";
            this._800X600.Size = new System.Drawing.Size(159, 24);
            this._800X600.Text = "800 X 600";
            this._800X600.Click += new System.EventHandler(this._800x600SizeMenu_Click);
            // 
            // _1024X768
            // 
            this._1024X768.Name = "_1024X768";
            this._1024X768.Size = new System.Drawing.Size(159, 24);
            this._1024X768.Text = "1024 X 768";
            this._1024X768.Click += new System.EventHandler(this._1024x768SizeMenu_Click);
            // 
            // _1280x720
            // 
            this._1280x720.Name = "_1280x720";
            this._1280x720.Size = new System.Drawing.Size(159, 24);
            this._1280x720.Text = "1280 X 720";
            this._1280x720.Click += new System.EventHandler(this._1280x720SizeMenu_Click);
            // 
            // _1900x1080
            // 
            this._1900x1080.Name = "_1900x1080";
            this._1900x1080.Size = new System.Drawing.Size(159, 24);
            this._1900x1080.Text = "1900 X 1080";
            this._1900x1080.Click += new System.EventHandler(this._1900x1080SizeMenu_Click);
            // 
            // CustomSizeMenu
            // 
            this.CustomSizeMenu.Name = "CustomSizeMenu";
            this.CustomSizeMenu.Size = new System.Drawing.Size(159, 24);
            this.CustomSizeMenu.Text = "Custom Size";
            this.CustomSizeMenu.Click += new System.EventHandler(this.CustomSizeMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.AutoToolTip = true;
            this.AboutMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("AboutMenu.Image")));
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(62, 24);
            this.AboutMenu.Text = "About";
            this.AboutMenu.ToolTipText = "Information about ImageViewer";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // opendialog
            // 
            this.opendialog.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 400);
            this.Controls.Add(this.previewbox);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.previewbox)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewbox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyImageMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyPathMenu;
        private System.Windows.Forms.ToolStripMenuItem ResetMenu;
        private System.Windows.Forms.ToolStripMenuItem ImageMenu;
        private System.Windows.Forms.ToolStripMenuItem AdditionMenu;
        private System.Windows.Forms.ToolStripMenuItem SubtractionMenu;
        private System.Windows.Forms.ToolStripMenuItem EdgeDetectionMenu;
        private System.Windows.Forms.ToolStripMenuItem ChannelMenu;
        private System.Windows.Forms.ToolStripMenuItem RedChannelMenu;
        private System.Windows.Forms.ToolStripMenuItem GreenChannelMenu;
        private System.Windows.Forms.ToolStripMenuItem BlueChannelMenu;
        private System.Windows.Forms.ToolStripMenuItem GrayscaleChannelMenu;
        private System.Windows.Forms.ToolStripMenuItem FlipMenu;
        private System.Windows.Forms.ToolStripMenuItem HorizontallyFlipMenu;
        private System.Windows.Forms.ToolStripMenuItem VerticallyFlipMenu;
        private System.Windows.Forms.ToolStripMenuItem ResizeMenu;
        private System.Windows.Forms.ToolStripMenuItem _800X600;
        private System.Windows.Forms.ToolStripMenuItem _1024X768;
        private System.Windows.Forms.ToolStripMenuItem _1280x720;
        private System.Windows.Forms.ToolStripMenuItem _1900x1080;
        private System.Windows.Forms.ToolStripMenuItem TestModeMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.OpenFileDialog opendialog;
        private System.Windows.Forms.SaveFileDialog savedialog;
        private System.Windows.Forms.ToolStripMenuItem CustomSizeMenu;

    }
}

