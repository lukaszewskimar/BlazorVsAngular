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

        public async Task<Ebook> GetById(int id, CancellationToken cancellationToken = default)
        {
            var ebook = await _context.Ebooks.Include(e => e.Pages).Where(e => e.Id == id).FirstOrDefaultAsync(cancellationToken);

            foreach (var page in ebook.Pages)
            {
                page.Ebook = null;
            }

            return ebook;
        }

        public async Task<IEnumerable<Ebook>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _context.Ebooks.ToListAsync(cancellationToken);
        }
    }
}
