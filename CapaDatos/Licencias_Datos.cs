using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Licencias_Datos
    {

        public void agregarpermiso(Licencia licen)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.Licencias.Add(licen);
                db.SaveChanges();
            }
        }

        //Aqui listo todo en cuanto a los departamento 
        public List<Licencia> listarlicencia()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Licencias.ToList();
            }
        }


        public Licencia GetLicencia(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Licencias.Where(d => d.id == id).FirstOrDefault();
            }
        }


    }
}
