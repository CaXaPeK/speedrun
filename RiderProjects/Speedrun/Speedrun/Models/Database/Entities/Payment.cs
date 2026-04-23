using System.ComponentModel.DataAnnotations;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database.Entities;

public class Payment
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ApplicationId { get; set; }
    public Application? Application { get; set; }

    public decimal Amount { get; set; }
    public string Currency { get; set; } = "RUB";

    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

    public string? YooKassaPaymentId { get; set; }
    public string? ConfirmationUrl { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }
}
