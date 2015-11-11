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
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadesDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
            this.txtId.Enabled = false;
        }
         public EspecialidadesDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            EspecialidadesLogic el = new EspecialidadesLogic();
            try
            {
                EspecialidadActual = el.GetOne(ID);
            }
            catch (Exception Ex)
            {
                this.Notificar(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MapearDeDatos();
        }
         public void MapearDeDatos()
         {
             this.txtId.Text = this.EspecialidadActual.ID.ToString();
             this.txtDesc.Text = this.EspecialidadActual.Descripcion;
            
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
                 EspecialidadActual = new Especialidad();
                 EspecialidadActual.State = Usuario.States.New;
             }
             else if (this.Modo == ModoForm.Modificacion)
             {
                 EspecialidadActual.State = Usuario.States.Modified;
             }
             else if (this.Modo == ModoForm.Baja)
             {
                 EspecialidadActual.State = Usuario.States.Deleted;
             }
             else
             {
                 EspecialidadActual.State = Usuario.States.Unmodified;
             }

             if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
             {
                 EspecialidadActual.Descripcion = this.txtDesc.Text;
                 
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
            EspecialidadesLogic Especialidad = new EspecialidadesLogic();
            try
            {
                Especialidad.Save(EspecialidadActual);
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
            if (this.txtDesc.Text == "" )
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
