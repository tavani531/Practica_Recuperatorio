namespace DrinkManagerService
{
    public class Plataforma
    {
        public List<Bebidas> Bebidas = new List<Bebidas>();
        public List<VentasRealizadas> Ventas = new List<VentasRealizadas>();

        public void RegistrarBebida(Bebidas bebida)
        {
            if (bebida.EsValido() == true)
            {
                Bebidas.Add(bebida);
            }
        }
        public (bool, string) RegistrarVenta(int codigo, int cantidad)
        {
            var resultadoValidacion = new ResultadoVenta(Bebidas).BebidaExiste(codigo, cantidad);
            if (resultadoValidacion.Item1 == false)
            {
                return (false, resultadoValidacion.Item2);
            }
            else
            {
                var bebida = Bebidas.FirstOrDefault(b => b.Codigo == codigo);
                var venta = new VentasRealizadas(bebida, cantidad);
                Ventas.Add(venta);
                return (true, resultadoValidacion.Item2);
            }

        }
        public List<string> ListaBebidasExistentes()
        {
            return Bebidas.Where(b => b.EsValido())
                          .Select(b => b.MostrarInformacion())
                          .ToList();
        }
        public Bebidas BebidaMasEconomica(List<int> Codigos)
        {
            return Bebidas.Where(b => Codigos.Contains(b.Codigo))
                          .OrderBy(b => b.PrecioFinal)
                          .FirstOrDefault();

        }
        
        
    }
}
