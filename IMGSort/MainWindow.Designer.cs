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
            ImageCountBox = new Label();
            FileNameBox = new Label();
            SubmitTagButton = new Button();
            TagEntryBox = new TextBox();
            CreditsBox = new Label();
            ExitBox = new Button();
            RunBox = new Button();
            DeleteOriginalBox = new CheckBox();
            FileFormatBox = new GroupBox();
            aviButton = new CheckBox();
            webmButton = new CheckBox();
            mp4Button = new CheckBox();
            jpgButton = new CheckBox();
            gifButton = new CheckBox();
            bmpButton = new CheckBox();
            jpegButton = new CheckBox();
            pngButton = new CheckBox();
            OutputPathLabel = new Label();
            OutputPathButton = new Button();
            OutputPathBox = new TextBox();
            InputPathLabel = new Label();
            InputPathButton = new Button();
            InputPathBox = new TextBox();
            LogoBox = new PictureBox();
            VersionBox = new Label();
            PictureViewer = new PictureBox();
            panel1 = new Panel();
            FileFormatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureViewer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ImageCountBox
            // 
            ImageCountBox.Anchor = AnchorStyles.Bottom;
            ImageCountBox.Location = new Point(-3, 350);
            ImageCountBox.Name = "ImageCountBox";
            ImageCountBox.Size = new Size(670, 15);
            ImageCountBox.TabIndex = 33;
            ImageCountBox.Text = "IMAGE_COUNT";
            ImageCountBox.TextAlign = ContentAlignment.TopCenter;
            // 
            // FileNameBox
            // 
            FileNameBox.Anchor = AnchorStyles.Bottom;
            FileNameBox.Location = new Point(-3, 364);
            FileNameBox.Name = "FileNameBox";
            FileNameBox.Size = new Size(670, 15);
            FileNameBox.TabIndex = 32;
            FileNameBox.Text = "FILE_NAME";
            FileNameBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitTagButton
            // 
            SubmitTagButton.Anchor = AnchorStyles.Bottom;
            SubmitTagButton.Location = new Point(448, 325);
            SubmitTagButton.Name = "SubmitTagButton";
            SubmitTagButton.Size = new Size(82, 22);
            SubmitTagButton.TabIndex = 31;
            SubmitTagButton.Text = "Next";
            SubmitTagButton.UseVisualStyleBackColor = true;
            SubmitTagButton.Click += SubmitTagButton_Click;
            // 
            // TagEntryBox
            // 
            TagEntryBox.Anchor = AnchorStyles.Bottom;
            TagEntryBox.Location = new Point(133, 324);
            TagEntryBox.Name = "TagEntryBox";
            TagEntryBox.Size = new Size(309, 23);
            TagEntryBox.TabIndex = 30;
            // 
            // CreditsBox
            // 
            CreditsBox.AutoSize = true;
            CreditsBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreditsBox.Location = new Point(409, 34);
            CreditsBox.Name = "CreditsBox";
            CreditsBox.Size = new Size(214, 38);
            CreditsBox.TabIndex = 28;
            CreditsBox.Text = "© 2020-2023 Robert Sammataro\r\nFree for home use";
            CreditsBox.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExitBox
            // 
            ExitBox.Location = new Point(453, 336);
            ExitBox.Name = "ExitBox";
            ExitBox.Size = new Size(82, 22);
            ExitBox.TabIndex = 27;
            ExitBox.Text = "Exit";
            ExitBox.UseVisualStyleBackColor = true;
            ExitBox.Click += ExitBox_Click;
            // 
            // RunBox
            // 
            RunBox.Location = new Point(547, 336);
            RunBox.Name = "RunBox";
            RunBox.Size = new Size(82, 22);
            RunBox.TabIndex = 26;
            RunBox.Text = "Run";
            RunBox.UseVisualStyleBackColor = true;
            RunBox.Click += RunBox_Click;
            // 
            // DeleteOriginalBox
            // 
            DeleteOriginalBox.AutoSize = true;
            DeleteOriginalBox.Location = new Point(36, 336);
            DeleteOriginalBox.Name = "DeleteOriginalBox";
            DeleteOriginalBox.Size = new Size(145, 19);
            DeleteOriginalBox.TabIndex = 25;
            DeleteOriginalBox.Text = "Delete Original Images";
            DeleteOriginalBox.UseVisualStyleBackColor = true;
            // 
            // FileFormatBox
            // 
            FileFormatBox.Controls.Add(aviButton);
            FileFormatBox.Controls.Add(webmButton);
            FileFormatBox.Controls.Add(mp4Button);
            FileFormatBox.Controls.Add(jpgButton);
            FileFormatBox.Controls.Add(gifButton);
            FileFormatBox.Controls.Add(bmpButton);
            FileFormatBox.Controls.Add(jpegButton);
            FileFormatBox.Controls.Add(pngButton);
            FileFormatBox.Location = new Point(36, 241);
            FileFormatBox.Name = "FileFormatBox";
            FileFormatBox.Size = new Size(593, 60);
            FileFormatBox.TabIndex = 24;
            FileFormatBox.TabStop = false;
            FileFormatBox.Text = "Included File Formats";
            // 
            // aviButton
            // 
            aviButton.AutoSize = true;
            aviButton.Location = new Point(526, 25);
            aviButton.Name = "aviButton";
            aviButton.Size = new Size(44, 19);
            aviButton.TabIndex = 15;
            aviButton.Text = ".avi";
            aviButton.UseVisualStyleBackColor = true;
            // 
            // webmButton
            // 
            webmButton.AutoSize = true;
            webmButton.Location = new Point(447, 25);
            webmButton.Name = "webmButton";
            webmButton.Size = new Size(62, 19);
            webmButton.TabIndex = 14;
            webmButton.Text = ".webm";
            webmButton.UseVisualStyleBackColor = true;
            // 
            // mp4Button
            // 
            mp4Button.AutoSize = true;
            mp4Button.Location = new Point(374, 25);
            mp4Button.Name = "mp4Button";
            mp4Button.Size = new Size(53, 19);
            mp4Button.TabIndex = 13;
            mp4Button.Text = ".mp4";
            mp4Button.UseVisualStyleBackColor = true;
            // 
            // jpgButton
            // 
            jpgButton.AutoSize = true;
            jpgButton.Location = new Point(89, 25);
            jpgButton.Name = "jpgButton";
            jpgButton.Size = new Size(46, 19);
            jpgButton.TabIndex = 9;
            jpgButton.Text = ".jpg";
            jpgButton.UseVisualStyleBackColor = true;
            // 
            // gifButton
            // 
            gifButton.AutoSize = true;
            gifButton.Location = new Point(233, 25);
            gifButton.Name = "gifButton";
            gifButton.Size = new Size(43, 19);
            gifButton.TabIndex = 11;
            gifButton.Text = ".gif";
            gifButton.UseVisualStyleBackColor = true;
            // 
            // bmpButton
            // 
            bmpButton.AutoSize = true;
            bmpButton.Location = new Point(302, 25);
            bmpButton.Name = "bmpButton";
            bmpButton.Size = new Size(54, 19);
            bmpButton.TabIndex = 12;
            bmpButton.Text = ".bmp";
            bmpButton.UseVisualStyleBackColor = true;
            // 
            // jpegButton
            // 
            jpegButton.AutoSize = true;
            jpegButton.Location = new Point(159, 25);
            jpegButton.Name = "jpegButton";
            jpegButton.Size = new Size(52, 19);
            jpegButton.TabIndex = 10;
            jpegButton.Text = ".jpeg";
            jpegButton.UseVisualStyleBackColor = true;
            // 
            // pngButton
            // 
            pngButton.AutoSize = true;
            pngButton.Location = new Point(15, 25);
            pngButton.Name = "pngButton";
            pngButton.Size = new Size(50, 19);
            pngButton.TabIndex = 8;
            pngButton.Text = ".png";
            pngButton.UseVisualStyleBackColor = true;
            // 
            // OutputPathLabel
            // 
            OutputPathLabel.AutoSize = true;
            OutputPathLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            OutputPathLabel.Location = new Point(36, 184);
            OutputPathLabel.Name = "OutputPathLabel";
            OutputPathLabel.Size = new Size(163, 17);
            OutputPathLabel.TabIndex = 23;
            OutputPathLabel.Text = "Output Directory Location";
            // 
            // OutputPathButton
            // 
            OutputPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OutputPathButton.Location = new Point(547, 202);
            OutputPathButton.Name = "OutputPathButton";
            OutputPathButton.Size = new Size(82, 23);
            OutputPathButton.TabIndex = 22;
            OutputPathButton.Text = "Browse";
            OutputPathButton.UseVisualStyleBackColor = true;
            OutputPathButton.Click += OutputPathButton_Click;
            // 
            // OutputPathBox
            // 
            OutputPathBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OutputPathBox.Location = new Point(36, 202);
            OutputPathBox.Name = "OutputPathBox";
            OutputPathBox.Size = new Size(505, 23);
            OutputPathBox.TabIndex = 21;
            // 
            // InputPathLabel
            // 
            InputPathLabel.AutoSize = true;
            InputPathLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            InputPathLabel.Location = new Point(36, 121);
            InputPathLabel.Name = "InputPathLabel";
            InputPathLabel.Size = new Size(153, 17);
            InputPathLabel.TabIndex = 20;
            InputPathLabel.Text = "Input Directory Location";
            // 
            // InputPathButton
            // 
            InputPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InputPathButton.Location = new Point(547, 140);
            InputPathButton.Name = "InputPathButton";
            InputPathButton.Size = new Size(82, 23);
            InputPathButton.TabIndex = 19;
            InputPathButton.Text = "Browse";
            InputPathButton.UseVisualStyleBackColor = true;
            InputPathButton.Click += InputPathButton_Click;
            // 
            // InputPathBox
            // 
            InputPathBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InputPathBox.Location = new Point(36, 140);
            InputPathBox.Name = "InputPathBox";
            InputPathBox.Size = new Size(505, 23);
            InputPathBox.TabIndex = 18;
            // 
            // LogoBox
            // 
            LogoBox.Image = (Image)resources.GetObject("LogoBox.Image");
            LogoBox.Location = new Point(36, 23);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(228, 63);
            LogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoBox.TabIndex = 17;
            LogoBox.TabStop = false;
            // 
            // VersionBox
            // 
            VersionBox.AutoSize = true;
            VersionBox.Location = new Point(7, 360);
            VersionBox.Name = "VersionBox";
            VersionBox.Size = new Size(72, 15);
            VersionBox.TabIndex = 34;
            VersionBox.Text = "Version 1.1.5";
            VersionBox.Click += VersionBox_Click;
            // 
            // PictureViewer
            // 
            PictureViewer.Dock = DockStyle.Fill;
            PictureViewer.Location = new Point(0, 0);
            PictureViewer.Margin = new Padding(0);
            PictureViewer.Name = "PictureViewer";
            PictureViewer.Size = new Size(664, 381);
            PictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
            PictureViewer.TabIndex = 29;
            PictureViewer.TabStop = false;
            PictureViewer.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(PictureViewer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 381);
            panel1.TabIndex = 35;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 381);
            Controls.Add(VersionBox);
            Controls.Add(CreditsBox);
            Controls.Add(ExitBox);
            Controls.Add(RunBox);
            Controls.Add(DeleteOriginalBox);
            Controls.Add(FileFormatBox);
            Controls.Add(OutputPathLabel);
            Controls.Add(OutputPathButton);
            Controls.Add(OutputPathBox);
            Controls.Add(InputPathLabel);
            Controls.Add(InputPathButton);
            Controls.Add(InputPathBox);
            Controls.Add(LogoBox);
            Controls.Add(SubmitTagButton);
            Controls.Add(TagEntryBox);
            Controls.Add(ImageCountBox);
            Controls.Add(FileNameBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "IMGSort";
            FileFormatBox.ResumeLayout(false);
            FileFormatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureViewer).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ImageCountBox;
        private Label FileNameBox;
        private Button SubmitTagButton;
        private TextBox TagEntryBox;
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
        private PictureBox PictureViewer;
        private Panel panel1;
    }
}