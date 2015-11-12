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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            EspecialidadesLogic el = new EspecialidadesLogic();
            try
            {
                this.dgvEspecialidades.DataSource = el.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Especialidades_Load(object sender, EventArgs e)
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
            EspecialidadesDesktop formEspecialidades = new EspecialidadesDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidades.ShowDialog();
            this.Listar();
        }

        private void tslEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadesDesktop formEspecialidades = new EspecialidadesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formEspecialidades.ShowDialog();
                this.Listar();
            }
        }

        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadesDesktop formEspecialidades = new EspecialidadesDesktop(ID, ApplicationForm.ModoForm.Baja);
                formEspecialidades.ShowDialog();
                this.Listar();
            }
        }
    }
}
