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
    public class UrunBs:IUrunBS
    {
        private IUrunRepository repo;
        public UrunBs(IUrunRepository _repo)
        {
            repo = _repo;
        }

        public Urun Delete(Urun entity)
        {
            return repo.Delete(entity);
        }

        public Urun Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Urun Get(Expression<Func<Urun, bool>> fUrunter, params string[] includelist)
        {
            return repo.Get(fUrunter, includelist);
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> fUrunter, params string[] includelist)
        {
            return repo.GetAll(fUrunter, includelist);
        }

        public Urun GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public Urun Insert(Urun entity)
        {
            return repo.Insert(entity);
        }

        public Urun Update(Urun entity)
        {
            return repo.Update(entity);
        }
    }
}
