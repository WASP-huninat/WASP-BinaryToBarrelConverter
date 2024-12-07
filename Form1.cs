using System.Text.RegularExpressions;

namespace WASP.BinaryToBarrelConverter
{
    public partial class Form1 : Form
    {
        private readonly string SettingsFileFullPath = Path.Combine(Path.GetTempPath(), "BinaryToBarrelConverter.json");
        private readonly Logic _logic = new Logic();
        private readonly JsonLogic _jsonLogic = new JsonLogic();
        private Rootobject rootobject = new Rootobject();

        public Form1()
        {
            InitializeComponent();
            _jsonLogic.JsonFullPath = SettingsFileFullPath;
            if (!File.Exists(SettingsFileFullPath))
            {
                rootobject.MinecraftWorldFolderPath = "";
                rootobject.Direction = "North";
                _jsonLogic.SaveJsonFile(rootobject);
            }
            rootobject = _jsonLogic.LoadJsonFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logic.TextBox = textBox1;

            _logic.rootobject = rootobject;

            toolStripTextBox1.Text = rootobject.Pack_format.ToString();
            toolStripMenuItem2.Text = rootobject.MinecraftWorldFolderPath;
            toolStripComboBox1.Text = rootobject.Direction.ToString();
            toolStripTextBox2.Text = rootobject.BytesPerRomAddress.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _jsonLogic.SaveJsonFile(rootobject);
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Length != 0)
            {
                rootobject.Pack_format = int.Parse(toolStripTextBox1.Text);
                _jsonLogic.SaveJsonFile(rootobject);
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            rootobject.MinecraftWorldFolderPath = folderBrowserDialog1.SelectedPath;
            toolStripMenuItem2.Text = folderBrowserDialog1.SelectedPath;
            _jsonLogic.SaveJsonFile(rootobject);
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            rootobject.Direction = toolStripComboBox1.Text;
            _jsonLogic.SaveJsonFile(rootobject);
        }
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text.Length != 0)
            {
                rootobject.BytesPerRomAddress = int.Parse(toolStripTextBox2.Text);
            }
        }

        private void btnStartConverting_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                List<string> text = new List<string>();

                string[] temp = textBox1.Text.ReplaceLineEndings().Split(Environment.NewLine);

                // Replace Space and Tab Characters with nothing
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] != "") text.Add(Regex.Replace(temp[i], @"[ \t]", ""));
                }

                _logic.RunConversion(text);
            }
        }
    }
}
