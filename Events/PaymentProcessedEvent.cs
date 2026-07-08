namespace FCG.Shared.Events;

public record PaymentProcessedEvent(
    Guid OrderId,
    Guid UserId,
    Guid GameId,
    string GameTitle,
    decimal Price,
    string Status
);