namespace FirstGUIApplication
{
    public partial class Sign_Up_Form : Form
    {
        public Sign_Up_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Sign Up Form!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for signing up!");
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
