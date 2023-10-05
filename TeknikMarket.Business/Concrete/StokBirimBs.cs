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
    public class StokBirimBs:IStokBirimBS
    {
        private IStokBirimRepository repo;
        public StokBirimBs(IStokBirimRepository _repo)
        {
            repo = _repo;
        }
        public StokBirim Delete(StokBirim entity)
        {
            return repo.Delete(entity);
        }

        public StokBirim Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public StokBirim Get(Expression<Func<StokBirim, bool>> fStokBirimter, params string[] includelist)
        {
            return repo.Get(fStokBirimter, includelist);
        }

        public List<StokBirim> GetAll(Expression<Func<StokBirim, bool>> fStokBirimter, params string[] includelist)
        {
            return repo.GetAll(fStokBirimter, includelist);
        }

        public StokBirim GetById(int Id, params string[] includelist)
        {
            return repo.GetById(Id, includelist);
        }

        public StokBirim Insert(StokBirim entity)
        {
            return repo.Insert(entity);
        }

        public StokBirim Update(StokBirim entity)
        {
            return repo.Update(entity);
        }
    }
}
