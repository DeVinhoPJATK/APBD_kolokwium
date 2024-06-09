using APBD_kolokwium.Context;
using APBD_kolokwium.Models;

namespace APBD_kolokwium.Repository;

public class ClientRepository : IClientRepository
{
    private readonly MainDBContext _mainDbContext;

    public ClientRepository(MainDBContext mainDbContext)
    {
        _mainDbContext = mainDbContext;
    }

    public Client GetClient(int clientId)
    {
        return _mainDbContext.Clients.Find(clientId);
    }
}
