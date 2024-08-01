namespace Api.Microservice.Cupon.Models.Dto
{
    public class CuponDto
    {
        public int CuponId { get; set; }
        public string CuponCode { get; set; }
        public double PorcentajeDescuento { get; set; }
        public int DescuentoMinimo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Boolean Status { get; set; }
        public String TipoGenero { get; set; }

    }
}
