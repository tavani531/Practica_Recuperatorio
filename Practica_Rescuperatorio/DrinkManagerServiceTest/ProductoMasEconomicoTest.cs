using NUnit.Framework;
using System.Collections.Generic;
using DrinkManagerService;

namespace DrinkManagerServiceTest
{
    public class ProfuctoMasEconomicoTest
    {
        [Test]
        public void ProductoMasEconomico()
        {
            var plataforma = new Plataforma();
            var bebida1 = new BebidasSinAlcohol
            {
                Nombre = "Agua",
                Marca = "Eco",
                PrecioBase = 50,
                Volumen = 500,
                Sabor = Enums.Sabor.SinSabor,
                AptoDiabeticos = false,
                Colorantes = false,
                Gasificada = false
            };

            var bebida2 = new BebidasSinAlcohol
            {
                Nombre = "Jugo Naranja",
                Marca = "Citric",
                PrecioBase = 100,
                Volumen = 500,
                Sabor = Enums.Sabor.Naranja,
                AptoDiabeticos = false,
                Colorantes = false,
                Gasificada = false
            };

            plataforma.RegistrarBebida(bebida1);
            plataforma.RegistrarBebida(bebida2);

            var codigos = new List<int> { bebida1.Codigo, bebida2.Codigo };

            var bebidaMasBarata = plataforma.BebidaMasEconomica(codigos);

            Assert.IsNotNull(bebidaMasBarata);
            Assert.AreEqual("Agua", bebidaMasBarata.Nombre);
        }
    }
}