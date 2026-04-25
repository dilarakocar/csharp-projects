namespace KonserBileti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 2);
            label1.Name = "label1";
            label1.Size = new Size(271, 34);
            label1.TabIndex = 0;
            label1.Text = "YILDIZLI AKŞAMLAR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(35, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Konser Bilgileri";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(92, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 30);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tarkan", "Sezen Aksu", "Teoman" });
            comboBox1.Location = new Point(91, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 30);
            comboBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(9, 77);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 1;
            label3.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 0;
            label2.Text = "Sanatçı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(35, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 147);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kişisel Bilgiler";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(91, 100);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 29);
            maskedTextBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(9, 111);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 3;
            label6.Text = "Telefon:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 76);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 2;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(9, 38);
            label4.Name = "label4";
            label4.Size = new Size(29, 17);
            label4.TabIndex = 1;
            label4.Text = "Ad:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(332, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(292, 147);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bilet Bilgileri";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 111);
            label7.Name = "label7";
            label7.Size = new Size(45, 22);
            label7.TabIndex = 6;
            label7.Text = "Adet:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            radioButton2.Location = new Point(6, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 21);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tam";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            radioButton1.Location = new Point(6, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 21);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Öğrenci";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(227, 298);
            button1.Name = "button1";
            button1.Size = new Size(195, 40);
            button1.TabIndex = 4;
            button1.Text = "KAYDET VE GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 362);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(650, 64);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox3;
        private ListBox listBox1;
        private ComboBox comboBox2;
    }
}
