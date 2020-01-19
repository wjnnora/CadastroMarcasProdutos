using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Commom
{
    public interface IRepositoryGeneric<TEntity>
    {        
        Task<List<TEntity>> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
