namespace SomosRentWi.Domain.Entities;

public class CompanyWallet
{
    public int Id { get; set; }

    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public decimal Balance { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
}