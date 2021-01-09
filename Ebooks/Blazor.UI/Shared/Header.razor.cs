using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Shared
{
    public partial class Header
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }
    }
}
