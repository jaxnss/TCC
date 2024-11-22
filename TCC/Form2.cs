namespace TCC
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Database=bancodedadosnovo;Integrated Security=True;";

        // Dicionário para os tipos de Pão (ComboBox1)
        private Dictionary<string, string> paoPrecos = new Dictionary<string, string>
{
    { "Pão Crocante", "25.00" },
    { "Pão Tradicional", "20.00" }
};

        // Dicionário para Sobremesas (ComboBox2)
        private Dictionary<string, string> sobremesaPrecos = new Dictionary<string, string>
{
    { "baunilha sunday morango", "10.00" },
    { "baunilha sunday oreo", "10.00" },
    { "baunilha sunday caramelo", "10.00" },
    { "choco sunday oreo", "10.00" }
};

        // Dicionário para Molhos (ComboBox3)
        private Dictionary<string, string> molhoPrecos = new Dictionary<string, string>
{
    { "ketchup", "2.00" },
    { "barbecue", "2.00" },
    { "mayo", "2.00" },
    { "molho da casa", "2.00" },
    { "honey mustard", "2.00" }
};

        // Dicionário para Bebidas (ComboBox4)
        private Dictionary<string, string> bebidaPrecos = new Dictionary<string, string>
{
    { "soda italiana frutas vermelhas", "25.00" },
    { "coca cola", "25.00" },
    { "água", "25.00" },
    { "soda italiana maçã verde", "25.00" },
    { "pink lemonade", "25.00" }
};

        // Dicionário para Batatas e Nuggets (ComboBox5)
        private Dictionary<string, string> batataPrecos = new Dictionary<string, string>
{
    { "batata normal", "10.00" },
    { "batata waffle", "10.00" },
    { "batata cheddar e bacon", "10.00" },
    { "nuggets", "10.00" }
};

        // Dicionário para Carnes (ComboBox6)
        private Dictionary<string, string> carnePrecos = new Dictionary<string, string>
{
    { "Carne", "15.00" },
    { "Frango", "13.00" },
    { "Carne Vegetariana", "16.00" }
};




        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 bebida = new Form3();
            bebida.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 sanduiche = new Form7();
            sanduiche.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 molho = new Form6();
            molho.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 acompanhamento = new Form4();
            acompanhamento.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Item> itensPedido = new List<Item>();

            if (comboBox1.SelectedItem != null)
            {
                string paoSelecionado = comboBox1.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = paoSelecionado,
                    Preco = paoPrecos[paoSelecionado],
                    Quantidade = 1
                });
            }

            // Sobremesa
            if (comboBox2.SelectedItem != null)
            {
                string sobremesaSelecionada = comboBox2.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = sobremesaSelecionada,
                    Preco = sobremesaPrecos[sobremesaSelecionada],
                    Quantidade = 1
                });
            }

            // Molho
            if (comboBox3.SelectedItem != null)
            {
                string molhoSelecionado = comboBox3.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = molhoSelecionado,
                    Preco = molhoPrecos[molhoSelecionado],
                    Quantidade = 1
                });
            }

            // Bebida
            if (comboBox4.SelectedItem != null)
            {
                string bebidaSelecionada = comboBox4.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = bebidaSelecionada,
                    Preco = bebidaPrecos[bebidaSelecionada],
                    Quantidade = 1
                });
            }

            // Batata
            if (comboBox5.SelectedItem != null)
            {
                string batataSelecionada = comboBox5.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = batataSelecionada,
                    Preco = batataPrecos[batataSelecionada],
                    Quantidade = 1
                });
            }

            // Carne
            if (comboBox6.SelectedItem != null)
            {
                string carneSelecionada = comboBox6.SelectedItem.ToString();
                itensPedido.Add(new Item
                {
                    Nome = carneSelecionada,
                    Preco = carnePrecos[carneSelecionada],
                    Quantidade = 1
                });
            }
            Form11 finalizar = new Form11(itensPedido);
            finalizar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Adicionando as opções ao ComboBox
            comboBox1.Items.Add("Pão Crocante");
            comboBox1.Items.Add("Pão Tradicional");


            // Definindo o item selecionado (opcional)
            comboBox1.SelectedIndex = 0; // Definindo o primeiro item como padrão

            // Adicionando as opções ao ComboBox
            comboBox2.Items.Add("baunilha sunday morango");
            comboBox2.Items.Add("baunilha sunday oreo");
            comboBox2.Items.Add("baunilha sunday caramelo");
            comboBox2.Items.Add("choco sunday oreo");


            // Definindo o item selecionado (opcional)
            comboBox2.SelectedIndex = 0; // Definindo o primeiro item como padrão

            // Adicionando as opções ao ComboBox
            comboBox3.Items.Add("ketchup");
            comboBox3.Items.Add("barbecue");
            comboBox3.Items.Add("mayo");
            comboBox3.Items.Add("molho da casa");
            comboBox3.Items.Add("honey mustard");

            // Definindo o item selecionado (opcional)
            comboBox3.SelectedIndex = 0; // Definindo o primeiro item como padrão

            // Adicionando as opções ao ComboBox
            comboBox4.Items.Add("soda italiana frutas vermelhas");
            comboBox4.Items.Add("coca cola");
            comboBox4.Items.Add("água");
            comboBox4.Items.Add("soda italiana maçã verde");
            comboBox4.Items.Add("pink lemodade");

            // Definindo o item selecionado (opcional)
            comboBox4.SelectedIndex = 0; // Definindo o primeiro item como padrão

            // Adicionando as opções ao ComboBox
            comboBox5.Items.Add("batata normal");
            comboBox5.Items.Add("batata waffle");
            comboBox5.Items.Add("batata cheddar e bacon");
            comboBox5.Items.Add("nuggets");
            // Definindo o item selecionado (opcional)
            comboBox5.SelectedIndex = 0; // Definindo o primeiro item como padrão

            // Adicionando as opções ao ComboBox
            comboBox6.Items.Add("Carne");
            comboBox6.Items.Add("Frango");
            comboBox6.Items.Add("Carne Vegetariana");

            // Definindo o item selecionado (opcional)
            comboBox6.SelectedIndex = 0; // Definindo o primeiro item como padrão

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(dynamic sender, EventArgs e)
        {


        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






