namespace TCC
{
    public partial class Form7 : Form
    {
        string tipo;
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 cadastrar = new Form2();
            cadastrar.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
                var isChecked = ((CheckBox)sender).Checked;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, isChecked);
                }
            terminar*/

            Form8 sanduiche = new Form8(tipo);
            sanduiche.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo = "pão crocante";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = "pão normal";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //tirar tomate da lista na tela 11//
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tirar cebola caramelizada da lista na tela 11//
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //tirar bacon da lista na tela 11//
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //tirar queijo chedar da lista na tela 11//
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //tirar picles da lista na tela 11//
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
