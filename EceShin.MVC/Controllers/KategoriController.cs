using EceShin.MVC.Models;
using EceShin.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EceShin.MVC.Controllers
{
    public class KategoriController:Controller
    {

        public IActionResult Liste()
        {
            NorthwindDbContext context = new NorthwindDbContext();

            KategoriListesiViewModel model= new KategoriListesiViewModel();

            model.Kategoriler= context.Kategoriler.ToList();
            model.Kategori = new Kategori();
            model.Mesaj = "Northwind Kategori Listesi";
            return View(model);
        }

        public IActionResult UrunListesi(int id)
        {
            NorthwindDbContext context = new NorthwindDbContext();
            UrunListesiViewModel model = new UrunListesiViewModel();

             model.Urunler=context.Urunler.Where(x=> x.KategoriID==id).ToList();
            model.Kategori = context.Kategoriler.Where(x => x.KategoriID == id).SingleOrDefault();
            model.Mesaj = model.Kategori.KategoriAdi + "KATEGORİSİNDEKİ üRÜN lİSTESİ";

            return View(model);
        }


        public IActionResult KategoriEkle(KategoriListesiViewModel model)
        {

            NorthwindDbContext context = new NorthwindDbContext();
            context.Kategoriler.Add(model.Kategori);
            context.SaveChanges();

            return RedirectToAction("Liste","Kategori");
        }
    }
}
