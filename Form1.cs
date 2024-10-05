using System.Text.RegularExpressions;

namespace BinaryToBarrelConverter
{
    public partial class Form1 : Form
    {
        private readonly Logic _logic = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logic.textBox = textBox1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                List<string> text = new List<string>();

                // Replacing all Whitespace Characters with nothing and Replace Line Endings
                string[] temp = textBox1.Text.ReplaceLineEndings().Split(Environment.NewLine);

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] != "") text.Add(Regex.Replace(temp[i], @"[ \t]", ""));
                }

                _logic.RunConversion(text);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            _logic.Direction = comboBox1.Text.First();
            textBox1.Text = comboBox1.Text;
        }
    }
}
