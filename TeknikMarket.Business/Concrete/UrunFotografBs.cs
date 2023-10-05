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
    public class UrunFotografBs:IUrunFotografBS
    {
        private IUrunFotografRepository repo;
        public UrunFotografBs(IUrunFotografRepository _repo)
        {
            repo = _repo;
        }
        public UrunFotograf Delete(UrunFotograf entity)
        {
           return repo.Delete(entity);
        }

        public UrunFotograf Delete(int Id)
        {
           return repo.Delete(Id);
        }

        public UrunFotograf Get(Expression<Func<UrunFotograf, bool>> fUrunFotografter, params string[] includelist)
        {
            return repo.Get(fUrunFotografter, includelist);
        }

        public List<UrunFotograf> GetAll(Expression<Func<UrunFotograf, bool>> fUrunFotografter, params string[] includelist)
        {
            return repo.GetAll(fUrunFotografter, includelist);
        }

        public UrunFotograf GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public UrunFotograf Insert(UrunFotograf entity)
        {
           return repo.Insert(entity);
        }

        public UrunFotograf Update(UrunFotograf entity)
        {
           return repo.Update(entity);
        }
    }
}
