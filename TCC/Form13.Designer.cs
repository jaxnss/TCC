namespace TCC
{
    partial class Form13
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(578, 183);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(578, 175);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(0, -52);
            button1.Name = "button1";
            button1.Size = new Size(208, 159);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(243, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 97);
            panel1.TabIndex = 3;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form13";
            Text = "Form13";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
    }
}