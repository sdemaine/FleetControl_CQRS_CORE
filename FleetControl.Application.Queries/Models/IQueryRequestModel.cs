namespace FleetControl.Application.Queries
{
    public interface IQueryRequestModel
    {
        bool ActiveOnly { get; set; }
        int Baid { get; set; }
        int CustomerId { get; set; }
        string SearchQuery { get; set; }
        int Skip { get; set; }
        string SortBy { get; set; }
        string SortDirection { get; set; }
        int Take { get; set; }
    }
}