using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shared;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ResourcesController : ControllerBase
{
 
    private static List<Resource> _db = new List<Resource>
    {
        new Resource { Id = 1, Name = "Laptop Dell", Status = "Dostępny" },
        new Resource { Id = 2, Name = "Projektor", Status = "W naprawie" }
    };

    private readonly IHubContext<ResourceHub> _hub;

    public ResourcesController(IHubContext<ResourceHub> hub)
    {
        _hub = hub;
    }

    [HttpGet]
    public IEnumerable<Resource> Get() => _db;

    [HttpPost]
    public async Task Post(Resource resource)
    {
        resource.Id = _db.Any() ? _db.Max(x => x.Id) + 1 : 1;
        _db.Add(resource);
       
        await _hub.Clients.All.SendAsync("ReceiveUpdate");
    }
}