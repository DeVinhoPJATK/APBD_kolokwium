using APBD_kolokwium.Models;

namespace APBD_kolokwium.Repository;

public interface IClientRepository
{

    public Client GetClient(int clientId);

}
