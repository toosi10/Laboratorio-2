using Gastronomia.Base.Helpers;
using System;
using System.Windows.Forms;

namespace Gastronomia.Base.Formularios
{
    public partial class FormularioConsulta : FormularioBase
    {
        public FormularioConsulta()
        {
            InitializeComponent();

            AgregarImagenBotones();
            AgregarColorcontroles();
        }

        public FormularioConsulta(string titulo) : this()
        {
            lblTitulo.Text = titulo;
        }

        private void AgregarImagenBotones()
        {
            this.btnNuevo.Image = ImagenBoton.BotonNuevo;
            this.btnModificar.Image = ImagenBoton.BotonModificar;
            this.btnEliminar.Image = ImagenBoton.BotonEliminar;
            this.btnActualizar.Image = ImagenBoton.BotonActualizar;
            this.btnImpimir.Image = ImagenBoton.BotonImprimir;
            this.btnSalir.Image = ImagenBoton.BotonSalir;
            this.imgBuscar.Image = ImagenBoton.BotonBuscar;
        }

        public virtual void ActualizarDatos(string cadenaBuscar)
        {

        }

        private void AgregarColorcontroles()
        {
            txtBuscar.Enter += ColorControl_Enter;
            txtBuscar.Leave += ColorControl_Leave;
        }

        // Se hace public virtual para poder ser sobre-escrito
        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===========================================================================================================

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EjecutarFormularioInsert();
        }

        public virtual void EjecutarFormularioInsert()
        {
            
        }

        // ===========================================================================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (VerificarSiExistenDatos())
            {
                if (VerificarSiSeleccionoUnRegistro())
                {
                    EjecutarFormularioDelete();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione el registro a eliminar");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        public virtual void EjecutarFormularioDelete()
        {
        }

        // ===========================================================================================================

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (VerificarSiExistenDatos())
            {
                if (VerificarSiSeleccionoUnRegistro())
                {
                    EjecutarFormularioUpdate();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione el registro a modificar");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para modificar");
            }
        }

        public virtual void EjecutarFormularioUpdate()
        {
        }

        // ===========================================================================================================

        private bool VerificarSiSeleccionoUnRegistro()
        {
            return true;
        }

        private bool VerificarSiExistenDatos()
        {
            return true;
        }

        private void FormularioConsulta_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text);
        }
    }
}
