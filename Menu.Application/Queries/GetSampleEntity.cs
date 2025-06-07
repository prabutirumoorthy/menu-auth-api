using Menu.Application.DTOs;
using Menu.Shared.Abstractions.Queries;

namespace Menu.Application.Queries;

public class GetSampleEntity : IQuery<SampleEntityDto>
{
    public Guid Id { get; set; }
}
