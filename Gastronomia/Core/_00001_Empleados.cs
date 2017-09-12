using Gastronomia.Base.Formularios;
using Gastronomia.Base.Helpers;

namespace Gastronomia.Core
{
    public partial class _00001_Empleados : FormularioConsulta
    {
        public _00001_Empleados() : base("Lista de Empleados")
        {
            InitializeComponent();
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
