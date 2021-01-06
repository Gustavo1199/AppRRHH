using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;



namespace CapaDatos
{
   public class Vacaciones_Datos
    {


        public void agregarVacaciones(Vacione vaca)
        {
            using (var db = new RecursosHumanoEntities1())
            {
                db.Vaciones.Add(vaca);
                db.SaveChanges();
            }

        }

        //Aqui listo todo en cuanto a los departamento 
        public List<Vacione> listarvacaciones()
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Vaciones.ToList();
            }
        }


        public Vacione GetVacione(int id)
        {
            using (var basedeDatos = new RecursosHumanoEntities1())
            {
                return basedeDatos.Vaciones.Where(d => d.Id == id).FirstOrDefault();
            }
        }


    }
}
