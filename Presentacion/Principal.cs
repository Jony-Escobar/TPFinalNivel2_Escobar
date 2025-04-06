using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo;

namespace Presentacion
{
    public partial class Principal : MaterialForm
    {
        private List<Articulo> listaArticulos;
        public Principal()
        {
            InitializeComponent();

            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            cmbCriterio.Enabled = false;
            btnBuscar.Enabled = false;

            cmbCampo.DisplayMember = "Key";
            cmbCampo.ValueMember = "Value";

            cmbCampo.Items.Add(new KeyValuePair<string, string>("Código", "Codigo"));
            cmbCampo.Items.Add(new KeyValuePair<string, string>("Nombre", "Nombre"));
            cmbCampo.Items.Add(new KeyValuePair<string, string>("Marca", "MARCAS.Descripcion"));
            cmbCampo.Items.Add(new KeyValuePair<string, string>("Categoría", "CATEGORIAS.Descripcion"));
            cmbCampo.Items.Add(new KeyValuePair<string, string>("Precio", "Precio"));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloForm alta = new ArticuloForm();
            alta.ShowDialog();
            Cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
        }

        private void Cargar()
        {
            ArticuloLogica logica = new ArticuloLogica();
            try
            {
                dgvArticulos.AutoGenerateColumns = false;

                listaArticulos = logica.Listar();

                dgvArticulos.DataSource = listaArticulos;
                pbxArticulo.ImageLocation = listaArticulos[0].ImagenUrl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        private void btnEditar_Click(object sender, EventArgs e)
        {           
            if (ValidarSeleccionado())
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloForm editar = new ArticuloForm(seleccionado);
                editar.ShowDialog();
                Cargar();
            }                       
        }

        private bool ValidarSeleccionado()
        {
            //Validar que haya un artículo seleccionado
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionado()) {
                ArticuloLogica logica = new ArticuloLogica();
                Articulo seleccionado;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        logica.Eliminar(seleccionado.Id);
                        MessageBox.Show("Artículo eliminado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusquedaRapida.Text = "";
            if (cmbCampo.SelectedItem != null)
            {
                cmbCriterio.Enabled = true;
                string opcion = ((KeyValuePair<string, string>)cmbCampo.SelectedItem).Key;

                if (opcion == "Precio")
                {
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Menor a");
                    cmbCriterio.Items.Add("Mayor a");
                    cmbCriterio.Items.Add("Igual a");
                }
                else
                {
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Comienza con");
                    cmbCriterio.Items.Add("Termina con");
                    cmbCriterio.Items.Add("Contiene");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCriterio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCriterio.SelectedItem.ToString() == "Menor a" || cmbCriterio.SelectedItem.ToString() == "Mayor a" || cmbCriterio.SelectedItem.ToString() == "Igual a")
            {
                decimal valor;
                if (!decimal.TryParse(txtBuscar.Text, out valor))
                {
                    MessageBox.Show("Ingrese un valor numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //Filtro avanzado
            ArticuloLogica logica = new ArticuloLogica();
            try
            {
                if (cmbCampo.SelectedItem == null || cmbCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un campo y un criterio para filtrar.","Atención",MessageBoxButtons.OK , MessageBoxIcon.Warning);
                    return;
                }
                string campo = ((KeyValuePair<string, string>)cmbCampo.SelectedItem).Value;
                string criterio = cmbCriterio.SelectedItem?.ToString() ?? "";
                string valor = txtBuscar.Text;
                dgvArticulos.DataSource = logica.Filtrar(campo, criterio, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            DetalleForm detalle = new DetalleForm ((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
            detalle.ShowDialog();
            Cargar();
        }

        private void txtBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            //Filtro rapido
            List<Articulo> listaFiltrada;
            string filtro = txtBusquedaRapida.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.Where(x =>
                    x.Nombre.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Codigo.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Precio.ToString().Contains(filtro)
                ).ToList();
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }

        private void txtBusquedaRapida_Enter(object sender, EventArgs e)
        {
            //Limpiar campos de busqueda avanzada
            txtBuscar.Text = "";
            txtBusquedaRapida.Text = "";
            cmbCampo.SelectedItem = null;
            cmbCriterio.SelectedItem = null;
            cmbCampo.Hint = "Campo";
            cmbCriterio.Hint = "Criterio";
            cmbCriterio.Enabled = false;
            btnBuscar.Enabled = false;
            Cargar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            // Limpiar campos de busqueda rapida  
            txtBusquedaRapida.Text = "";
            btnBuscar.Enabled = true;
        }
    }
}
