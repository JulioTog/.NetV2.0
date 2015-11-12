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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ComisionesDesktop : ApplicationForm
    {
        public Comision ComisionActual { get; set; }
        public ComisionesDesktop()
        {
            InitializeComponent();
        }
    public ComisionesDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
            this.txtID.Enabled = false;
        }
        public ComisionesDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            ComisionesLogic cl = new ComisionesLogic();
            try
            {
                ComisionActual = cl.GetOne(ID);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MapearDeDatos();
        }
        public void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnio.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.txtPlan.Text = this.ComisionActual.IDPlan.ToString();
           

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
                ComisionActual = new Comision();
                ComisionActual.State = Comision.States.New;
            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                ComisionActual.State = Comision.States.Modified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                ComisionActual.State = Comision.States.Deleted;
            }
            else
            {
                ComisionActual.State = Comision.States.Unmodified;
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                ComisionActual.Descripcion = this.txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = Int32.Parse(this.txtAnio.Text);
                ComisionActual.IDPlan = Int32.Parse(this.txtPlan.Text);
                
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
            ComisionesLogic Comision = new ComisionesLogic();
            try
            {
                Comision.Save(ComisionActual);
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
            if (this.txtDescripcion.Text == "" || this.txtAnio.Text == "" || this.txtPlan.Text == "")
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
