namespace TCC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            panel1 = new Panel();
            comboBox6 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(-33, -29);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(308, 149);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(272, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(492, 154);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 8;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(94, 303);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(441, 303);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button5);
            panel1.Location = new Point(223, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 98);
            panel1.TabIndex = 11;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(73, 154);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 12;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(comboBox6);
            Controls.Add(panel1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Panel panel1;
        private ComboBox comboBox6;
    }
}