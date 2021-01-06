using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Empleado_Negocio
    {

        private static Empleados_Datos ObjEmplado = new Empleados_Datos();

        public static void Agregar_empleado(Empleado emplead)
        {
            ObjEmplado.Agregar_empleado(emplead);
        }


        public static Empleado GetEmpleado(int id)
        {

            return ObjEmplado.GetEmpleado(id);
        }


        public static List<Empleado> ListarEmpleado()
        {
            return ObjEmplado.ListarEmpleado();
        }


        public static void EditarEmpleado(Empleado emple)
        {
            ObjEmplado.EditarEmpleado(emple);
        }

        public static void EliminarEmpleado(int id)
        {
            ObjEmplado.EliminarEmpleado(id);
        }



    }
}
