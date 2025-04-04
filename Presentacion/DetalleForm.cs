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
            msm.Theme = MaterialSkinManager.Themes.DARK;
            this.articulo = articulo;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetalleForm_Load(object sender, EventArgs e)
        {
            //cmbMarca.ValueMember = "Id";
            //cmbMarca.DisplayMember = "Descripcion";

            //cmbCategoria.ValueMember = "Id";
            //cmbCategoria.DisplayMember = "Descripcion";

            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString();
            lblImagen.Text = articulo.ImagenUrl;
            pbxArticulo.Load(articulo.ImagenUrl);
        }
    }
}
