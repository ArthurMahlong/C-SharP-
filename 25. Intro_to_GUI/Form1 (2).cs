namespace _25._Intro_to_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            label2.Text = "Welcome "+ textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            //MessageBox.Show("Hello and Welcome");
        }
    }
}
