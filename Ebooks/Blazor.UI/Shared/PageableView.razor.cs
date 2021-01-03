using System.Collections.Generic;
using Blazor.UI.Models;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Shared
{
    public class PageableViewBase<TItem> : ComponentBase
    {
        [Parameter] public IList<TItem> Data { get; set; }
        [Parameter] public RenderFragment<TItem> Template { get; set; }

        protected IList<PageItem<TItem>> Items { get; set; } = new List<PageItem<TItem>>();
        protected int Index { get; set; } = 0;

        protected override void OnInitialized()
        {
            if (Data == null)
            {
                return;
            }

            for (int i = 0; i < Data.Count; i++)
            {
                Items.Add(
                    new PageItem<TItem>
                    {
                        Index = i,
                        Data = Data[i]
                    });
            }
        }
    }
}
