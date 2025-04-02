using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using Modelo;

namespace Logica
{
    public class ArticuloLogica
    {
        public void Agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.SetearParametro("IdMarca", articulo.Marca.Id);
                datos.SetearParametro("IdCategoria", articulo.Categoria.Id);
                datos.SetearParametro("Codigo", articulo.Codigo);
                datos.SetearParametro("Nombre", articulo.Nombre);
                datos.SetearParametro("Descripcion", articulo.Descripcion);
                datos.SetearParametro("ImagenUrl", articulo.ImagenUrl);
                datos.SetearParametro("Precio", articulo.Precio);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    datos.SetearConsulta(@"SELECT Codigo, Nombre, ARTICULOS.Descripcion, 
                                          MARCAS.Descripcion as Marca, 
                                          CATEGORIAS.Descripcion as Categoria, 
                                          ImagenUrl, Precio 
                                   FROM ARTICULOS 
                                   LEFT JOIN MARCAS ON ARTICULOS.IdMarca = MARCAS.Id 
                                   LEFT JOIN CATEGORIAS ON ARTICULOS.IdCategoria = CATEGORIAS.Id");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Articulo aux = new Articulo
                        {
                            Codigo = datos.Lector["Codigo"] is DBNull ? "" : datos.Lector["Codigo"].ToString(),
                            Nombre = datos.Lector["Nombre"] is DBNull ? "" : datos.Lector["Nombre"].ToString(),
                            Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : datos.Lector["Descripcion"].ToString(),
                            Marca = new Marca
                            {
                                Descripcion = datos.Lector["Marca"] is DBNull ? "" : datos.Lector["Marca"].ToString()
                            },
                            Categoria = new Categoria
                            {
                                Descripcion = datos.Lector["Categoria"] is DBNull ? "" : datos.Lector["Categoria"].ToString()
                            },
                            ImagenUrl = datos.Lector["ImagenUrl"] is DBNull ? "" : datos.Lector["ImagenUrl"].ToString(),
                            Precio = datos.Lector["Precio"] is DBNull ? 0 : Convert.ToDecimal(datos.Lector["Precio"])
                        };                      
                        lista.Add(aux);                       
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }            
        }
    }
}
