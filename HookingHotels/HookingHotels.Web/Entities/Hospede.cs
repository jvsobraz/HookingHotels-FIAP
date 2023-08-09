using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace HookingHotels.Web.Entities;

public class Hospede
{
    [Key]
    public int HospedeId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(200)]
    public string Email { get; set; }

    [MaxLength(15)]
    public string Telefone { get; set; }

    //Relacionamento com Reserva
    public virtual ICollection<Reserva> Reservas { get; set; }
}