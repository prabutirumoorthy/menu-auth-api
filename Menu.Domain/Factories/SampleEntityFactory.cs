using Menu.Domain.Consts;
using Menu.Domain.Entities;
using Menu.Domain.Policies;
using Menu.Domain.ValueObjects;

namespace Menu.Domain.Factories;

    public sealed class SampleEntityFactory : ISampleEntityFactory
    {

        private readonly IEnumerable<ISampleEntityItemsPolicy> _policies;


        public SampleEntityFactory(IEnumerable<ISampleEntityItemsPolicy> policies)
            => _policies = policies;

        public SampleEntity Create(SampleEntityId id, SampleEntityName name, SampleEntityDestination destination)
            => new(id, name, destination);

        public SampleEntity CreateWithDefaultItems(SampleEntityId id, SampleEntityName name , Gender gender,
         SampleEntityDestination destination)
        {
            var data = new PolicyData(gender, destination);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var sampleEntity = Create(id, name, destination);

            sampleEntity.AddItems(items);

            return sampleEntity;
        }

    }
