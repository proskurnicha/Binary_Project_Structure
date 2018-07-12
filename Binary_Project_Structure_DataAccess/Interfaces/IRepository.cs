using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Interfaces
{
    public interface IRepository<TEntity>
    {
        List<TEntity> Get();

        TEntity GetById(object id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(object id);

        void Save();

        //Task SaveAsync(); It'll release in feature
    }
}
