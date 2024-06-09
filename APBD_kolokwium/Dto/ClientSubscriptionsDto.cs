namespace APBD_kolokwium.Dto;

public class ClientSubscriptionsDto
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public int Discount { get; set; }

    public ICollection<SubscriptionDto> Subscriptions { get; set; }

    public ClientSubscriptionsDto(string firstName, string lastName, string email, string phone, int discount, ICollection<SubscriptionDto> subscriptions)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Discount = discount;
        Subscriptions = subscriptions;
    }
}
