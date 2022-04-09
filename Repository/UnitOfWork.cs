using Colomb.Data;
using Colomb.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Evenement> _evenements;
        private IGenericRepository<Compte> _comptes;

        // Constructor
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        // ??= if _reviews is empty return new => else return _reviews
        public IGenericRepository<Review> Reviews => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Evenement> Evenements => _evenements ??= new GenericRepository<Evenement>(_context);
        public IGenericRepository<Compte> Comptes => _comptes ??= new GenericRepository<Compte>(_context);

        // When operations are done free up the memory
        public void Dispose()
        {
            // Kill the connection to the db
            _context.Dispose();
            // GC = GarbageCollector
            GC.SuppressFinalize(this); 
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
