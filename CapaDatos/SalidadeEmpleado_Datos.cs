using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
   public class SalidadeEmpleado_Datos
    {

        public void agregarSalidaDeEmpleado(SalidaDeEmpleado salir)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.SalidaDeEmpleadoes.Add(salir);
                db.SaveChanges();
            }

        }
        //Aqui listo todo en cuanto a los departamento 
        public List<SalidaDeEmpleado> listarsalida()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.SalidaDeEmpleadoes.ToList();
            }
        }

        public SalidaDeEmpleado GetSalidaDeEmpleado(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.SalidaDeEmpleadoes.Where(d => d.ID == id).FirstOrDefault();
            }
        }

    }
}
