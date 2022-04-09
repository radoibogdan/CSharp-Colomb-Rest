using Colomb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.IRepository
{
    // Register for every variation of the generic repository relative to the class T
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Evenement> Evenements { get; }
        IGenericRepository<Compte> Comptes { get; }
        // Save to db all the changes
        Task Save();
    }
}
