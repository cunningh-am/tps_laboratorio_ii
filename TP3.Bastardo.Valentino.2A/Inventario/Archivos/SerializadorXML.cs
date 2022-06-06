using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace InventarioNS
{
    public static class SerializadorXML<T>
    {
        static string ruta;

        static SerializadorXML()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion-XML\";
        }

        public static void Escribir(T datos, string nombre)
        {
            string nombreArchivo = ruta + "SerializacionXML_" + nombre  + ".xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo ubicado en {ruta}", ex);
            }

        }
        public static T Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datos = default;
            try
            {

                if (Directory.Exists(ruta))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnLaRuta = Directory.GetFiles(ruta);
                    foreach (string ruta in archivosEnLaRuta)
                    {
                        if (ruta.Contains(nombre))
                        {
                            archivo = ruta;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo ubicado en {ruta}", ex);
            }

        }
    }
}
