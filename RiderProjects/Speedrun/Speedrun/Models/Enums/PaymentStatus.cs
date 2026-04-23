namespace Speedrun.Models.Enums;

public enum PaymentStatus
{
    Pending = 0,
    WaitingForCapture = 1,
    Succeeded = 2,
    Canceled = 3,
    Failed = 4
}
