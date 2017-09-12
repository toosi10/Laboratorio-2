using Gastronomia.Base.Formularios;
using Gastronomia.Base.Helpers;

namespace Gastronomia.Core
{
    public partial class _00004_ABM_Perfil : FormularioAbm
    {
        public _00004_ABM_Perfil()
        {
            InitializeComponent();
        }

        public _00004_ABM_Perfil(TipoOperacion operacion, long? entidadId = null) : base(operacion, entidadId)
        {
            InitializeComponent();
        }
    }
}
