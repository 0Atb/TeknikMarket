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
    public class UrunResimBs:IUrunResimBS
    {
        private IUrunResimRepository repo;
        public UrunResimBs(IUrunResimRepository _repo)
        {
            repo = _repo;
        }
        public UrunResim Delete(UrunResim entity)
        {
            return repo.Delete(entity);
        }

        public UrunResim Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public UrunResim Get(Expression<Func<UrunResim, bool>> fUrunResimter, params string[] includelist)
        {
            return repo.Get(fUrunResimter, includelist);
        }

        public List<UrunResim> GetAll(Expression<Func<UrunResim, bool>> fUrunResimter, params string[] includelist)
        {
            return repo.GetAll(fUrunResimter, includelist);
        }

        public UrunResim GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public UrunResim Insert(UrunResim entity)
        {
            return repo.Insert(entity);
        }

        public UrunResim Update(UrunResim entity)
        {
            return repo.Update(entity);
        }
    }
}
