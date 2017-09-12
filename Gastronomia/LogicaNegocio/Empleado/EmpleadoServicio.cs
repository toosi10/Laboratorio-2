using Gastronomia.AccesoDatos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Gastronomia.LogicaNegocio.Empleado
{
    public class EmpleadoServicio
    {
        public List<AccesoDatos.Empleado> Obtener(string cadenabuscar)
        {
            int legajo = 1;
            int.TryParse(cadenabuscar, out legajo);

            using (var context = new GastronomiaContainer())
            {
                var empleados = context.Personas.OfType<AccesoDatos.Empleado>().AsNoTracking()
                    .Where(x => x.Apellido.Contains(cadenabuscar)
                    || x.Nombre.Contains(cadenabuscar)
                    || x.Cuil == cadenabuscar
                    ||x.Legajo == legajo)
                    .OrderBy(x => x.Apellido).ThenBy(x => x.Nombre)
                    .ToList();

                return empleados;
            }
        }
    }
}
