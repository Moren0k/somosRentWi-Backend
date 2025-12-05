using SomosRentWi.Domain.Common;

namespace SomosRentWi.Domain.Entities;

public class CompanyWallet : BaseEntity
{
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public decimal Balance { get; set; }
}