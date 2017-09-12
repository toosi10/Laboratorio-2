using Gastronomia.Base.Helpers;
using System;

namespace Gastronomia.Base.Formularios
{
    public partial class FormularioConsulta : FormularioBase
    {
        public FormularioConsulta()
        {
            InitializeComponent();

            AgregarImagenBotones();
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

        // Se hace public virtual para poder ser sobre-escrito
        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
