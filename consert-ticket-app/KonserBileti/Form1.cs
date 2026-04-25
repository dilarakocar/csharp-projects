using System.Reflection.Metadata.Ecma335;

namespace KonserBileti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string telefon = maskedTextBox1.Text;
            int adet = Convert.ToInt32(textBox3.Text);

            string tarih = "";

            switch (comboBox1.Text)
            {
                case "Tarkan":
                    tarih = "12.05.2026";
                    break;
                case "Sezen Aksu":
                    tarih = "18.05.2026";
                    break;
                case "Teoman":
                    tarih = "25.05.2026";
                    break;
                default:
                    MessageBox.Show("Geçersiz sanatçý seçimi!");
                    return;
            }

            comboBox2.Text = tarih;

            int fiyat = 0;

            if (radioButton1.Checked)
                fiyat = 750;
            else if (radioButton2.Checked)
                fiyat = 1250;
            else

            {
                MessageBox.Show("Lütfen bilet türünü seçiniz!");
                return;
            }
            int toplam = fiyat * adet;


            listBox1.Items.Add( "Ad: "+ ad);
            listBox1.Items.Add("Soyad: " + soyad);
            listBox1.Items.Add("Telefon: " + telefon);
            listBox1.Items.Add("Sanatçý: " + comboBox1.Text);
            listBox1.Items.Add("Tarih: " + tarih);
            listBox1.Items.Add("Adet: " + adet);
            listBox1.Items.Add("Tür : " + (radioButton1.Checked ? "Öðrenci" : "Tam"));
            listBox1.Items.Add("Toplam: " + toplam + "TL");



        }
    }
}
