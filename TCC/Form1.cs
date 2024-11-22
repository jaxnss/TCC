namespace TCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form2 cadastrar = new Form2();
            cadastrar.ShowDialog();
            this.Hide();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Form2 cadastrar = new Form2();
            cadastrar.ShowDialog();
            this.Hide();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();


            Form3 gerente = new Form3();
            gerente.ShowDialog();


            this.Hide();
            this.Show();
        }

    }
}




