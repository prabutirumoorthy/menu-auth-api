using Menu.Domain.ValueObjects;

namespace Menu.Domain.Policies;

    public interface ISampleEntityItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<SampleEntityItem> GenerateItems(PolicyData data);
    }
