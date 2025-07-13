using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class BebidasConAlcohol:Bebidas
    {
        public double PorcentajeAlcohol { get; set; } 
        public Enums.TipoBebida TipoBebida { get; set; }
        public Enums.TipoEnvase TipoEnvase { get; set; }
        public DateTime FechaFabricacion { get; set; }

        public override double CalcularPrecioFinal()
        {
            PrecioFinal = PrecioBase;
            if (PorcentajeAlcohol > 30)
            {
                PrecioFinal += PrecioBase * 0.1;
            }
            if (TipoEnvase == Enums.TipoEnvase.Vidrio)
            {
                PrecioFinal += PrecioBase * 0.05;
            }
            return PrecioFinal;
        }
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $", Porcentaje Alcohol: {PorcentajeAlcohol}%, Tipo Bebida: {TipoBebida}";
        }

    }
}
