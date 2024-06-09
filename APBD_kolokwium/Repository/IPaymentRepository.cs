using APBD_kolokwium.Models;

namespace APBD_kolokwium.Repository;

public interface IPaymentRepository
{

    public Payment getPayment(int clientId);

}
