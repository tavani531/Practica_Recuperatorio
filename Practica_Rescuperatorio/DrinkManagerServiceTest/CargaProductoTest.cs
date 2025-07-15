using NUnit.Framework;
using System.Collections.Generic;
using DrinkManagerService;

namespace DrinkManagerServiceTest
{
    public class CargaProductoTest
    {
        [Test]
        public void CargarProducto()
        {
            var plataforma = new Plataforma();

            var bebida = new BebidasSinAlcohol
            {
                Nombre = "Gaseosa Coca Cola",
                Marca = "Coca-Cola",
                PrecioBase = 100,
                Volumen = 500,
                Sabor = Enums.Sabor.Cola,
                AptoDiabeticos = true,
                Colorantes = false,
                Gasificada = true
            };

            bool resultado = plataforma.RegistrarBebida(bebida);
            var lista = plataforma.ListaBebidasExistentes();

            Assert.IsTrue(resultado);
            Assert.AreEqual(1, lista.Count);
            Assert.IsTrue(lista[0].Contains("Gaseosa Coca Cola"));
        }

       
    }
}