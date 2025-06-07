using Menu.Domain.Entities;
using Menu.Domain.ValueObjects;

namespace Menu.Domain.Repositories;

    public interface ISampleEntityRepository
    {
        Task<SampleEntity> GetAsync(SampleEntityId id);
        Task AddAsync(SampleEntity sampleEntity);
        Task UpdateAsync(SampleEntity sampleEntity);
        Task DeleteAsync(SampleEntity sampleEntity);
    }
