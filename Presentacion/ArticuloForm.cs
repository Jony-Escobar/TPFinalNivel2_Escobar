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
using Logica;

namespace Presentacion
{
    public partial class ArticuloForm : MaterialForm
    {
        public ArticuloForm()
        {
            InitializeComponent();

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloLogica logica = new ArticuloLogica();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                articulo.Marca = cmbMarca.SelectedItem as Marca;
                articulo.Categoria = cmbCategoria.SelectedItem as Categoria;
                articulo.ImagenUrl = txtImagenUrl.Text;

                logica.Agregar(articulo);
                MessageBox.Show("Artículo agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ArticuloForm_Load(object sender, EventArgs e)
        {
            MarcaLogica marcaLogica = new MarcaLogica();
            CategoriaLogica categoriaLogica = new CategoriaLogica();
            try
            {
                cmbMarca.DataSource = marcaLogica.Listar();
                cmbCategoria.DataSource = categoriaLogica.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
