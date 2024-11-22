namespace TCC
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 finalizar = new Form13();
            finalizar.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 finalizar = new Form13();
            finalizar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 finalizar = new Form13();
            finalizar.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 finalizar = new Form13();
            finalizar.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
