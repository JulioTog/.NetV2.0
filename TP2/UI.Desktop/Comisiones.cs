using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Negocio;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            ComisionesLogic cl = new ComisionesLogic();
            try
            {
                this.dgvComisiones.DataSource = cl.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionesDesktop formComision = new ComisionesDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDesktop formComision = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formComision.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDesktop formComision = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Baja);
                formComision.ShowDialog();
                this.Listar();
            }
        }
    }
}
