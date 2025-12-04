using SomosRentWi.Domain.Enums;

namespace SomosRentWi.Domain.Entities;

public class Rental
{
    public int Id { get; set; }
    
    public int ClientId { get; set; }
    public Client? Client { get; set;}
    public int CompanyId { get; set; }
    public Company? Company { get; set;}
    public int CarId { get; set; }
    public Car? Car { get; set;}
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    public decimal DepositAmount { get; set; }

    public RentalStatus Status { get; set; } = RentalStatus.PendingDelivery;
    public DateTime CreatedAt { get; set; }
    
    public string ContractPdfUrl { get; set; } = string.Empty;
}