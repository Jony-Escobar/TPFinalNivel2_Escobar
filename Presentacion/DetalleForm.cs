using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo;

namespace Presentacion
{
    public partial class DetalleForm : MaterialForm
    {
        private Articulo articulo = null;
        public DetalleForm(Articulo articulo)
        {
            InitializeComponent();

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            this.articulo = articulo;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetalleForm_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            //Si la descripcion es nula o vacia
            if (string.IsNullOrEmpty(articulo.Descripcion))
            {
                lblDescripcion.Text = "Sin descripción";
            }
            else
            {
                lblDescripcion.Text = articulo.Descripcion;
            }
            //lblDescripcion.Text = articulo.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString();
            CargarImagen(articulo.ImagenUrl);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://i0.wp.com/stretchingmexico.com/wp-content/uploads/2024/07/placeholder.webp?w=1200&quality=80&ssl=1");
            }
        }
    }
}
