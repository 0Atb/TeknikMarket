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
    public class FirmaBS:IFirmaBS
    {
        private readonly IFirmaRepository _repo;

        public FirmaBS(IFirmaRepository repo)
        {
            _repo = repo;
        }

        public Firma Delete(Firma entity)
        {
            return _repo.Delete(entity);
        }

        public Firma Delete(int Id)
        {
            return _repo.Delete(Id);
        }

        public Firma Get(Expression<Func<Firma, bool>> filter, params string[] incluedelist)
        {
            return _repo.Get(filter, incluedelist);
        }

        public List<Firma> GetAll(Expression<Func<Firma, bool>> filter, params string[] incluedelist)
        {
            return _repo.GetAll(filter, incluedelist);
        }

        public Firma GetById(int Id, params string[] incluedelist)
        {
            return _repo.GetById(Id, incluedelist);
        }

        public Firma Insert(Firma entity)
        {
            return _repo.Insert(entity);
        }

        public Firma Update(Firma entity)
        {
            return _repo.Update(entity);
        }
    }
}
