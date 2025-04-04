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

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.SetearParametro("Id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> Filtrar(string campo, string criterio, string valor)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Codigo, Nombre, ARTICULOS.Descripcion, MARCAS.Descripcion as Marca, CATEGORIAS.Descripcion as Categoria, ImagenUrl, Precio, ARTICULOS.Id as Id, MARCAS.Id as IdMarca, CATEGORIAS.Id as IdCategoria FROM ARTICULOS LEFT JOIN MARCAS ON ARTICULOS.IdMarca = MARCAS.Id LEFT JOIN CATEGORIAS ON ARTICULOS.IdCategoria = CATEGORIAS.Id WHERE ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Menor a":
                            consulta += "Precio < " + valor;
                            break;
                        case "Mayor a":
                            consulta += "Precio > " + valor;
                            break;
                        case "Igual a":
                            consulta += "Precio = " + valor;
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += campo + " LIKE '" + valor + "%'";
                            break;
                        case "Termina con":
                            consulta += campo + " LIKE '%" + valor + "'";
                            break;
                        case "Contiene":
                            consulta += campo + " LIKE '%" + valor + "%'";
                            break;
                    }
                }

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        Codigo = datos.Lector["Codigo"] is DBNull ? "" : datos.Lector["Codigo"].ToString(),
                        Nombre = datos.Lector["Nombre"] is DBNull ? "" : datos.Lector["Nombre"].ToString(),
                        Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : datos.Lector["Descripcion"].ToString(),
                        Marca = new Marca
                        {
                            Id = (int)datos.Lector["IdMarca"],
                            Descripcion = datos.Lector["Marca"] is DBNull ? "" : datos.Lector["Marca"].ToString()
                        },
                        Categoria = new Categoria
                        {
                            Id = (int)datos.Lector["IdCategoria"],
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
                                              ImagenUrl, Precio,
										      ARTICULOS.Id as Id, MARCAS.Id as IdMarca, CATEGORIAS.Id as IdCategoria
                                           FROM ARTICULOS
                                           LEFT JOIN MARCAS ON ARTICULOS.IdMarca = MARCAS.Id
                                           LEFT JOIN CATEGORIAS ON ARTICULOS.IdCategoria = CATEGORIAS.Id");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Articulo aux = new Articulo
                        {
                            Id = (int)datos.Lector["Id"],
                            Codigo = datos.Lector["Codigo"] is DBNull ? "" : datos.Lector["Codigo"].ToString(),
                            Nombre = datos.Lector["Nombre"] is DBNull ? "" : datos.Lector["Nombre"].ToString(),
                            Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : datos.Lector["Descripcion"].ToString(),
                            Marca = new Marca
                            {
                                Id = (int)datos.Lector["IdMarca"],
                                Descripcion = datos.Lector["Marca"] is DBNull ? "" : datos.Lector["Marca"].ToString()
                            },
                            Categoria = new Categoria
                            {
                                Id = (int)datos.Lector["IdCategoria"],
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

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio WHERE Id = @Id");
                datos.SetearParametro("Id", articulo.Id);
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
    }
}
