using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class VentasRealizadas
    {
        private static int codigoIncremental=1;
        public int CodigoVenta { get; set; }
        public Bebidas BebidaVendida { get; set; }
        public DateTime FechaYHoraVenta { get; set; }
        public double Cantidad { get; set; }
        public double MontoFinalAbonado { get; set; }

        public VentasRealizadas(Bebidas bebidas, int cantidad)
        {
            CodigoVenta=codigoIncremental;
            BebidaVendida = bebidas;
            FechaYHoraVenta = DateTime.Now;
            Cantidad = cantidad;
            MontoFinalAbonado = bebidas.PrecioFinal * cantidad;

            codigoIncremental++;
        }
    }
}
