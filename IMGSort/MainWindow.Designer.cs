namespace IMGSort
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ImageCountBox = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.Label();
            this.SubmitTagButton = new System.Windows.Forms.Button();
            this.TagEntryBox = new System.Windows.Forms.TextBox();
            this.PictureViewer = new System.Windows.Forms.PictureBox();
            this.CreditsBox = new System.Windows.Forms.Label();
            this.ExitBox = new System.Windows.Forms.Button();
            this.RunBox = new System.Windows.Forms.Button();
            this.DeleteOriginalBox = new System.Windows.Forms.CheckBox();
            this.FileFormatBox = new System.Windows.Forms.GroupBox();
            this.jpgButton = new System.Windows.Forms.CheckBox();
            this.gifButton = new System.Windows.Forms.CheckBox();
            this.bmpButton = new System.Windows.Forms.CheckBox();
            this.jpegButton = new System.Windows.Forms.CheckBox();
            this.pngButton = new System.Windows.Forms.CheckBox();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathButton = new System.Windows.Forms.Button();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.InputPathLabel = new System.Windows.Forms.Label();
            this.InputPathButton = new System.Windows.Forms.Button();
            this.InputPathBox = new System.Windows.Forms.TextBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.VersionBox = new System.Windows.Forms.Label();
            this.mp4Button = new System.Windows.Forms.CheckBox();
            this.webmButton = new System.Windows.Forms.CheckBox();
            this.aviButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).BeginInit();
            this.FileFormatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCountBox
            // 
            this.ImageCountBox.Location = new System.Drawing.Point(-3, 309);
            this.ImageCountBox.Name = "ImageCountBox";
            this.ImageCountBox.Size = new System.Drawing.Size(670, 15);
            this.ImageCountBox.TabIndex = 33;
            this.ImageCountBox.Text = "IMAGE_COUNT";
            this.ImageCountBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileNameBox
            // 
            this.FileNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameBox.Location = new System.Drawing.Point(-3, 323);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(670, 15);
            this.FileNameBox.TabIndex = 32;
            this.FileNameBox.Text = "FILE_NAME";
            this.FileNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitTagButton
            // 
            this.SubmitTagButton.Location = new System.Drawing.Point(449, 276);
            this.SubmitTagButton.Name = "SubmitTagButton";
            this.SubmitTagButton.Size = new System.Drawing.Size(82, 22);
            this.SubmitTagButton.TabIndex = 31;
            this.SubmitTagButton.Text = "Next";
            this.SubmitTagButton.UseVisualStyleBackColor = true;
            this.SubmitTagButton.Click += new System.EventHandler(this.SubmitTagButton_Click);
            // 
            // TagEntryBox
            // 
            this.TagEntryBox.Location = new System.Drawing.Point(134, 275);
            this.TagEntryBox.Name = "TagEntryBox";
            this.TagEntryBox.Size = new System.Drawing.Size(309, 23);
            this.TagEntryBox.TabIndex = 30;
            // 
            // PictureViewer
            // 
            this.PictureViewer.Location = new System.Drawing.Point(31, 12);
            this.PictureViewer.Name = "PictureViewer";
            this.PictureViewer.Size = new System.Drawing.Size(603, 248);
            this.PictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureViewer.TabIndex = 29;
            this.PictureViewer.TabStop = false;
            this.PictureViewer.Visible = false;
            // 
            // CreditsBox
            // 
            this.CreditsBox.AutoSize = true;
            this.CreditsBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditsBox.Location = new System.Drawing.Point(409, 34);
            this.CreditsBox.Name = "CreditsBox";
            this.CreditsBox.Size = new System.Drawing.Size(214, 38);
            this.CreditsBox.TabIndex = 28;
            this.CreditsBox.Text = "© 2020-2022 Robert Sammataro\r\nFree for home use";
            this.CreditsBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExitBox
            // 
            this.ExitBox.Location = new System.Drawing.Point(453, 336);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(82, 22);
            this.ExitBox.TabIndex = 27;
            this.ExitBox.Text = "Exit";
            this.ExitBox.UseVisualStyleBackColor = true;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // RunBox
            // 
            this.RunBox.Location = new System.Drawing.Point(547, 336);
            this.RunBox.Name = "RunBox";
            this.RunBox.Size = new System.Drawing.Size(82, 22);
            this.RunBox.TabIndex = 26;
            this.RunBox.Text = "Run";
            this.RunBox.UseVisualStyleBackColor = true;
            this.RunBox.Click += new System.EventHandler(this.RunBox_Click);
            // 
            // DeleteOriginalBox
            // 
            this.DeleteOriginalBox.AutoSize = true;
            this.DeleteOriginalBox.Location = new System.Drawing.Point(36, 336);
            this.DeleteOriginalBox.Name = "DeleteOriginalBox";
            this.DeleteOriginalBox.Size = new System.Drawing.Size(145, 19);
            this.DeleteOriginalBox.TabIndex = 25;
            this.DeleteOriginalBox.Text = "Delete Original Images";
            this.DeleteOriginalBox.UseVisualStyleBackColor = true;
            // 
            // FileFormatBox
            // 
            this.FileFormatBox.Controls.Add(this.aviButton);
            this.FileFormatBox.Controls.Add(this.webmButton);
            this.FileFormatBox.Controls.Add(this.mp4Button);
            this.FileFormatBox.Controls.Add(this.jpgButton);
            this.FileFormatBox.Controls.Add(this.gifButton);
            this.FileFormatBox.Controls.Add(this.bmpButton);
            this.FileFormatBox.Controls.Add(this.jpegButton);
            this.FileFormatBox.Controls.Add(this.pngButton);
            this.FileFormatBox.Location = new System.Drawing.Point(36, 256);
            this.FileFormatBox.Name = "FileFormatBox";
            this.FileFormatBox.Size = new System.Drawing.Size(593, 60);
            this.FileFormatBox.TabIndex = 24;
            this.FileFormatBox.TabStop = false;
            this.FileFormatBox.Text = "Included File Formats";
            // 
            // jpgButton
            // 
            this.jpgButton.AutoSize = true;
            this.jpgButton.Location = new System.Drawing.Point(89, 25);
            this.jpgButton.Name = "jpgButton";
            this.jpgButton.Size = new System.Drawing.Size(46, 19);
            this.jpgButton.TabIndex = 9;
            this.jpgButton.Text = ".jpg";
            this.jpgButton.UseVisualStyleBackColor = true;
            // 
            // gifButton
            // 
            this.gifButton.AutoSize = true;
            this.gifButton.Location = new System.Drawing.Point(233, 25);
            this.gifButton.Name = "gifButton";
            this.gifButton.Size = new System.Drawing.Size(43, 19);
            this.gifButton.TabIndex = 11;
            this.gifButton.Text = ".gif";
            this.gifButton.UseVisualStyleBackColor = true;
            // 
            // bmpButton
            // 
            this.bmpButton.AutoSize = true;
            this.bmpButton.Location = new System.Drawing.Point(302, 25);
            this.bmpButton.Name = "bmpButton";
            this.bmpButton.Size = new System.Drawing.Size(54, 19);
            this.bmpButton.TabIndex = 12;
            this.bmpButton.Text = ".bmp";
            this.bmpButton.UseVisualStyleBackColor = true;
            // 
            // jpegButton
            // 
            this.jpegButton.AutoSize = true;
            this.jpegButton.Location = new System.Drawing.Point(159, 25);
            this.jpegButton.Name = "jpegButton";
            this.jpegButton.Size = new System.Drawing.Size(52, 19);
            this.jpegButton.TabIndex = 10;
            this.jpegButton.Text = ".jpeg";
            this.jpegButton.UseVisualStyleBackColor = true;
            // 
            // pngButton
            // 
            this.pngButton.AutoSize = true;
            this.pngButton.Location = new System.Drawing.Point(15, 25);
            this.pngButton.Name = "pngButton";
            this.pngButton.Size = new System.Drawing.Size(50, 19);
            this.pngButton.TabIndex = 8;
            this.pngButton.Text = ".png";
            this.pngButton.UseVisualStyleBackColor = true;
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputPathLabel.Location = new System.Drawing.Point(36, 184);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(163, 17);
            this.OutputPathLabel.TabIndex = 23;
            this.OutputPathLabel.Text = "Output Directory Location";
            // 
            // OutputPathButton
            // 
            this.OutputPathButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputPathButton.Location = new System.Drawing.Point(547, 202);
            this.OutputPathButton.Name = "OutputPathButton";
            this.OutputPathButton.Size = new System.Drawing.Size(82, 23);
            this.OutputPathButton.TabIndex = 22;
            this.OutputPathButton.Text = "Browse";
            this.OutputPathButton.UseVisualStyleBackColor = true;
            this.OutputPathButton.Click += new System.EventHandler(this.OutputPathButton_Click);
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputPathBox.Location = new System.Drawing.Point(36, 202);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.Size = new System.Drawing.Size(505, 23);
            this.OutputPathBox.TabIndex = 21;
            // 
            // InputPathLabel
            // 
            this.InputPathLabel.AutoSize = true;
            this.InputPathLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPathLabel.Location = new System.Drawing.Point(36, 121);
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Size = new System.Drawing.Size(153, 17);
            this.InputPathLabel.TabIndex = 20;
            this.InputPathLabel.Text = "Input Directory Location";
            // 
            // InputPathButton
            // 
            this.InputPathButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPathButton.Location = new System.Drawing.Point(547, 140);
            this.InputPathButton.Name = "InputPathButton";
            this.InputPathButton.Size = new System.Drawing.Size(82, 23);
            this.InputPathButton.TabIndex = 19;
            this.InputPathButton.Text = "Browse";
            this.InputPathButton.UseVisualStyleBackColor = true;
            this.InputPathButton.Click += new System.EventHandler(this.InputPathButton_Click);
            // 
            // InputPathBox
            // 
            this.InputPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPathBox.Location = new System.Drawing.Point(36, 140);
            this.InputPathBox.Name = "InputPathBox";
            this.InputPathBox.Size = new System.Drawing.Size(505, 23);
            this.InputPathBox.TabIndex = 18;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(36, 23);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(228, 63);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 17;
            this.LogoBox.TabStop = false;
            // 
            // VersionBox
            // 
            this.VersionBox.AutoSize = true;
            this.VersionBox.Location = new System.Drawing.Point(7, 360);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(79, 15);
            this.VersionBox.TabIndex = 34;
            this.VersionBox.Text = "Version 1.0.2b";
            // 
            // mp4Button
            // 
            this.mp4Button.AutoSize = true;
            this.mp4Button.Location = new System.Drawing.Point(374, 25);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(53, 19);
            this.mp4Button.TabIndex = 13;
            this.mp4Button.Text = ".mp4";
            this.mp4Button.UseVisualStyleBackColor = true;
            // 
            // webmButton
            // 
            this.webmButton.AutoSize = true;
            this.webmButton.Location = new System.Drawing.Point(447, 25);
            this.webmButton.Name = "webmButton";
            this.webmButton.Size = new System.Drawing.Size(62, 19);
            this.webmButton.TabIndex = 14;
            this.webmButton.Text = ".webm";
            this.webmButton.UseVisualStyleBackColor = true;
            // 
            // aviButton
            // 
            this.aviButton.AutoSize = true;
            this.aviButton.Location = new System.Drawing.Point(526, 25);
            this.aviButton.Name = "aviButton";
            this.aviButton.Size = new System.Drawing.Size(44, 19);
            this.aviButton.TabIndex = 15;
            this.aviButton.Text = ".avi";
            this.aviButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.CreditsBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.RunBox);
            this.Controls.Add(this.DeleteOriginalBox);
            this.Controls.Add(this.FileFormatBox);
            this.Controls.Add(this.OutputPathLabel);
            this.Controls.Add(this.OutputPathButton);
            this.Controls.Add(this.OutputPathBox);
            this.Controls.Add(this.InputPathLabel);
            this.Controls.Add(this.InputPathButton);
            this.Controls.Add(this.InputPathBox);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.SubmitTagButton);
            this.Controls.Add(this.TagEntryBox);
            this.Controls.Add(this.PictureViewer);
            this.Controls.Add(this.ImageCountBox);
            this.Controls.Add(this.FileNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IMGSort";
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).EndInit();
            this.FileFormatBox.ResumeLayout(false);
            this.FileFormatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ImageCountBox;
        private Label FileNameBox;
        private Button SubmitTagButton;
        private TextBox TagEntryBox;
        private PictureBox PictureViewer;
        private Label CreditsBox;
        private Button ExitBox;
        private Button RunBox;
        private CheckBox DeleteOriginalBox;
        private GroupBox FileFormatBox;
        private CheckBox jpgButton;
        private CheckBox gifButton;
        private CheckBox bmpButton;
        private CheckBox jpegButton;
        private CheckBox pngButton;
        private Label OutputPathLabel;
        private Button OutputPathButton;
        private TextBox OutputPathBox;
        private Label InputPathLabel;
        private Button InputPathButton;
        private TextBox InputPathBox;
        private PictureBox LogoBox;
        private Label VersionBox;
        private CheckBox aviButton;
        private CheckBox webmButton;
        private CheckBox mp4Button;
    }
}