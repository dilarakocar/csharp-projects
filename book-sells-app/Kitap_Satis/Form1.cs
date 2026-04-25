using Kitapci_Satis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kitap_Satis
{
    public partial class Form1 : Form
    {
        List<Kitap> kitaplar = new List<Kitap>();
        List<SatisKalemi> sepet = new List<SatisKalemi>();

        string aktifKategori = "Roman";

        public Form1()
        {
            InitializeComponent();

            nudAdet.Minimum = 1;

            KitaplariDoldur();
            Listele();
            SepetiYaz();
        }

        void KitaplariDoldur()
        {
            Kitap k1 = new Kitap();
            k1.Id = 1;
            k1.Ad = "Kürk Mantolu Madonna";
            k1.Kategori = "Roman";
            k1.Fiyat = 120;

            Kitap k2 = new Kitap();
            k2.Id = 2;
            k2.Ad = "Tutunamayanlar";
            k2.Kategori = "Roman";
            k2.Fiyat = 220;

            Kitap k3 = new Kitap();
            k3.Id = 3;
            k3.Ad = "Nutuk";
            k3.Kategori = "Tarih";
            k3.Fiyat = 250;

            Kitap k4 = new Kitap();
            k4.Id = 4;
            k4.Ad = "Sapiens";
            k4.Kategori = "Tarih";
            k4.Fiyat = 200;

            kitaplar.Add(k1);
            kitaplar.Add(k2);
            kitaplar.Add(k3);
            kitaplar.Add(k4);
        }

        void Listele()
        {
            lstKitaplar.Items.Clear();

            foreach (Kitap k in kitaplar)
            {
                if (k.Kategori == aktifKategori)
                {
                    lstKitaplar.Items.Add(k.Ad + " | " + k.Fiyat + " TL");
                }
            }
        }

        void SepetiYaz()
        {
            lstSepet.Items.Clear();

            decimal toplam = 0;

            foreach (SatisKalemi s in sepet)
            {
                lstSepet.Items.Add(s.Ad + " x" + s.Adet + " = " + s.Tutar() + " TL");
                toplam = toplam + s.Tutar();
            }

            lblToplam.Text = toplam + " TL";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex == -1)
            {
                MessageBox.Show("Kitap seçiniz");
                return;
            }

            int seciliIndex = lstKitaplar.SelectedIndex;

            Kitap seciliKitap = null;
            int sayac = -1;

            foreach (Kitap k in kitaplar)
            {
                if (k.Kategori == aktifKategori)
                {
                    sayac = sayac + 1;
                    if (sayac == seciliIndex)
                    {
                        seciliKitap = k;
                    }
                }
            }

            if (seciliKitap == null) return;

            SatisKalemi yeni = new SatisKalemi();
            yeni.KitapId = seciliKitap.Id;
            yeni.Ad = seciliKitap.Ad;
            yeni.BirimFiyat = seciliKitap.Fiyat;
            yeni.Adet = Convert.ToInt32(nudAdet.Value);

            sepet.Add(yeni);
            SepetiYaz();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedIndex == -1) return;

            sepet.RemoveAt(lstSepet.SelectedIndex);
            SepetiYaz();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepet boþ");
                return;
            }

            MessageBox.Show("Ödeme alýndý");
            sepet.Clear();
            SepetiYaz();
        }

        private void mnuRoman_Click(object sender, EventArgs e)
        {
            aktifKategori = "Roman";
            Listele();
        }

        private void mnuTarih_Click(object sender, EventArgs e)
        {
            aktifKategori = "Tarih";
            Listele();
        }

        private void mnuHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitapçý Satýþ Uygulamasý");
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
