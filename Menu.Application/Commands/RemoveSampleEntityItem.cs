using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands;

public record RemoveSampleEntityItem(Guid sampleEntityId, string Name) : ICommand;
