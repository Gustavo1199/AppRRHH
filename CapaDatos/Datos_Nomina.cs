using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos_Nomina
    {  
            public List<Nomina> ListaNomina()
            {
                using (var db = new RecursosHumanoEntities1())
                {
                    return db.Nominas.ToList();
                }
            }

            public void agregarnomina(Nomina nom)
            {
                using (var db = new RecursosHumanoEntities1())
                {
                    db.Nominas.Add(nom);
                    db.SaveChanges();
                }
            }

            public void borarNomina(int id)
            {
                using (var db = new RecursosHumanoEntities1())
                {
                    var nom = db.Nominas.Find(id);
                    db.Nominas.Remove(nom);
                    db.SaveChanges();
                }
            }












        



    }
}
