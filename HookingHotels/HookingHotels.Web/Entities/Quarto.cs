using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HookingHotels.Web.Entities;

public class Quarto
{
    [Key]
    public int QuartoId { get; set; }

    [Required]
    public int Numero { get; set; }

    [MaxLength(200)]
    public string Descricao { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecoPorNoite { get; set; }

    //Relacionamento com Reserva
    public virtual ICollection<Reserva> Reservas { get; set; }
}