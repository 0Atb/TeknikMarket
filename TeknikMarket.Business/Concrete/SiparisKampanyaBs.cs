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
    public class SiparisKampanyaBs:ISiparisKampanyaBS
    {
        private ISiparisKampanyaRepository repo;
        public SiparisKampanyaBs(ISiparisKampanyaRepository _repo)
        {
            repo = _repo;
        }
        public SiparisKampanya Delete(SiparisKampanya entity)
        {
            return repo.Delete(entity);
        }

        public SiparisKampanya Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public SiparisKampanya Get(Expression<Func<SiparisKampanya, bool>> fSiparisKampanyater, params string[] includelist)
        {
            return repo.Get(fSiparisKampanyater, includelist);
        }

        public List<SiparisKampanya> GetAll(Expression<Func<SiparisKampanya, bool>> fSiparisKampanyater, params string[] includelist)
        {
            return repo.GetAll(fSiparisKampanyater, includelist);
        }

        public SiparisKampanya GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public SiparisKampanya Insert(SiparisKampanya entity)
        {
            return repo.Insert(entity);
        }

        public SiparisKampanya Update(SiparisKampanya entity)
        {
            return repo.Update(entity);
        }
    }
}
