namespace EceShin.MVC.Models
{
    public class Urun
    {
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public decimal BirimFiyati { get; set; }

        public short HedefStokDuzeyi { get; set; }

        public int? KategoriID { get; set; }
        public int? TedarikciId { get; set; }

        //------------------------------------------,

        public Kategori Kategori { get; set; }
    }
}
