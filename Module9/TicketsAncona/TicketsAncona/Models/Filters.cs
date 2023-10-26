namespace TicketsAncona.Models
{
    public class Filters
    {
        public Filters(string filterString)
        {
            FilterString = filterString ?? "all";
            StatusId = FilterString;
        }

        public string FilterString { get; }
        public string StatusId { get; }

        public bool HasStatus => StatusId.ToLower() != "all";
    }
}
