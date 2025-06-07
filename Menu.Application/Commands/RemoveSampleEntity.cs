using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands;

public record RemoveSampleEntity(Guid Id) : ICommand;
