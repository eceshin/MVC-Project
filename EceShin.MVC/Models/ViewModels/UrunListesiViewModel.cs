using System.Collections.Generic;

namespace EceShin.MVC.Models.ViewModels
{
    public class UrunListesiViewModel
    {
        public List<Urun> Urunler { get; set; }
        public Kategori Kategori { get; set; }

        public string Mesaj { get; set; }

    }
}
