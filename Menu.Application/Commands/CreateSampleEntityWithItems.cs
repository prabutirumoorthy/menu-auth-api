using Menu.Domain.Consts;
using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands;

public record CreateSampleEntityWithItems(Guid Id, string Name, Gender Gender,
   DestinationWriteModel Destionation) : ICommand;

public record DestinationWriteModel(string City, string Country);
