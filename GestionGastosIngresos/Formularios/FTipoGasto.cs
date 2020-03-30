using GestionGastosIngresos.Clases;
using GestionGastosIngresos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGastosIngresos.Formularios
{
    public partial class FTipoGasto : Form
    {
        public bool editar;
        public int IdTipoGasto;

        public FTipoGasto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validacion()) return;
            if (!guardar()) return;

            finalizar();
        }

        private void finalizar()
        {
            ListarGrid();
            limpiar();
        }

        private void ListarGrid()
        {
            dataListado.DataSource = Tipo_gasto.Listar();
            DbDatos.OcultarId(dataListado);
        }

        private void limpiar()
        {
            txtTipogasto.Text = "";
            editar = false;
        }

        private bool guardar()
        {
            Tipo_gasto tipo_gasto = new Tipo_gasto
            {
                Denominacion = txtTipogasto.Text,
                IdTipoGasto = IdTipoGasto
            };

            return Tipo_gasto.Agregar(tipo_gasto, editar);
        }

        private bool validacion()
        {
            if (string.IsNullOrWhiteSpace(txtTipogasto.Text))
            {
                MessageBox.Show("Ingresar Denominacion");
                return false;
            }
            return true;
        }

        private void FTipoGasto_Load(object sender, EventArgs e)
        {
            this.ListarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editar = true;
            this.IdTipoGasto = Convert.ToInt32(dataListado.CurrentRow.Cells["IdTipoGasto"].Value);
            txtTipogasto.Text = dataListado.CurrentRow.Cells["Denominacion"].Value.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
