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
            catch (Exception ex)
            {
                pbxArticulo.Load("https://i0.wp.com/stretchingmexico.com/wp-content/uploads/2024/07/placeholder.webp?w=1200&quality=80&ssl=1");
            }
        }
    }
}
