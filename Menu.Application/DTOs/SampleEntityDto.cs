namespace Menu.Application.DTOs;

public record SampleEntityDto(Guid Id,
                              string Name,
                              DestinationDto Destination,
                              IEnumerable<SampleEntityItemDto> Items);
