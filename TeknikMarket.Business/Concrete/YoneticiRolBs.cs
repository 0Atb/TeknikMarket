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
    public class YoneticiRolBs:IYoneticiRolBS
    {
        private IYoneticiRolRepository repo;
        public YoneticiRolBs(IYoneticiRolRepository _repo)
        {
            repo = _repo;
        }
        public YoneticiRol Delete(YoneticiRol entity)
        {
            return repo.Delete(entity);
        }

        public YoneticiRol Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public YoneticiRol Get(Expression<Func<YoneticiRol, bool>> fYoneticiRolter, params string[] includelist)
        {
            return repo.Get(fYoneticiRolter, includelist);
        }

        public List<YoneticiRol> GetAll(Expression<Func<YoneticiRol, bool>> fYoneticiRolter, params string[] includelist)
        {
            return repo.GetAll(fYoneticiRolter, includelist);
        }

        public YoneticiRol GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public YoneticiRol Insert(YoneticiRol entity)
        {
            return repo.Insert(entity);
        }

        public YoneticiRol Update(YoneticiRol entity)
        {
            return repo.Update(entity);
        }
    }
}
