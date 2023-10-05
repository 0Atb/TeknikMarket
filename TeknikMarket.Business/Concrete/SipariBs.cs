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
    public class SipariBs:ISipariBS
    {
        private ISipariRepository repo;
        public SipariBs(ISipariRepository _repo)
        {
             repo = _repo;
        }
        public Sipari Delete(Sipari entity)
        {
            return repo.Delete(entity);
        }

        public Sipari Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Sipari Get(Expression<Func<Sipari, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Sipari> GetAll(Expression<Func<Sipari, bool>> filter, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Sipari GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public Sipari Insert(Sipari entity)
        {
            return repo.Insert(entity);
        }

        public Sipari Update(Sipari entity)
        {
            return repo.Update(entity);
        }
    }
}
