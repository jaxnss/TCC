namespace TCC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button11 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 27);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // button11
            // 
            button11.Location = new Point(12, 281);
            button11.Name = "button11";
            button11.Size = new Size(207, 91);
            button11.TabIndex = 15;
            button11.Text = "Enter";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 484);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button11);
            Name = "Form3";
            Text = "-";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button11;
    }
}