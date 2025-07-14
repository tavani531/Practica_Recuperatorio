using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class BebidasEnergizantes:Bebidas
    {
        public bool AptaDeportistas { get; set; }
        public Enums.NivelAzucar NivelAzucar { get; set; }

        public override double CalcularPrecioFinal()
        {
            PrecioFinal = PrecioBase;

            if (NivelAzucar == Enums.NivelAzucar.Medio)
            {
                PrecioFinal += PrecioBase * 0.05;
            }
            else
            {
                PrecioFinal += PrecioBase * 0.02;
            }
            return PrecioFinal;
        }
        public override bool EsValido()
        {
            if(AptaDeportistas== true && AptaDeportistas == false)
            {
                return false; 
            }
            if(NivelAzucar != Enums.NivelAzucar.Bajo && NivelAzucar != Enums.NivelAzucar.Medio && NivelAzucar!= Enums.NivelAzucar.Alto)
            {
                return false;
            }
            return true;
        }
    }
}
