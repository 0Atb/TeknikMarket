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
    public class YoneticiBs:IYoneticiBS
    {
        private IYoneticiRepository repo;
        public YoneticiBs(IYoneticiRepository _repo)
        {
            repo = _repo;
        }
        public Yonetici Delete(Yonetici entity)
        {
            return repo.Delete(entity);
        }

        public Yonetici Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Yonetici Get(Expression<Func<Yonetici, bool>> fYoneticiter, params string[] includelist)
        {
            return repo.Get(fYoneticiter, includelist);
        }

        public List<Yonetici> GetAll(Expression<Func<Yonetici, bool>> fYoneticiter, params string[] includelist)
        {
            return repo.GetAll(fYoneticiter, includelist);
        }

        public Yonetici GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public Yonetici Insert(Yonetici entity)
        {
            return repo.Insert(entity);
        }

        public Yonetici Update(Yonetici entity)
        {
            return repo.Update(entity);
        }
    }
}
