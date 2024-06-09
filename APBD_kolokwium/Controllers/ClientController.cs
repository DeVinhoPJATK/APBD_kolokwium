using APBD_kolokwium.Dto;
using APBD_kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kolokwium.Controllers;

[ApiController]
[Route("/api/clients")]
public class ClientController : ControllerBase
{

    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet("/subscriptions/{clientId}")]
    public ActionResult<ClientSubscriptionsDto> FetchClientsWithSubscriptions(int clientId)
    {
        return Ok(_clientService.FetchClientSubscriptions(clientId));
    }
}
