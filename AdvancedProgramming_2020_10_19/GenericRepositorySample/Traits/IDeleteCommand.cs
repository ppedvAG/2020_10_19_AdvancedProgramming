using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface IDeleteCommand<TKey>
    {
        Task Delete(TKey Id);
        Task DeleteRange(TKey[] Ids);
    }
}
