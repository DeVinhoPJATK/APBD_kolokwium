using APBD_kolokwium.Dto;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kolokwium.Services;

public interface IClientService
{
    public ClientSubscriptionsDto FetchClientSubscriptions();
}
