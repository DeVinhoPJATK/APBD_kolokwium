using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace APBD_kolokwium.Models;

public class Subscription
{
    [Key]
    public int IdSubscription { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public int RenewalPeriod { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    [Required]
    [Column(TypeName="money")]
    public decimal Price { get; set; }
}
