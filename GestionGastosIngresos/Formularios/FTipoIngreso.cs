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

namespace GestionGastosIngresos
{
    public partial class FTipoIngreso : Form
    {
        public bool editar;
        public int IdTipoIngreso;

        public FTipoIngreso()
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

        private void limpiar()
        {
            txtTipoIngreso.Text = "";
            editar = false;
        }

        private bool guardar()
        {
            Tipo_ingreso tipo_Ingreso = new Tipo_ingreso
            {
                Denominacion = txtTipoIngreso.Text,
                IdTipoIngreso = IdTipoIngreso
            };

            return Tipo_ingreso.Guardar(tipo_Ingreso, editar);
        }

        private bool validacion()
        {
            if (string.IsNullOrWhiteSpace(txtTipoIngreso.Text)) {
                MessageBox.Show("Ingresar Denominacion");
                return false;
            } 
            return true;
        }

        private void ListarGrid()
        {
           dataListado.DataSource= Tipo_ingreso.Listar();
            DbDatos.OcultarId(dataListado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editar = true;
            this.IdTipoIngreso = Convert.ToInt32(dataListado.CurrentRow.Cells["IdTipoIngreso"].Value);
            txtTipoIngreso.Text = dataListado.CurrentRow.Cells["Denominacion"].Value.ToString();
        }
    }
}
