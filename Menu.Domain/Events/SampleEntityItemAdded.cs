
using Menu.Domain.Entities;
using Menu.Shared.Abstractions.Domains;
using Menu.Domain.ValueObjects;

namespace Menu.Domain.Events;

public record SampleEntityItemAdded(SampleEntity sampleEntity, SampleEntityItem sampleEntityItem) : IDomainEvent;
