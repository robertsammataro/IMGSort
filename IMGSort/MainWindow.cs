using Newtonsoft.Json;

namespace IMGSort
{
    public partial class MainWindow : Form
    {

        //This needs to be available to all the functions in the Form1 class.
        private Stack<String> file_stack = new Stack<String>();
        private int total_size;
        private int current_count = 1;


        public MainWindow()
        {
            InitializeComponent();

            PictureViewer.Visible = false;
            TagEntryBox.Visible = false;
            SubmitTagButton.Visible = false;
            FileNameBox.Visible = false;
            ImageCountBox.Visible = false;

        }

        ////////////////////////////
        // Main Window Components //
        ////////////////////////////

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            InputPathBox.Text = browser.SelectedPath;
        }

        private void OutputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            OutputPathBox.Text = browser.SelectedPath;
        }

        private void RunBox_Click(object sender, EventArgs e)
        {

            //Check to see if the folders in the input/output lines are folders or not
            if (!Directory.Exists(InputPathBox.Text) || !Directory.Exists(OutputPathBox.Text))
            {
                MessageBox.Show("The specified input or output directory is not correct. Check your file paths and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!pngButton.Checked && !jpgButton.Checked && !jpegButton.Checked && !gifButton.Checked && !bmpButton.Checked && !mp4Button.Checked && !webmButton.Checked && !aviButton.Checked)
            {
                MessageBox.Show("Please select at least one file type to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DeleteOriginalBox.Checked)
            {
                MessageBox.Show("You have selected to delete original pictures. Pictures in this session will be copied and the original file will be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string[] file_array = Directory.GetFiles(InputPathBox.Text);

            foreach (string file in file_array)
            {
                //Populate the stack with only the file paths necessary for the selected
                //filetypes. 

                string lower_file = file.ToLower();

                if (lower_file.EndsWith(".png") && pngButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".jpg") && jpgButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".jpeg") && jpegButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".gif") && gifButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".bmp") && bmpButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".mp4") && mp4Button.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".webm") && webmButton.Checked) { file_stack.Push(file); }
                else if (lower_file.EndsWith(".avi") && aviButton.Checked) { file_stack.Push(file); }

            }

            if (file_stack.Count() == 0)
            {
                MessageBox.Show("There are no images in the selected input folder that meet your criteria. Please try again.");
                return;
            }

            ClearDisplay();

            PictureViewer.Visible = true;
            TagEntryBox.Visible = true;
            SubmitTagButton.Visible = true;
            FileNameBox.Visible = true;
            ImageCountBox.Visible = true;
            total_size = file_stack.Count();

            UpdatePictureViewer();

        }

        ////////////////////////////
        // Sort Window Components //
        ////////////////////////////


        private void UpdatePictureViewer()
        {


            if (file_stack.Count() == 0)
            {
                MessageBox.Show("All items have been sorted.");
                Application.Exit();
                return;
            }

            if (File.Exists(OutputPathBox.Text + "\\__THUMB__.jpg"))
                File.Delete(OutputPathBox.Text + "\\__THUMB__.jpg");


            string filename = file_stack.Peek();

            if (PictureViewer.Image != null)
            {
                PictureViewer.Image.Dispose();
            }

            if (filename.EndsWith(".mp4") || filename.EndsWith(".webm") || filename.EndsWith(".avi"))
            {

                if (File.Exists(OutputPathBox.Text + "\\__THUMB__.jpg"))
                    File.Delete(OutputPathBox.Text + "\\__THUMB__.jpg");

                GenerateThumbnail(filename, OutputPathBox.Text);
                PictureViewer.Image = Image.FromFile(OutputPathBox.Text + "\\__THUMB__.jpg");
            }
            else
                PictureViewer.Image = Image.FromFile(filename);
            PictureViewer.Visible = true;
            FileNameBox.Text = filename;
            ImageCountBox.Text = (current_count + " / " + total_size);
            current_count++;

        }


        private void ClearDisplay()
        {
            VersionBox.Visible = false;
            LogoBox.Visible = false;
            CreditsBox.Visible = false;
            InputPathLabel.Visible = false;
            InputPathBox.Visible = false;
            InputPathButton.Visible = false;
            OutputPathLabel.Visible = false;
            OutputPathBox.Visible = false;
            OutputPathButton.Visible = false;
            FileFormatBox.Visible = false;
            DeleteOriginalBox.Visible = false;
            ExitBox.Visible = false;
            RunBox.Visible = false;
        }

        private string GetFileExtension(string input)
        {
            if (input.ToLower().EndsWith(".png"))
                return (".png");

            else if (input.ToLower().EndsWith(".jpg"))
                return (".jpg");

            else if (input.ToLower().EndsWith(".jpeg"))
                return (".jpeg");

            else if (input.ToLower().EndsWith(".gif"))
                return (".gif");

            else if (input.ToLower().EndsWith(".bmp"))
                return (".bmp");

            else if (input.ToLower().EndsWith(".mp4"))
                return (".mp4");

            else if (input.ToLower().EndsWith(".webm"))
                return (".webm");

            else if (input.ToLower().EndsWith(".avi"))
                return (".avi");

            else
                return ("");
        }

        private void SubmitTagButton_Click(object sender, EventArgs e)
        {
            ApplyTags(file_stack.Peek());
            file_stack.Pop();
            UpdatePictureViewer();
            TagEntryBox.Focus();

        }

        private string DateTimeString()
        {
            System.DateTime now = System.DateTime.Now;
            return (Convert.ToString(now.Year) + Convert.ToString(now.Month) + Convert.ToString(now.Day) + Convert.ToString(now.Hour) + Convert.ToString(now.Minute) + Convert.ToString(now.Second) + Convert.ToString(now.Millisecond));
        }

        //Take in an input string with every tag and return a List with each unique tag
        private List<string> GetUniqueTags(string user_input)
        {
            //Generate a Dictionary with string keys and string[] values that correspond with the different
            //shortcuts defined in supertag.json
            string jsonData = File.ReadAllText("supertag.json");
            Dictionary<string, string[]> supertagDict = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(jsonData);

            //This forces all tags to be used in all lower_case, so if a user put in Test_Folder as a tag,
            //the file would be sent to .../test_folder/... rather than .../Test_Folder/...
            user_input = user_input.ToLower();
            string[] tag_array = user_input.Split(',');
            List<string> untrimmed_tags = new List<string>();
            List<string> tag_list = new List<string>();



            foreach (string tag in tag_array)
            {
                untrimmed_tags.Add(tag);

                if (supertagDict.ContainsKey(tag))
                {
                    foreach (string item in supertagDict[tag])
                    {
                        untrimmed_tags.Add(item);
                    }
                }

            }

            foreach (string tag in untrimmed_tags)
            {
                string trimmed_tag = tag.Trim();

                //Remove characters that cannot be in folder names
                trimmed_tag = trimmed_tag.Replace('#', '_');
                trimmed_tag = trimmed_tag.Replace('%', '_');
                trimmed_tag = trimmed_tag.Replace('&', '_');
                trimmed_tag = trimmed_tag.Replace('{', '_');
                trimmed_tag = trimmed_tag.Replace('}', '_');
                trimmed_tag = trimmed_tag.Replace('<', '_');
                trimmed_tag = trimmed_tag.Replace('>', '_');
                trimmed_tag = trimmed_tag.Replace('*', '_');
                trimmed_tag = trimmed_tag.Replace('?', '_');
                trimmed_tag = trimmed_tag.Replace('$', '_');
                trimmed_tag = trimmed_tag.Replace('+', '_');
                trimmed_tag = trimmed_tag.Replace('!', '_');
                trimmed_tag = trimmed_tag.Replace('`', '_');
                trimmed_tag = trimmed_tag.Replace('\'', '_');
                trimmed_tag = trimmed_tag.Replace('|', '_');
                trimmed_tag = trimmed_tag.Replace('"', '_');
                trimmed_tag = trimmed_tag.Replace('=', '_');
                trimmed_tag = trimmed_tag.Replace(':', '_');
                trimmed_tag = trimmed_tag.Replace('@', '_');

                //Add tag if not already in the List
                if (tag_list.Contains(trimmed_tag) == false)
                {
                    tag_list.Add(trimmed_tag);
                }
            }

            return tag_list;
        }

        private void ApplyTags(string filepath)
        {

            string file_extension = GetFileExtension(filepath);
            string out_file_name = (DateTimeString() + file_extension);
            List<string> tags = GetUniqueTags(TagEntryBox.Text);

            foreach (string tag in tags)
            {
                string full_out_path = OutputPathBox.Text + "\\" + tag + "\\" + out_file_name;
                if (!Directory.Exists(OutputPathBox.Text + "\\" + tag + "\\")) { Directory.CreateDirectory(OutputPathBox.Text + "\\" + tag + "\\"); }
                File.Copy(filepath, full_out_path);

            }

            PictureViewer.Visible = false;
            PictureViewer.Image.Dispose();

            if (DeleteOriginalBox.Checked) { File.Delete(filepath); }
            TagEntryBox.Text = "";
        }

        private void GenerateThumbnail(string input_file_path, string output_directory)
        {
            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\ffmpeg\\bin\\ffmpeg.exe";
                p.StartInfo.Arguments = "-i \"" + input_file_path + "\" -ss 00:00:01.000 -vframes 1 \"" + output_directory + "\\__THUMB__.jpg\"";
                p.Start();
                p.WaitForExit(); //Wait for ffmpeg to finish before continuing
            }
        }

        private void VersionBox_Click(object sender, EventArgs e)
        {

        }
    }
}