namespace Assignment1Final.Models
{
    public class Search
    {
        public string SearchString { get; set; }
        public string Category { get; set; }
        public string SortBy { get; set; }
        public List<Item> Items { get; set; }
    }
}
