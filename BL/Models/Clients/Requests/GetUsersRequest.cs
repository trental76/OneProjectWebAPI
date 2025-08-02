namespace OneProjectWebAPI.BL.Models.Clients.Requests;

public class GetUsersRequest
{
    public int PageSize { get; set; }

    public int PageNumber { get; set; }

    public string? ColumnName { get; set; }

    public string? ColumnValue { get; set; }
}
