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
    public class TaksitSecenekBs:ITaksitSecenekBS
    {
        private ITaksiktSecenekRepository repo;
        public TaksitSecenekBs(ITaksiktSecenekRepository _repo)
        {
            repo = _repo;
        }
        public TaksitSecenek Delete(TaksitSecenek entity)
        {
            return repo.Delete(entity);
        }

        public TaksitSecenek Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public TaksitSecenek Get(Expression<Func<TaksitSecenek, bool>> fTaksitSecenekter, params string[] includelist)
        {
            return repo.Get(fTaksitSecenekter, includelist);
        }

        public List<TaksitSecenek> GetAll(Expression<Func<TaksitSecenek, bool>> fTaksitSecenekter, params string[] includelist)
        {
            return repo.GetAll(fTaksitSecenekter, includelist);
        }

        public TaksitSecenek GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public TaksitSecenek Insert(TaksitSecenek entity)
        {
            return repo.Insert(entity);
        }

        public TaksitSecenek Update(TaksitSecenek entity)
        {
            return repo.Update(entity);
        }
    }
}
