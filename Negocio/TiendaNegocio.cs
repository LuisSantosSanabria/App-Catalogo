﻿using System;
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
                comando.CommandText = "Select A.Id,A.Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion as Categoria, M.Descripcion as Marca From ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id = A.IdMarca\r\n"; // la consulta que hago
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
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                   // aux.Tipo = new Elemento(); // para que no me referencia nula
                    //aux.Tipo.Descripcion = (string)lector["Tipo"]; //tipo no va tener una instancia
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)lector["Marca"];

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
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "')");
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
        public void modificar(Tienda modificar)
        {

        }
    }
}