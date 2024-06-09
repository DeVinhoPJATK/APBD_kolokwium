namespace APBD_kolokwium.Dto;

public class SubscriptionDto
{
    public int IdSubscription { get; set; }

    public string Name { get; set; }

    public int RenewalPeriod { get; set; }

    public decimal TotalPaidAmount { get; set; }

    public SubscriptionDto(int idSubscription, string name, int renewalPeriod, decimal totalPaidAmount)
    {
        IdSubscription = idSubscription;
        Name = name;
        RenewalPeriod = renewalPeriod;
        TotalPaidAmount = totalPaidAmount;
    }
}
