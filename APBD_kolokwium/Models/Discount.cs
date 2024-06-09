using System.ComponentModel.DataAnnotations;

namespace APBD_kolokwium.Models;

public class Discount
{
    [Key]
    public int IdDiscount { get; set; }

    [Required]
    public int Value { get; set; }

    [Required]
    public DateTime DateFrome { get; set; }

    [Required]
    public DateTime DateTo { get; set; }
    
    public Client Client { get; set; }
}
