using NArchitecture.Core.Persistence.Repositories;
using System.Security.Cryptography;

namespace Domain.Entities;
public class Product :  Entity<Guid>, IEntity<Guid>, IEntityTimestamps
{

  
    public required string Name { get; set; }
    public required string Category { get; set; }
    public int StockQuantity { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsActive { get; set; }
}
