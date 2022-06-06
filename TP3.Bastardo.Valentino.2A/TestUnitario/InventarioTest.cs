using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventarioNS;

namespace TestUnitario
{
    [TestClass]
    public class InventarioTest
    {
        [TestMethod]
        public void Inventario_InstanciaLaListaAlSerCreado()
        {
            // arrange
            Inventario inv;
            // act
            inv = new Inventario("Prueba");
            // arrange
            Assert.IsNotNull(inv.Lista);
        }
        [TestMethod]
        public void Inventario_LanzaExcepcionAlCargarDosProductosIguales()
        {
            //arrange
            Inventario inv;
            Videojuego ps2x;
            Videojuego ps2y;
            //act
            inv = new Inventario();
            ps2x = new Videojuego("Resident Evil 4", 60, 12, TipoConsola.PS2, Genero.Otro);
            ps2y = new Videojuego("Resident Evil 4", 60, 12, TipoConsola.PS2, Genero.Otro);

            inv += ps2x;
            
            //assert
            Assert.ThrowsException<InventarioException>(() => inv += ps2y);

        }
        [TestMethod]
        public void Inventario_CalculaBienLasGanancias()
        {
            //arrange
            Inventario inv;
            Videojuego x;
            GameCube y;
            float resultadoEsperado;
            float resultado;
            //act
            resultadoEsperado = (float)(60 * 5) + (500 * 10);
            inv = new Inventario();
            x = new Videojuego("Resident Evil 4", 60, 5, TipoConsola.PS2, Genero.Otro);
            y = new GameCube("GameCube Rosa", 500, 10,Color.Rosa);
            
            inv += x;
            inv += y;

            resultado = inv.GananciasTotales;
            //assert
            Assert.IsTrue(resultado == resultadoEsperado);

        }
    }
}
