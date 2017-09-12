using Gastronomia.Base.Helpers;

namespace Gastronomia.Base.Formularios
{
    public partial class FormularioAbm : FormularioBase
    {
        TipoOperacion _operacion;
        private long? _entidadId;

        public FormularioAbm()
        {
            InitializeComponent();

            AgregarImagenBotones();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="operacion">Tipo de Operacion a Reaizar (Insert, Update, Delete)</param>
        /// <param name="entidadId">Identificador de la Entidad</param>
        public FormularioAbm(TipoOperacion operacion, long? entidadId = null) : this()
        {
            _operacion = operacion;
            _entidadId = entidadId;
        }

        private void AgregarImagenBotones()
        {
            this.btnEjecutar.Image = ImagenBoton.BotonEjecutar;
            this.btnLimpiar.Image = ImagenBoton.BotonLimpiar;
            this.btnSalir.Image = ImagenBoton.BotonSalir;
        }
    }
}
