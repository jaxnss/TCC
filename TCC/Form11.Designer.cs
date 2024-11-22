namespace TCC
{
    partial class Form11
    {
        private DataGridView dataGridViewCarrinho;
        private Label lblTotal;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            dataGridViewCarrinho = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarrinho.BackgroundColor = Color.NavajoWhite;
            dataGridViewCarrinho.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 204, 153);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarrinho.ColumnHeadersHeight = 40;
            dataGridViewCarrinho.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCarrinho.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCarrinho.GridColor = Color.Black;
            dataGridViewCarrinho.Location = new Point(-4, -4);
            dataGridViewCarrinho.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.RowHeadersWidth = 51;
            dataGridViewCarrinho.RowTemplate.Height = 35;
            dataGridViewCarrinho.Size = new Size(881, 339);
            dataGridViewCarrinho.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "QNT";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "CARRINHO";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "PREÇO";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.NavajoWhite;
            lblTotal.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(649, 339);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(229, 40);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: R$ 0.00";
            lblTotal.Click += lblTotal_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(262, 63);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(612, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 69);
            panel1.TabIndex = 3;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 451);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(lblTotal);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button1;
        private Panel panel1;
    }
}
