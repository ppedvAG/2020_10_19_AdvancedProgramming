using GenericRepositorySample.Traits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    public interface IRepository <TEntity, TKey>
        : IReadOnlyRepositoryAsync<TEntity, TKey>,
          IWriteCommand<TEntity>,
          IUpdateCommand<TEntity, TKey>,
          IDeleteCommand<TKey> where TEntity : class

    {
        Task<int> Count();

        Task Commit();
    }
}
