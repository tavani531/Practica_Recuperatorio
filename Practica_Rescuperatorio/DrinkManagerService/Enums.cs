using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class Enums
    {
        public enum TipoBebida
        {
            Vino,
            Cerveza,
            Wisky
        }
        public enum TipoEnvase
        {
            Vidrio,
            Plastico,
            Lata
        }
        public enum Sabor
        {
            SinSabor,
            LimaLimon,
            Cola,
            Naranja
        }
        public enum NivelAzucar
        { 
            Bajo,
            Medio,
            Alto
        }
    }
}
