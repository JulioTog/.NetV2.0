using System;
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
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public Plan PlanActual { get; set; }
        public PlanDesktop()
        {
            InitializeComponent();
        }
    public PlanDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
            this.txtID.Enabled = false;
        }
        public PlanDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            PlanLogic pl = new PlanLogic();
            try
            {
                PlanActual = pl.GetOne(ID);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MapearDeDatos();
        }
        public void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.txtEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();            
            switch (this.Modo)
            {
                case ModoForm.Modificacion: btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta: btnAceptar.Text = "Aceptar";
                    break;
                case ModoForm.Baja: btnAceptar.Text = "Eliminar";
                    break;
                default: break;
            }
        }
        public void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                PlanActual = new Plan();
                PlanActual.State = Plan.States.New;
            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                PlanActual.State = Plan.States.Modified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                PlanActual.State = Plan.States.Deleted;
            }
            else
            {
                PlanActual.State = Plan.States.Unmodified;
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = this.txtDescripcion.Text;
                PlanActual.IDEspecialidad = Int32.Parse(this.txtEspecialidad.Text);               
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validacion = this.Validar();
            if (validacion)
            {
                this.GuardarCambios();
                this.Close();
            }
            else
            {
                this.Notificar("Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GuardarCambios()
        {
            this.MapearADatos();
            PlanLogic Plan = new PlanLogic();
            try
            {
                Plan.Save(PlanActual);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Validar()
        {
            bool val = true;
            if (this.txtDescripcion.Text == "" || this.txtEspecialidad.Text == "" )
            {
                val = false;
            }            
            return val;
        }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
    }
}
