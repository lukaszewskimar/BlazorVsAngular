using System.ComponentModel.DataAnnotations.Schema;

namespace Ebooks.Core.Domain
{
    public class Page
    {
        public int Id { get; set; }
        public int PageNo { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(Ebook))]
        public int EbookId { get; set; }
        public Ebook Ebook { get; set; }
    }
}
