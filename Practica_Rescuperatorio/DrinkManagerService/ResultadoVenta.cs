using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkManagerService
{
    public class ResultadoVenta
    {
        private List<Bebidas> Bebidas;
        public ResultadoVenta(List<Bebidas>bebidas)
        {
            Bebidas = bebidas;
        }

        public (bool, string) BebidaExiste(int codigoBebida,int cantidad)
        {
            var bebida = Bebidas.FirstOrDefault(b => b.Codigo == codigoBebida);
            if (bebida == null)
            {
                return (false,"La bebida elegida no existe");
            }
            if (cantidad > 5)
            {
                return (false,"La cantidad agregada es mayor a 5 unidades");
            }
            return (true,"Venta cargada con éxito");
        }
    }
}
