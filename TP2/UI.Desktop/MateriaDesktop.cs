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
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia MateriaActual { get; set; }
        public MateriaDesktop()
        {
            InitializeComponent();
        }
        public MateriaDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
            this.txtID.Enabled = false;
        }
        public MateriaDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            try
            {
                MateriaActual = ml.GetOne(ID);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MapearDeDatos();
        }
        public void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtSemanales.Text = this.MateriaActual.HSSemanalas.ToString();
            this.txtTotales.Text = this.MateriaActual.HSTotales.ToString();
            this.txtPlan.Text = this.MateriaActual.IDPlan.ToString();           
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
                MateriaActual = new Materia();
                MateriaActual.State = Materia.States.New;
            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                MateriaActual.State = Materia.States.Modified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                MateriaActual.State = Materia.States.Deleted;
            }
            else
            {
                MateriaActual.State = Materia.States.Unmodified;
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                MateriaActual.Descripcion = this.txtDescripcion.Text;
                MateriaActual.HSSemanalas = Int32.Parse(this.txtSemanales.Text);
                MateriaActual.HSTotales = Int32.Parse(this.txtTotales.Text);
                MateriaActual.IDPlan = Int32.Parse(this.txtPlan.Text);                
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
            MateriaLogic Materia = new MateriaLogic();
            try
            {
                Materia.Save(MateriaActual);
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
            if (this.txtDescripcion.Text == "" || this.txtSemanales.Text == "" || this.txtTotales.Text == ""
                || this.txtPlan.Text == "" )
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
