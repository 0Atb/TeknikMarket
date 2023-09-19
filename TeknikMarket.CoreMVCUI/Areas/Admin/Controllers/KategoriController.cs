using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeknikMarket.Business.Abstract;
using TeknikMarket.CoreMVCUI.Areas.Admin.Filter;
using TeknikMarket.Model.Entity;
using TeknikMarket.Model.ViewModel.Areas.Admin.Kategories;

namespace TeknikMarket.CoreMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class KategoriController : Controller
    {
        private readonly IKategoriBS kategoriBS;
        private readonly ISessionManager session;
        private readonly IMapper mapper;

        public KategoriController(IKategoriBS kategoriBS, ISessionManager _session,IMapper _mapper)
        {
            this.kategoriBS = kategoriBS;
            session = _session;
            mapper = _mapper;
        }

        public IActionResult List()
        {
            KategoriListeViewModel model = new KategoriListeViewModel();
            List<Kategori> kategoris = kategoriBS.GetAll().ToList();

            model.KategoriListesi = kategoris;

            model.KategoriSelectList = kategoris.Select(x => new SelectListItem() { Text = x.KategoriAdiGorunumu, Value = x.Id.ToString() }).ToList();

            model.KategoriSelectList.Insert(0, new SelectListItem("Lütfen Üst Kategori Seçiniz", "-1"));

            int sira = 0;
            if (kategoris.Count == 0)
            {
                sira = 1;
            }
            else
            {
                sira = kategoris.OrderByDescending(x => x.Sira).FirstOrDefault().Sira ?? 1;
            }

            model.Sira = sira + 1;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(KategoriListeViewModel model)
        {
            //Kategori kategori = new Kategori();
            //kategori.KategoriAdi = model.KategoriAdi;
            //kategori.Sira = model.Sira;
            //kategori.Aktif = model.Aktif;
            //kategori.UstKategoriId = model.UstKategoriId;

            Kategori kategori = mapper.Map<Kategori>(model);


            if (model.UstKategoriId != -1)
            {
                Kategori ustkategori = kategoriBS.Get(x => x.Id == model.UstKategoriId);

                kategori.KategoriAdiGorunumu = ustkategori.KategoriAdiGorunumu + " > " + model.KategoriAdi;

            }
            else
            {
                //kategori.KategoriAdiGorunumu = null;
                kategori.KategoriAdiGorunumu = model.KategoriAdi;
            }

            kategori.Id = null;
            kategori.Aktif = model.Aktif;
            kategori.Sira = model.Sira;
            kategori.OlusturmaTarihi = DateTime.Now;
            kategori.GuncellemeTarihi = DateTime.Now;
            //kategori.Olusturan = session.AktifKullanici.Id;
            //kategori.Guncelleyen = session.AktifKullanici.Id;

            kategoriBS.Insert(kategori);

            List<Kategori> kategoriler = kategoriBS.GetAll();

            int sira = kategoriler.OrderByDescending(x => x.Sira).FirstOrDefault().Sira ?? 1;

            sira = sira + 1;

            return Json(new {result = true,Mesaj = "Kategori Başarıyla Eklendi", kategoriListesi = kategoriler , sira = sira});
        }

        public IActionResult Delete(int kategoriId)
        {
            Kategori kategori = kategoriBS.Get(x => x.Id == kategoriId);
            kategoriBS.Delete(kategori);

            List<Kategori> kategoriler = kategoriBS.GetAll();

            return Json(new { result = true, mesaj = "Kategori Başarıyla Silindi", kategoriListesi = kategoriler });
        }

    }
}
