using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ebooks.Core.Domain;

namespace Ebooks.Core.Interfaces
{
    public interface IEbookRepository
    {
        Task<Ebook> GetById(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Ebook>> GetAll(CancellationToken cancellationToken = default);
    }
}
