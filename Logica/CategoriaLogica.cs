using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Logica
{
    public class CategoriaLogica
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    datos.SetearConsulta(@"SELECT id, descripcion FROM CATEGORIAS");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Categoria aux = new Categoria();
                        {
                            aux.Id = (int)datos.Lector["id"];
                            aux.Descripcion = (string)datos.Lector["descripcion"];
                        }

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
