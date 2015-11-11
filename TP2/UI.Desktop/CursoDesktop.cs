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
    public partial class CursoDesktop : ApplicationForm
    {
        public Business.Entities.Curso CursoActual { get; set; }
        public CursoDesktop()
        {
            InitializeComponent();
        }
         public CursoDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
            this.txtCurso.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public CursoDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            CursoLogic cl = new CursoLogic();
            try
            {
                CursoActual = cl.GetOne(ID);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MapearDeDatos();
        }
        public void MapearDeDatos()
        {
            this.txtCurso.Text = this.CursoActual.ID.ToString();
           // this.chbHabilitado.Checked = this.CursoActual.
            this.txtComision.Text = this.CursoActual.IDComision.ToString();
            this.txtMateria.Text = this.CursoActual.IDMateria.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.txtAnio.Text = this.CursoActual.AnioCalendario.ToString();
            
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
                CursoActual = new Business.Entities.Curso();
                CursoActual.State = Usuario.States.New;
            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                CursoActual.State = Usuario.States.Modified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                CursoActual.State = Usuario.States.Deleted;
            }
            else
            {
                CursoActual.State = Usuario.States.Unmodified;
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                CursoActual.IDComision =  Int32.Parse(this.txtComision.Text);
                CursoActual.IDMateria = Int32.Parse(this.txtMateria.Text);
                CursoActual.Cupo = Int32.Parse(this.txtCupo.Text);
                CursoActual.AnioCalendario = Int32.Parse(this.txtAnio.Text);
                
            }
        }
        public bool Validar()
        {
            bool val = true;
            if (this.txtMateria.Text == "" || this.txtComision.Text == "" || this.txtCupo.Text == ""
                || this.txtAnio.Text == "" )
            {
                val = false;
            }
                       return val;
        }
        public void GuardarCambios()
        {
            this.MapearADatos();
            CursoLogic Curso = new CursoLogic();
            try
            {
                Curso.Save(CursoActual);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
