using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class BebidasSinAlcohol:Bebidas
    {
        public Enums.Sabor Sabor { get; set; }
        public bool Gasificada { get; set; }
        public bool AptoDiabeticos { get; set; }
        public bool Colorantes { get; set; }

        public override double CalcularPrecioFinal()
        {
            PrecioFinal = PrecioBase;
            if (AptoDiabeticos == true)
            {
                PrecioFinal += PrecioBase * 0.15;
            }
            if(Sabor == Enums.Sabor.Cola || Sabor==Enums.Sabor.Naranja)
            {
                PrecioFinal += PrecioBase * 0.03;
            }
            return PrecioFinal;
        }
        public override bool EsValido()
        {
            if (AptoDiabeticos == true && AptoDiabeticos == false)
            {
                return false;
            }
            if (Colorantes == true && Colorantes == false)
            {
                return false;
            }
            return true;
        }
    }
}
