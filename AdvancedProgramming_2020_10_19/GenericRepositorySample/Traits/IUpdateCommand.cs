using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface IUpdateCommand<TEntity, TKey> where TEntity : class
    {
        Task Update(TKey Id, TEntity ModifiedEntity);
        Task UpdateRange(IDictionary<TKey, TEntity> ModifiedEntities);
    }
}
