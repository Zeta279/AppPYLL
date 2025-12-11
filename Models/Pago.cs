namespace AppPYLL.Models
{
    public class Pago
    {
        public int IDPago { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public bool Positivo { get; set; }

        public string Descripcion { get; set; }
    }
}
