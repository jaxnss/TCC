namespace TCC
{
    public partial class Form3 : Form
    {
        int currentValue = 0;

        public Form3()
        {
            InitializeComponent();

            button11.Text = "Enter";
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }


        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "Jehad" && textBox2.Text == "Nadia")
            {

                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Nome de usuario ou senha incorreta.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "Jehad";
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        // Set password in textBox2 when text is changed
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = "Nadia";
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
