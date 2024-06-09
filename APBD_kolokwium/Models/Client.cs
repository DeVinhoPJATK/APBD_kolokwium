using System.ComponentModel.DataAnnotations;

namespace APBD_kolokwium.Models;

public class Client
{
    [Key]
    public int IdClient { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(100)]
    public string Phone { get; set; }
}
