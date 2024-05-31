using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // puedo crear objetos Db
using Dominio;

namespace Negocio

{
    public class TiendaNegocio //clase de acceso a datos para los articulos
    {
        // funcion que lee registross de la BD
        public List<Tienda> listar()
        {
            List<Tienda> lista = new List<Tienda>(); // objetos
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; // se guarda la lecturas

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";//a donde me vpy a conectar
                comando.CommandType = System.Data.CommandType.Text; //que tipo es x ej: txt
                comando.CommandText = "SELECT A.Id, A.Codigo, Nombre, A.Descripcion, A.Precio, A.ImagenUrl, C.Id AS IdCategoria, C.Descripcion AS Categoria, M.Id AS IdMarca, M.Descripcion AS Marca FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE C.Id = A.IdCategoria AND M.Id = A.IdMarca"; // la consulta que hago
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); //tabla virtual con puntero

                //para leer el LECTOR
                while (lector.Read()) //se fija si hay una lectura e ingresa al while con lector apuntando al primer registro
                {
                    Tienda aux = new Tienda();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"]; // es lo mismo que la linea de arriba pero mas practico
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (lector["Precio"] != DBNull.Value)
                    {
                        aux.precio = Convert.ToDecimal(lector["Precio"]);
                    }
                    else
                    {
                        aux.precio = 0;
                    }

                    // para la exepciones de las imagenes
                    if (!(lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)lector["ImagenUrl"]; // si no es dbnull trata de leerlo
                    // si la columna es Null no hay problema, Si es NOt NUll si hago estas lineas

                    // para que no me referencia nula
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion= (string)lector["Categoria"];

                    lista.Add(aux); //agreso ese articulo a la lista
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public void agregar(Tienda nuevo)
        {
            //que necesito para conectar a la base de datos
            AccesoDatos datos = new AccesoDatos();
            //no va devolcer registros va insertar registros
            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria,ImagenUrl,Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', @idMarca, @idCategoria, @ImagenUrl, @Precio)");
                datos.setearParanetros("@idMarca", nuevo.Marca.Id);
                datos.setearParanetros("@idCategoria", nuevo.Categoria.Id);
                datos.setearParanetros("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParanetros("@Precio", nuevo.precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Tienda modi)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, ImagenUrl = @img, IdMarca = @IdMarca, IdCategoria = @IdCategoria Where Id = @Id");
                datos.setearParanetros("@codigo", modi.Codigo);
                datos.setearParanetros("@nombre", modi.Nombre);
                datos.setearParanetros("@descripcion", modi.Descripcion);
                datos.setearParanetros("@precio", modi.precio);
                datos.setearParanetros("@img", modi.ImagenUrl);
                datos.setearParanetros("@IdMarca", modi.Marca.Id);
                datos.setearParanetros("@IdCategoria", modi.Categoria.Id);
                datos.setearParanetros("@Id", modi.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void  eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParanetros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
