using System.ComponentModel.DataAnnotations;

namespace Api.Microservice.Cupon.Models
{
    public class Cupon
    {
        [Key]
        public int CuponId {  get; set; }
        [Required]
        public string CuponCode {  get; set; }
        [Required]
        public double PorcentajeDescuento {  get; set; }
        public int DescuentoMinimo {  get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Boolean Status { get; set; }
        public String TipoGenero { get; set; }

    }
}
