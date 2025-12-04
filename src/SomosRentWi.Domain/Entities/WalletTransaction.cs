using SomosRentWi.Domain.Enums;

namespace SomosRentWi.Domain.Entities;

public class WalletTransaction
{
    public int Id { get; set; }
    
    public int WalletId { get; set; }
    public CompanyWallet? CompanyWallet { get; set; }
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public WalletTransactionType TransactionType { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}