using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.UI.Data;
using Ebooks.Core.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Pages
{
    public partial class Home
    {
        protected IEnumerable<Ebook> Ebooks { get; set; }

        [Inject] private EbookService EbookService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Ebooks = await EbookService.GetAll();
        }
    }
}
