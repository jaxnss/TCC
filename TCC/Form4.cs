namespace TCC
{
    public partial class Form4 : Form
    {
        private List<(DomainUpDown domainUpDown, CheckBox checkBox)> domainUpDownCheckBoxPairs;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Inicializar a lista de pares (DomainUpDown e CheckBox)
            domainUpDownCheckBoxPairs = new List<(DomainUpDown, CheckBox)>
            {
                (domainUpDown1, checkBox1),
                (domainUpDown2, checkBox2),
                // Adicione mais pares conforme necessário
                (domainUpDown3, checkBox3),
                (domainUpDown4, checkBox4)
            };

            // Configuração inicial de todos os DomainUpDown e CheckBox
            foreach (var pair in domainUpDownCheckBoxPairs)
            {
                var domainUpDown = pair.domainUpDown;
                var checkBox = pair.checkBox;

                domainUpDown.Items.AddRange(Enumerable.Range(0, 11).Select(x => x.ToString()).ToArray());
                domainUpDown.SelectedIndex = 0; // Começa em 0
                checkBox.Checked = false;

                // Associa eventos
                domainUpDown.SelectedItemChanged += DomainUpDown_SelectedItemChanged;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
        }

        // Evento acionado quando o valor do DomainUpDown é alterado
        private void DomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            var domainUpDown = sender as DomainUpDown;

            if (domainUpDown != null)
            {
                // Encontra o CheckBox associado ao DomainUpDown
                var associatedCheckBox = domainUpDownCheckBoxPairs
                    .FirstOrDefault(pair => pair.domainUpDown == domainUpDown).checkBox;

                if (associatedCheckBox != null)
                {
                    // Verifica o valor selecionado no DomainUpDown
                    int quantidade = int.Parse(domainUpDown.Text);
                    associatedCheckBox.Checked = quantidade > 0; // Marcar CheckBox se valor maior que 0
                }
            }
        }

        // Evento acionado quando o CheckBox é alterado
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                // Encontra o DomainUpDown associado ao CheckBox
                var associatedDomainUpDown = domainUpDownCheckBoxPairs
                    .FirstOrDefault(pair => pair.checkBox == checkBox).domainUpDown;

                if (associatedDomainUpDown != null && !checkBox.Checked)
                {
                    // Se o CheckBox for desmarcado, ajustar o valor do DomainUpDown para 0
                    associatedDomainUpDown.SelectedIndex = 0;
                }
            }
        }

        private void domainUpDown5_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
