namespace Kitapci_Satis
{
    public class SatisKalemi
    {
        public int KitapId;
        public string Ad;
        public decimal BirimFiyat;
        public int Adet;

        public decimal Tutar()
        {
            return BirimFiyat * Adet;
        }
    }
}
