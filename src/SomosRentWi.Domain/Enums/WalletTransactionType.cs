using SomosRentWi.Domain.Common;

namespace SomosRentWi.Domain.Enums;

public enum WalletTransactionType
{
    RentalIncome, // +
    PayoutCompany, // -
    ManualAdjustment // + ° -
}