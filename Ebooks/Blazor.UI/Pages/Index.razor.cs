using System.Collections.Generic;
using System.Threading.Tasks;
using Ebooks.Core.Domain;
using Ebooks.Core.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Pages
{
    public partial class Index
    {
        protected IEnumerable<Ebook> Ebooks { get; set; }

        [Inject] private IEbookRepository EbookRepository { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Ebooks = await EbookRepository.GetAll();
        }
    }
}
