using Menu.Application.DTOs;
using Menu.Application.Queries;
using Menu.Domain.Entities;
using Menu.Infrastructure.EF.Contexts;
using Menu.Infrastructure.EF.Models;
using Menu.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Menu.Infrastructure.EF.Queries.Handlers;

internal sealed class GetSampleEntityHandler : IQueryHandler<GetSampleEntity, SampleEntityDto>
{
    private readonly DbSet<SampleEntityReadModel> _SampleEntities;

    public GetSampleEntityHandler(ReadDbContext context)
        => _SampleEntities = context.SampleEntities;

    public Task<SampleEntityDto> HandleAsync(GetSampleEntity query)
        => _SampleEntities
            .Include(pl => pl.Items)
            .Where(pl => pl.Id == query.Id)
            .Select(pl => pl.AsDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
}
