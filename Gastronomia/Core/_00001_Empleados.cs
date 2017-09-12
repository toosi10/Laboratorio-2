using Gastronomia.Base.Formularios;
using Gastronomia.Base.Helpers;
using Gastronomia.LogicaNegocio.Empleado;

namespace Gastronomia.Core
{
    public partial class _00001_Empleados : FormularioConsulta
    {
        private readonly EmpleadoServicio _empleadoServicio;

        public _00001_Empleados(EmpleadoServicio empleadoServicio) : base("Lista de Empleados")
        {
            InitializeComponent();
            _empleadoServicio = empleadoServicio;
        }

        public _00001_Empleados() : this(new EmpleadoServicio())
        {
        }

        public override void ActualizarDatos(string cadenaBuscar)
        {
            this.dgvGrilla.DataSource = _empleadoServicio.Obtener(cadenaBuscar);
        }

        public override void EjecutarFormularioInsert()
        {
            var formAltaEmpleado = new _00002_ABM_Empleado(TipoOperacion.Insert);
            formAltaEmpleado.ShowDialog();
        }

        public override void EjecutarFormularioDelete()
        {
            var formBajaEmpleado = new _00002_ABM_Empleado(TipoOperacion.Delete, 1);
            formBajaEmpleado.ShowDialog();
        }

        public override void EjecutarFormularioUpdate()
        {
            var formModificarEmpleado = new _00002_ABM_Empleado(TipoOperacion.Update, 1);
            formModificarEmpleado.ShowDialog();
        }
    }
}
