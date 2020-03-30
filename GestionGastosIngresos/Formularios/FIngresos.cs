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
    public partial class FIngresos : Form
    {
        public int IdIngreso;
        public bool Editar;
        public string tipo;
        public FIngresos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FIngresos_Load(object sender, EventArgs e)
        {
            btnGuardar.Text = Editar ? "Actualizar" : "Agregar";
            ListarCombo();

            if (Editar)
            {
                cbTipoIngreso.Text = tipo;
            }
        }

        private void ListarCombo()
        {
            Tipo_ingreso.ListarCombo(cbTipoIngreso);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!Agregar()) return;
            finalizar();
            
        }

        private void finalizar()
        {
            txtDescripcion.Text = "";
            txtMonto.Text = "0";
            cbTipoIngreso.SelectedIndex = -1;
             this.Editar = false;
        }

        private bool Agregar()
        {
            Ingreso ingreso = new Ingreso
            {
                descripcion = txtDescripcion.Text.Trim(),
                IdIngreso = this.IdIngreso,
                IdTipoIngreso = Convert.ToInt32(cbTipoIngreso.SelectedValue),
                fecha = dtpFecha.Value,
                monto = Convert.ToDecimal(txtMonto.Text)
            };

            if(Ingreso.Agregar(ingreso, Editar))
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

        private void btnAgregarTipoIngreso_Click(object sender, EventArgs e)
        {
            FTipoIngreso fTipoIngreso = new FTipoIngreso();
            fTipoIngreso.ShowDialog();
        }

        private void cbTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FIngresos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbTipoIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
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
