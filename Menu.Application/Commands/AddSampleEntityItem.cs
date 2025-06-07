using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands.Handlers;

public record AddSampleEntityItem(Guid sampleEntityId, string Name, uint Quantity) : ICommand;
