using Gastronomia.Base.Formularios;
using Gastronomia.Base.Helpers;

namespace Gastronomia.Core
{
    public partial class _00002_ABM_Empleado : FormularioAbm
    {
        public _00002_ABM_Empleado()
        {
            InitializeComponent();
        }

        public _00002_ABM_Empleado(TipoOperacion operacion, long? entidadId = null) : base(operacion, entidadId)
        {
            InitializeComponent();
        }
    }
}
