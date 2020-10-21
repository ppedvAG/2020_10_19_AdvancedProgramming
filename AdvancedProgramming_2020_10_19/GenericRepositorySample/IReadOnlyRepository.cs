using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    //synchrones Interfacxe
    public interface IReadOnlyRepository <TEntity, TKey> where TEntity : class
    {
        TEntity Single(Expression<Func<TEntity, bool>> predicate); //Beispiel implementierung InstanceName.Single(p=>p.Alter > 40);
        TEntity GetById(TKey Id);
        IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> GetAll();
    }



    //Asynchrones Interface
    public interface IReadOnlyRepositoryAsync<TEntity, TKey> where TEntity : class
    {
        Task<TEntity> Single(Expression<Func<TEntity, bool>> predicate); //Beispiel implementierung InstanceName.Single(p=>p.Alter > 40);
        Task<TEntity> GetById(TKey Id);
        Task<IList<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<IList<TEntity>> GetAll();
    }
}
