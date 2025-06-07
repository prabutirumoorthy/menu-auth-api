using Menu.Application.Exceptions;
using Menu.Domain.Repositories;
using Menu.Domain.ValueObjects;
using Menu.Shared.Abstractions.Commands;

namespace Menu.Application.Commands.Handlers;

internal sealed class AddSampleEntityItemHandler : ICommandHandler<AddSampleEntityItem>
{
    private readonly ISampleEntityRepository _repository;

    public AddSampleEntityItemHandler(ISampleEntityRepository repository)
        => _repository = repository;

    public async Task HandleAsync(AddSampleEntityItem command)
    {
        var sampleEntity = await _repository.GetAsync(command.sampleEntityId);

        if (sampleEntity is null)
        {
            throw new SampleEntityNotFound(command.sampleEntityId);
        }

        var sampleEntityItem = new SampleEntityItem(command.Name, command.Quantity);
        sampleEntity.AddItem(sampleEntityItem);

        await _repository.UpdateAsync(sampleEntity);
    }
}

