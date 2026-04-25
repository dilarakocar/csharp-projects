namespace Kitap_Satis
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
            listKitaplar = new ListBox();
            listSepet = new ListBox();
            menuStrip1 = new MenuStrip();
            kATEGORİLERToolStripMenuItem = new ToolStripMenuItem();
            hAKKIMIZDAToolStripMenuItem = new ToolStripMenuItem();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            mnuRoman = new ToolStripMenuItem();
            mnuTarih = new ToolStripMenuItem();
            mnuHakkimizda = new ToolStripMenuItem();
            mnuCikis = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listKitaplar
            // 
            listKitaplar.FormattingEnabled = true;
            listKitaplar.ItemHeight = 15;
            listKitaplar.Location = new Point(18, 53);
            listKitaplar.Name = "listKitaplar";
            listKitaplar.Size = new Size(255, 124);
            listKitaplar.TabIndex = 0;
            // 
            // listSepet
            // 
            listSepet.FormattingEnabled = true;
            listSepet.ItemHeight = 15;
            listSepet.Location = new Point(305, 53);
            listSepet.Name = "listSepet";
            listSepet.Size = new Size(251, 124);
            listSepet.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kATEGORİLERToolStripMenuItem, hAKKIMIZDAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // kATEGORİLERToolStripMenuItem
            // 
            kATEGORİLERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRoman, mnuTarih });
            kATEGORİLERToolStripMenuItem.Name = "kATEGORİLERToolStripMenuItem";
            kATEGORİLERToolStripMenuItem.Size = new Size(91, 20);
            kATEGORİLERToolStripMenuItem.Text = "KATEGORİLER";
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            hAKKIMIZDAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuHakkimizda, mnuCikis });
            hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            hAKKIMIZDAToolStripMenuItem.Size = new Size(68, 20);
            hAKKIMIZDAToolStripMenuItem.Text = "AYARLAR";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(87, 200);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 202);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Adet:";
            // 
            // button1
            // 
            button1.Location = new Point(18, 241);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 5;
            button1.Text = "Kitap Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(163, 241);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 6;
            button2.Text = "Kitap Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(393, 202);
            button3.Name = "button3";
            button3.Size = new Size(71, 23);
            button3.TabIndex = 7;
            button3.Text = "Ödeme";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 287);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 8;
            label2.Text = "Toplam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 287);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(322, 241);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(223, 23);
            progressBar1.TabIndex = 10;
            // 
            // mnuRoman
            // 
            mnuRoman.Name = "mnuRoman";
            mnuRoman.Size = new Size(180, 22);
            mnuRoman.Text = "Roman";
            // 
            // mnuTarih
            // 
            mnuTarih.Name = "mnuTarih";
            mnuTarih.Size = new Size(180, 22);
            mnuTarih.Text = "Tarih";
            // 
            // mnuHakkimizda
            // 
            mnuHakkimizda.Name = "mnuHakkimizda";
            mnuHakkimizda.Size = new Size(180, 22);
            mnuHakkimizda.Text = "Hakkımızda";
            // 
            // mnuCikis
            // 
            mnuCikis.Name = "mnuCikis";
            mnuCikis.Size = new Size(180, 22);
            mnuCikis.Text = "Çıkış";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(listSepet);
            Controls.Add(listKitaplar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listKitaplar;
        private ListBox listSepet;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kATEGORİLERToolStripMenuItem;
        private ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private ToolStripMenuItem mnuRoman;
        private ToolStripMenuItem mnuTarih;
        private ToolStripMenuItem mnuHakkimizda;
        private ToolStripMenuItem mnuCikis;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
    }
}
