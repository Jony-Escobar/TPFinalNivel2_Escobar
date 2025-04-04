using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            msm.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            cmbCampo.Items.Add("Codigo");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Marca");
            cmbCampo.Items.Add("Categoria");
            cmbCampo.Items.Add("Precio");
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
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ArticuloForm editar = new ArticuloForm(seleccionado);
            editar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloLogica logica = new ArticuloLogica();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    logica.Eliminar(seleccionado.Id);
                    Cargar();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Filtro avanzado
            ArticuloLogica logica = new ArticuloLogica();
            try
            {
                if (cmbCampo.SelectedItem == null || cmbCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un campo y un criterio para filtrar.","Atención",MessageBoxButtons.OK , MessageBoxIcon.Warning);
                    return;
                }
                string campo = cmbCampo.SelectedItem?.ToString() ?? "";
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
    }
}
