using SomosRentWi.Domain.Common;
using SomosRentWi.Domain.Enums;

namespace SomosRentWi.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Guest;
    public bool IsActive { get; set; } = true;
}