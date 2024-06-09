using System.ComponentModel.DataAnnotations;

namespace APBD_kolokwium.Models;

public class Sale
{
    [Key]
    public int IdSale { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public Client Client { get; set; }
    public Subscription Subscription { get; set; }
}
