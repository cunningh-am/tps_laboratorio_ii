using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventarioNS
{
    public static class Archivo
    {
        static string ruta;

        static Archivo()
        {
             // ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion\";
        }
        public static void Escribir(string datos)
        {
            string nombreArchivo = ruta + "Archivos_01_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if(!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using(StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.WriteLine(datos);
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error en el archivo ubicado en {ruta}", ex);
            }
        }
    }
}
