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
        private Articulo articulo = null;
        public ArticuloForm()
        {
            InitializeComponent();

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
        }
        public ArticuloForm(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";

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
            ArticuloLogica logica = new ArticuloLogica();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                articulo.Marca = cmbMarca.SelectedItem as Marca;
                articulo.Categoria = cmbCategoria.SelectedItem as Categoria;
                articulo.ImagenUrl = txtImagenUrl.Text;

                if (articulo.Id != 0)
                {
                    logica.Modificar(articulo);
                    MessageBox.Show("Artículo modificado correctamente");
                }
                else
                {
                    logica.Agregar(articulo);
                    MessageBox.Show("Artículo agregado correctamente");
                }

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
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";
                
                cmbCategoria.DataSource = categoriaLogica.Listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";

                pbxArticulo.Load("https://i0.wp.com/stretchingmexico.com/wp-content/uploads/2024/07/placeholder.webp?w=1200&quality=80&ssl=1");

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    cmbMarca.SelectedValue = articulo.Marca.Id;
                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    CargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtImagenUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImagenUrl.Text);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Load("https://i0.wp.com/stretchingmexico.com/wp-content/uploads/2024/07/placeholder.webp?w=1200&quality=80&ssl=1");
            }
        }
    }
}
