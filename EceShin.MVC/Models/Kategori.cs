using System.Collections.Generic;

namespace EceShin.MVC.Models
{
    public class Kategori
    {

        public Kategori()
        {
            Urunler = new HashSet<Urun>();
        }
        public int KategoriID { get; set; }

        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }

        public ICollection<Urun> Urunler { get; set; }
    }
}

