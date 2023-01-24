using System.Collections.Generic;

namespace EceShin.MVC.Models.ViewModels
{
    public class KategoriListesiViewModel
    {
        public List<Kategori> Kategoriler { get; set; }

        public string Mesaj { get; set; }

        public Kategori Kategori { get; set; }
    }
}
