using Menu.Application.DTOs;
using Menu.Shared.Abstractions.Queries;

namespace Menu.Application.Queries;

public class SearchSampleEntity : IQuery<IEnumerable<SampleEntityDto>>
{
    public string SearchPhrase { get; set; }
}
