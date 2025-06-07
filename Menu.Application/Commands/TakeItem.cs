using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands;

public record TakeItem(Guid sampleEntityId, string Name) : ICommand;