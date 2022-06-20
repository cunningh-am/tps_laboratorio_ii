using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventarioNS
{
    public class AccesoSql
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static AccesoSql()
        {
            AccesoSql.cadena_conexion = @"Server=.;Database=Productos_TP4;Trusted_Connection=True;";

        }
        public AccesoSql()
        {
            this.conexion = new SqlConnection(AccesoSql.cadena_conexion);
        }
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
        public async Task<List<Producto>> ObtenerListaProductos()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Productos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                lista = await Task.Run(() =>
                {
                    while (lector.Read())
                    {
                        switch ((int)(lector["clase"]))
                        {
                            case 0:
                                Videojuego vid = new Videojuego(Convert.ToInt32(lector["id"]),
                                                               lector["nombre"].ToString(),
                                                    Convert.ToDouble(lector["precio"].ToString()),
                                                Convert.ToInt32(lector["vendidas"]),
                                                (TipoConsola)Convert.ToInt32(lector["consola"]),
                                                (Genero)Convert.ToInt32(lector["genero"]));
                                lista.Add(vid);
                                break;
                            case 1:
                                PlayStation2 play = new PlayStation2(Convert.ToInt32(lector["id"]),
                                                   lector["nombre"].ToString(),
                                                Convert.ToDouble(lector["precio"].ToString()),
                                                Convert.ToInt32(lector["vendidas"]),
                                                (Color)Convert.ToInt32(lector["color"]));
                                lista.Add(play);
                                break;
                            case 2:
                                GameCube gcube = new GameCube(Convert.ToInt32(lector["id"]),
                                                lector["nombre"].ToString(),
                                                Convert.ToDouble(lector["precio"].ToString()),
                                                Convert.ToInt32(lector["vendidas"]),
                                                (Color)Convert.ToInt32(lector["color"]));
                                lista.Add(gcube);
                                break;
                        }
                    }

                    lector.Close();
                    return lista;
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
        public bool AgregarProducto(Producto prod)
        {
            bool rta = true;
            try
            {
                this.conexion.Open();
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = $"INSERT INTO Productos (clase,nombre,precio,vendidas,consola,color,genero) VALUES (@clase,@nombre,@precio,@vendidas,@consola,@color,@genero)";
                this.comando.Parameters.AddWithValue("@nombre", prod.Nombre.ToString());
                this.comando.Parameters.AddWithValue("@precio", prod.Precio);
                this.comando.Parameters.AddWithValue("@vendidas", Convert.ToInt32(prod.UnidadesVendidas));
                if (prod is Videojuego)
                {
                    this.comando.Parameters.AddWithValue("@clase", 0);
                    this.comando.Parameters.AddWithValue("@color", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@consola", Convert.ToInt32(((Videojuego)prod).ParaConsola));
                    this.comando.Parameters.AddWithValue("@genero", Convert.ToInt32(((Videojuego)prod).Genero));
                }
                else if (prod is PlayStation2)
                {
                    this.comando.Parameters.AddWithValue("@clase", 1);
                    this.comando.Parameters.AddWithValue("@consola", 0);
                    this.comando.Parameters.AddWithValue("@color", Convert.ToInt32(((PlayStation2)prod).Color));
                    this.comando.Parameters.AddWithValue("@genero", DBNull.Value);
                }
                else if (prod is GameCube)
                {
                    this.comando.Parameters.AddWithValue("@clase", 2);
                    this.comando.Parameters.AddWithValue("@consola", 1);
                    this.comando.Parameters.AddWithValue("@color", Convert.ToInt32(((GameCube)prod).Color));
                    this.comando.Parameters.AddWithValue("@genero", DBNull.Value);
                }



                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
        public bool EliminarProducto(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM Productos ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

    }
}
