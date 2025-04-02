using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Logica
{
    public class MarcaLogica
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();

            AccesoDatos datos = new AccesoDatos();
            {
                try
                {
                    datos.SetearConsulta(@"SELECT id, descripcion FROM MARCAS");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Marca aux = new Marca();
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
