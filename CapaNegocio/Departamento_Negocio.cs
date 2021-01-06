using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
      public class Departamento_Negocio
    {

        private static Departamento_Datos objeto = new Departamento_Datos();

        public static void AgregarDepartamento(Departamento department)
        {
            objeto.AgregarDepartamento(department);
        }

        public static List<Departamento> ListarDepartamento()
        {
            return objeto.ListarDepartamento();

        }



        public static Departamento GetDepartamento(int id)
        {

            return objeto.GetDepartamento(id);
        }

        public static void Editar(Departamento depart)
        {
            objeto.Editar(depart);
        }


        public static void Eliminar(int id)
        {
            objeto.Eliminar(id);

        }




    }
}
