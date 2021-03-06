﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Negocio;

namespace UI.Desktop
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            try
            {
                this.dgvMaterias.DataSource = ml.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Materias_Load(object sender, EventArgs e)
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
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMateria.ShowDialog();
            this.Listar();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formMateria.ShowDialog();
                this.Listar();
            }

        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
                formMateria.ShowDialog();
                this.Listar();
            }
        }
    }
}
