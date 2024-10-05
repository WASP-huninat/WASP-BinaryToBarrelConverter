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

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                string[] text = textBox1.Text.ReplaceLineEndings().Split(Environment.NewLine);

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
