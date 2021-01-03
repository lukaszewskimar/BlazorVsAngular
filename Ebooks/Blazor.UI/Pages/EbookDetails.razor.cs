using System.Threading.Tasks;
using Blazor.UI.Data;
using Ebooks.Core.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Pages
{
    public partial class EbookDetails
    {
        [Parameter] public int Id { get; set; }

        protected int PageIndex { get; set; } = 0;
        protected Ebook Ebook { get; set; }

        [Inject] private EbookService EbookService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Ebook = await EbookService.Get(Id);
        }
    }
}
