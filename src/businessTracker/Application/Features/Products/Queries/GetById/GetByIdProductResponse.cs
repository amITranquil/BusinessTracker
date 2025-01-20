using NArchitecture.Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int StockQuantity { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsActive { get; set; }
}