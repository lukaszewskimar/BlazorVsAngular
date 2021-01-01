using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ebooks.Core.Domain;

namespace Ebooks.Core.Interfaces
{
    public interface IEbookRepository
    {
        Task<Ebook> Get(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Ebook>> GetAll(CancellationToken cancellationToken = default);
        Task Add(Ebook entity);
        Task Update(Ebook entity);
        Task Remove(int id);
    }
}
