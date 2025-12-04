using SomosRentWi.Domain.Enums;

namespace SomosRentWi.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Plate { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    
    public decimal ComercialValue { get; set; }
    public decimal ReferencePricePerDay { get; set; }
    public decimal MaxAllowedPricePerDay { get; set; }
    public decimal PricePerDay { get; set; } // Price Per Day
    
    public DateTime SoatExpirationDate { get; set; } = DateTime.MinValue;
    public DateTime TechInspectionExpirationDate { get; set; } = DateTime.MinValue;
    
    public string MainPhotoUrl { get; set; } = string.Empty;

    public CarValidationStatus ValidationStatus { get; set; } = CarValidationStatus.Pending;
    public bool IsAvailable { get; set; }
    
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
}