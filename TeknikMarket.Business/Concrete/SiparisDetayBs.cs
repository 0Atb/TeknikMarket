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
    public class SiparisDetayBs:ISiparisDetayBS
    {
        private ISiparisDetayRepository repo;
        public SiparisDetayBs(ISiparisDetayRepository _repo)
        {
            repo = _repo;
        }
        public SiparisDetay Delete(SiparisDetay entity)
        {
            return repo.Delete(entity);
        }

        public SiparisDetay Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public SiparisDetay Get(Expression<Func<SiparisDetay, bool>> fSiparisDetayter, params string[] includelist)
        {
            return repo.Get(fSiparisDetayter, includelist);
        }

        public List<SiparisDetay> GetAll(Expression<Func<SiparisDetay, bool>> fSiparisDetayter, params string[] includelist)
        {
            return repo.GetAll(fSiparisDetayter, includelist);
        }

        public SiparisDetay GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public SiparisDetay Insert(SiparisDetay entity)
        {
            return repo.Insert(entity);
        }

        public SiparisDetay Update(SiparisDetay entity)
        {
            return repo.Update(entity);
        }
    }
}
