namespace Cdc.EpiInfo.Models 
{
    public sealed class MenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Href { get; set; } = string.Empty;
        public MenuItemType Type { get; set; }
    }
}