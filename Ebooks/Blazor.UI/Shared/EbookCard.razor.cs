using Ebooks.Core.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Shared
{
    public partial class EbookCard
    {
        [Parameter] public Ebook Item { get; set; }
    }
}
