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
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        public ArticuloForm(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            //Si todo es correcto, guardo el artículo
            if (ValidarCampos())
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
        }

        private bool ValidarCampos()
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.Hint = "Ingrese un código";
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Hint = "Ingrese un nombre";
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtPrecio.Hint = "Ingrese un precio";
                txtPrecio.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El campo Precio debe ser un número válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El campo Precio debe ser mayor a cero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (cmbMarca.SelectedItem == null)
            {
                cmbMarca.Hint = "Seleccione una marca";
                cmbMarca.Focus();
                return false;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                cmbCategoria.Hint = "Seleccione una categoría";
                cmbCategoria.Focus();
                return false;
            }

            return true;
            //if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            //{
            //    MessageBox.Show("El campo Código es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCodigo.Focus();
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(txtNombre.Text))
            //{
            //    MessageBox.Show("El campo Nombre es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNombre.Focus();
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            //{
            //    MessageBox.Show("El campo Precio es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPrecio.Focus();
            //    return;
            //}
            //if (cmbMarca.SelectedItem == null)
            //{
            //    MessageBox.Show("El campo Marca es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cmbMarca.Focus();
            //    return;
            //}
            //if (cmbCategoria.SelectedItem == null)
            //{
            //    MessageBox.Show("El campo Categoría es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cmbCategoria.Focus();
            //    return;
            //}
            //if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            //{
            //    MessageBox.Show("El campo Precio debe ser un número válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPrecio.Focus();
            //    return;
            //}
            //if (precio <= 0)
            //{
            //    MessageBox.Show("El campo Precio debe ser mayor a cero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPrecio.Focus();
            //    return;
            //}
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
                    //Editar
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    cmbMarca.SelectedValue = articulo.Marca.Id;
                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    CargarImagen(articulo.ImagenUrl);
                }
                else
                {
                    //Agregar, muestro solo el hint
                    cmbMarca.SelectedIndex = -1;
                    cmbCategoria.SelectedIndex = -1;
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            archivo.Title = "Seleccione una imagen";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna imagen");
            }
        }
    }
}
