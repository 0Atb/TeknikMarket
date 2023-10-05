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
    public class KategoriBs:IKategoriBS
    {
        private IKategoriRepository repo;
        public KategoriBs(IKategoriRepository _repo)
        {
            repo = _repo;
        }
        public Kategori Delete(Kategori entity)
        {
            return repo.Delete(entity);
        }

        public Kategori Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Kategori Get(Expression<Func<Kategori, bool>> fKategoriter, params string[] includelist)
        {
            return repo.Get(fKategoriter, includelist);
        }

        public List<Kategori> GetAll(Expression<Func<Kategori, bool>> fKategoriter, params string[] includelist)
        {
            return repo.GetAll(fKategoriter, includelist);
        }

        public Kategori GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public Kategori Insert(Kategori entity)
        {
            return repo.Insert(entity);
        }

        public Kategori Update(Kategori entity)
        {
            return repo.Update(entity);
        }
    }
}
