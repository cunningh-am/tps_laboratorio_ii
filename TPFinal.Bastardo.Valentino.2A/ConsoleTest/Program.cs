using System;
using InventarioNS;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayStation2 play2roja = new PlayStation2("play2roja", 50.99f, 0, Color.Rojo);
            Videojuego re4 = new Videojuego("RESIDENT EVIL 4", 50, 0, TipoConsola.GameCube, Genero.Accion);
          //  Videojuego re4ps2 = new Videojuego("RESIDENT EVIL 4", 10, 0, TipoConsola.PS2, Genero.Accion);
          //  GameCube gcR = new GameCube("GameCube", 2.3f, 2, Color.Rojo);
            GameCube gcRR = new GameCube("GameCube", 2.3f, 2, Color.Negro);
            //  Cliente german = new Cliente("German", "43921388");

            //  Inventario inventario = new Inventario("Gamestop");

            //  inventario += re4;
            //  inventario += re4ps2;
            //  inventario += gcR;
            //  inventario += gcRR;
            ////  german.AgregarAlPedido(re4);

            //  Console.WriteLine(german);
            //  Console.WriteLine(inventario);

            ////  inventario.ConcretarVenta(german);

            //  Console.WriteLine(german);
            //  Console.WriteLine(inventario);


        }
    }
}
