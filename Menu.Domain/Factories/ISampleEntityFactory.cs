using Menu.Domain.Consts;
using Menu.Domain.Entities;
using Menu.Domain.ValueObjects;

namespace Menu.Domain.Factories;

    public interface ISampleEntityFactory
    {
        SampleEntity Create(SampleEntityId id, SampleEntityName name, SampleEntityDestination destination);

        SampleEntity CreateWithDefaultItems(SampleEntityId id, SampleEntityName name, Gender gender,
            SampleEntityDestination destination);
    }
