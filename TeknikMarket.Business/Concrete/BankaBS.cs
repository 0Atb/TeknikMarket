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
    public class BankaBS : IBankaBS
    {
        private readonly IBankaRepository _repo;

        public BankaBS(IBankaRepository repo)
        {
            _repo = repo;
        }

        public Banka Delete(Banka entity)
        {
           return _repo.Delete(entity);
        }

        public Banka Delete(int Id)
        {
           return _repo.Delete(Id);
        }

        public Banka Get(Expression<Func<Banka, bool>> filter, params string[] incluedelist)
        {
            return _repo.Get(filter, incluedelist);
        }

        public List<Banka> GetAll(Expression<Func<Banka, bool>> filter, params string[] incluedelist)
        {
            return _repo.GetAll(filter, incluedelist);
        }

        public Banka GetById(int Id, params string[] incluedelist)
        {
            return _repo.GetById(Id, incluedelist);
        }

        public Banka Insert(Banka entity)
        {
            return _repo.Insert(entity);
        }

        public Banka Update(Banka entity)
        {
           return _repo.Update(entity);
        }
    }
}
