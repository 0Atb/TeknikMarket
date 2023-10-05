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
    public class SepetBs:ISepetBs
    {
        private ISepetRepository repo;
        public SepetBs(ISepetRepository _repo)
        {
            repo = _repo;
        }
        public Sepet Delete(Sepet entity)
        {
            return repo.Delete(entity);
        }

        public Sepet Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Sepet Get(Expression<Func<Sepet, bool>> fSepetter, params string[] includelist)
        {
            return repo.Get(fSepetter, includelist);
        }

        public List<Sepet> GetAll(Expression<Func<Sepet, bool>> fSepetter, params string[] includelist)
        {
            return repo.GetAll(fSepetter, includelist);
        }

        public Sepet GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public Sepet Insert(Sepet entity)
        {
            return repo.Insert(entity);
        }

        public Sepet Update(Sepet entity)
        {
            return repo.Update(entity);
        }
    }
}
