﻿using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeknikMarket.Business.Abstract
{
    public interface IBusinessBase<TEntity>
        where TEntity : AudiTableEntity,IBaseDomain,new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null, params string[] incluedelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] incluedelist);
        TEntity GetById(int Id,params string[] incluedelist);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Delete(int Id);
    }
}
