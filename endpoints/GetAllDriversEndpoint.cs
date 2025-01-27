using FastEndpoints;
using fleetmanagement.repositories;
using fleetmanagement.dtos;

public class GetAllDriversEndpoint : EndpointWithoutRequest<IEnumerable<DriverResponse>>
{
    private readonly IDriverRepository _repository;

    public GetAllDriversEndpoint(IDriverRepository repository)
    {
        _repository = repository;
    }

    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/api/drivers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var drivers = await _repository.GetAllDriversAsync();
        await SendAsync(drivers.Select(t => new DriverResponse
        {
            Id = t.Id,
            Name = t.Name,
            License = t.License
        }));
    }
}

