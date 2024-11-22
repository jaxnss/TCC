namespace TCC
{
    public partial class Form11 : Form
    {
        private List<Item> itensPedido;

        // Modifique o construtor para aceitar a lista de itens do pedido
        public Form11(List<Item> itens)
        {
            InitializeComponent();
            itensPedido = itens;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // Adicione os itens ao DataGridView e calcule o total
            decimal total = 0;
            foreach (var item in itensPedido)
            {
                dataGridViewCarrinho.Rows.Add(item.Quantidade, item.Nome, item.Preco);
                total += Convert.ToDecimal(item.Preco);
            }

            // Exibir o total
            lblTotal.Text = $"Total: R$ {total:0.00}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 pagamento = new Form12();
            pagamento.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form12 pagamento = new Form12();
            pagamento.ShowDialog();
            this.Hide();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
