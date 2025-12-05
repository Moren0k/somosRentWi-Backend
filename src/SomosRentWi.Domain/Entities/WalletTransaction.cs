using SomosRentWi.Domain.Common;
using SomosRentWi.Domain.Enums;

namespace SomosRentWi.Domain.Entities;

public class WalletTransaction : BaseEntity
{
    public int WalletId { get; set; }
    public CompanyWallet? CompanyWallet { get; set; }
    
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public WalletTransactionType TransactionType { get; set; }
}