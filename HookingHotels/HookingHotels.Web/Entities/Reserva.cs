using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HookingHotels.Web.Entities;

public class Reserva
{
    [Key]
    public int ReservaId { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }

    [Required]
    public DateTime DataFim { get; set; }
    public virtual Hospede Hospede { get; set; }

    [ForeignKey(name: "Quarto")]
    public int QuartoId { get; set; }
    public virtual Quarto Quarto { get; set; }
}