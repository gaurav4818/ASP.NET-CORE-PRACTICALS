using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_19.Repository
{
    public interface IUnitOfWork : IDisposable
    {
      
        IProductRepository Products { get; }
        int Complete();
    }
}
