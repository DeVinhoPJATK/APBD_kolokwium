using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace APBD_kolokwium.Models;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal Value { get; set; }

    public Client Client { get; set; }

    public Subscription Subscription { get; set; }
}
