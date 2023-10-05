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
    public class IlBS:IIlBS
    {
        private readonly IIlRepository _repo;

        public IlBS(IIlRepository repo)
        {
            _repo = repo;
        }

        public Il Delete(Il entity)
        {
            return _repo.Delete(entity);
        }

        public Il Delete(int Id)
        {
            return _repo.Delete(Id);
        }

        public Il Get(Expression<Func<Il, bool>> filter, params string[] incluedelist)
        {
            return _repo.Get(filter, incluedelist);
        }

        public List<Il> GetAll(Expression<Func<Il, bool>> filter, params string[] incluedelist)
        {
            return _repo.GetAll(filter, incluedelist);
        }

        public Il GetById(int Id, params string[] incluedelist)
        {
            return _repo.GetById(Id, incluedelist);
        }

        public Il Insert(Il entity)
        {
            return _repo.Insert(entity);
        }

        public Il Update(Il entity)
        {
            return _repo.Update(entity);
        }
    }
}
