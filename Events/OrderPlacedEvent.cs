namespace FCG.Shared.Events;

public record OrderPlacedEvent(
    Guid OrderId,
    Guid UserId,
    Guid GameId,
    string GameName,
    decimal Amount,
    DateTime CreatedOn
);