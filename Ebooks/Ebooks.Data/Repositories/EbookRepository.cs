using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ebooks.Core.Domain;
using Ebooks.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ebooks.Data.Repositories
{
    public class EbookRepository : IEbookRepository
    {
        private readonly EbooksContext _context;

        public EbookRepository(EbooksContext context)
        {
            _context = context;
        }

        public async Task Add(Ebook entity)
        {
            await _context.Ebooks.AddAsync(entity);
        }

        public Task<Ebook> Get(int id, CancellationToken cancellationToken = default)
        {
            return _context.Ebooks.Where(e => e.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Ebook>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _context.Ebooks.ToListAsync(cancellationToken);
        }

        public Task Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Ebook entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
