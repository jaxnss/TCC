namespace TCC
{
    public partial class Form13 : Form
    {
        public Form13()

        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 comeco = new Form1();
            comeco.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //show a random 4 digit number//
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 cadastrar = new Form1();
            cadastrar.ShowDialog();
            this.Hide();
        }
    }
}
