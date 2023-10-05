using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikMarket.Business.Abstract;
using TeknikMarket.DataAccess.Abstract;
using TeknikMarket.Model.Entity;

namespace TeknikMarket.Business.Concrete
{
    public class UrunFiyatBs:IUrunFiyatBS
    {
        private IUrunFiyatRepository repo;
        public UrunFiyatBs(IUrunFiyatRepository _repo)
        {
            repo = _repo;
        }
        public UrunFiyat Delete(UrunFiyat entity)
        {
            return repo.Delete(entity);
        }

        public UrunFiyat Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public UrunFiyat Get(Expression<Func<UrunFiyat, bool>> fUrunFiyatter, params string[] includelist)
        {
            return repo.Get(fUrunFiyatter, includelist);
        }

        public List<UrunFiyat> GetAll(Expression<Func<UrunFiyat, bool>> fUrunFiyatter, params string[] includelist)
        {
            return repo.GetAll(fUrunFiyatter, includelist);
        }

        public UrunFiyat GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public UrunFiyat Insert(UrunFiyat entity)
        {
            return repo.Insert(entity);
        }

        public UrunFiyat Update(UrunFiyat entity)
        {
            return repo.Update(entity);
        }
    }
}
