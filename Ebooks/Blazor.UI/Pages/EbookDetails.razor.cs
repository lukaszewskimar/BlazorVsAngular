using System.Threading.Tasks;
using Blazor.UI.Data;
using Ebooks.Core.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Pages
{
    public partial class EbookDetails
    {
        [Parameter] public int Id { get; set; }

        protected Ebook Ebook { get; set; }
        protected bool Loading { get; set; } = true;

        [Inject] private EbookService EbookService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Ebook = await EbookService.Get(Id);
            Loading = false;
        }
    }
}
