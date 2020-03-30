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
    public partial class FGastos : Form
    {
        public int IdGasto;
        public bool Editar;
        public string tipo;
        public FGastos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Guardar()) return;
            finalizar();
        }

        private void finalizar()
        {
            txtDescripcion.Text = "";
            txtMonto.Text = "0";
            cbTipoGasto.SelectedIndex = -1;
            this.Editar = false;
        }

        private bool Guardar()
        {
            Gasto gasto = new Gasto
            {
                descripcion = txtDescripcion.Text.Trim(),
                IdGasto = this.IdGasto,
                IdTipoGasto = Convert.ToInt32(cbTipoGasto.SelectedValue),
                fecha = dtpFecha.Value,
                monto = Convert.ToDecimal(txtMonto.Text)
            };

            if (Gasto.Agregar(gasto, Editar))
            {
                MessageBox.Show("Operacion exitosa");
                return true;
            }
            else
            {
                MessageBox.Show("Operacion fallida");
                return false;
            }
            
        }

        private void FGastos_Load(object sender, EventArgs e)
        {
            btnGuardar.Text = Editar ? "Actualizar" : "Agregar";
            ListarCombo();

            if (Editar)
            {
                cbTipoGasto.Text = tipo;
            }
        }

        private void ListarCombo()
        {
            Tipo_gasto.ListarCombo(cbTipoGasto);
        }

        private void btnAgregarTipoGasto_Click(object sender, EventArgs e)
        {
            FTipoGasto frm = new FTipoGasto();
            frm.ShowDialog();
        }

        private void cbTipoGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ListarCombo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            finalizar();
        }
    }
}
