using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Project.Models;
using CapaEntidad;
using CapaNegocio;

namespace Final_Project.Controllers
{
    public class InformesController : Controller
    {

        RecursosHumanoEntities3 db = new RecursosHumanoEntities3();
        
        // GET: Informes
       public ActionResult Permiso(string buscar)
        {

            return View(db.Permisoes.Where(x => x.Empleado.Contains(buscar) || buscar == null).ToList());
            
        }

        public ActionResult Nominas(string mes)
        {

            return View(db.Nominas.Where(x => x.Mes.Contains(mes) || mes == null ).ToList());

        }



        public ActionResult EmpleadosActivo(string nombre)
        {
            
           return View(db.Empleadoes.Where(x => (x.Nombre.Contains(nombre))  && x.Estatus == true).ToList());

        }

        public ActionResult EmpleadosInactivos(string nombre)
        {

            return View(db.Empleadoes.Where(x => (x.Nombre.Contains(nombre)) && x.Estatus == false).ToList());

        }

    

        public ActionResult Departamento()
        {
            var department = Departamento_Negocio.ListarDepartamento();
            return View(department);
        }


        public ActionResult Cargo()
        {
            var CargoLista = Cargos_Negocio.ListarCargos();
            return View(CargoLista);

        }


        public ActionResult Entradasdeempleadospormes(string mes)
        {
                return View(db.Empleadoes.Where(x => (x.Fechadeingreso.Contains(mes)) || x.Fechadeingreso == null).ToList());
        }


        public ActionResult SalidaDeEmpleadoPorMes(string mes)
        {
            return View(db.SalidaDeEmpleadoes.Where(x => (x.Fecha_Salida.Contains(mes)) || x.Fecha_Salida == null).ToList());
        }



        // || nombre == null || x.Departamento.Contains(departamento) || departamento==null

    }
}
