namespace Blazor.UI.Models
{
    public class PageItem<TItem>
    {
        public int Index { get; set; }
        public TItem Data { get; set; }
    }
}
