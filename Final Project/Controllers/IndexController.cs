using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;

namespace Final_Project.Controllers
{
    public class IndexController : Controller
    {

        //Vista Principal 
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //Aqui muestro mi Opcion Editar Departamento
        public ActionResult EditarDepartamento(int id)
        {
            var depar = Departamento_Negocio.GetDepartamento(id);
            return View(depar);
        }

        //Aqui envio los cambio para editar departamento.

        [HttpPost]
        public ActionResult EditarDepartamento(Departamento depart)
        {
            try
            {
                
                Departamento_Negocio.Editar(depart);
                return RedirectToAction("Departamento");

            }
            catch (Exception x)
            {
                ModelState.AddModelError("Error", x.Message);
                return View(depart);
            }

        }

        [HttpPost]
        public ActionResult EliminarDepartamento(int id)
        {
            try
            {
                Departamento_Negocio.Eliminar(id);
                return Content("1");
            }
            catch (Exception x )
            {
                ModelState.AddModelError("",x.Message);
                return View();
            }
        }


        public ActionResult Departamento()
        {
            var department = Departamento_Negocio.ListarDepartamento();
            return View(department);
        }

        //Esta es la parte donde Agrego a la base de Datos 
    
         [HttpPost]
        public ActionResult CrearDepartamento(Departamento depertment)
        {


            try
            {
                Departamento_Negocio.AgregarDepartamento(depertment);
                return RedirectToAction("Departamento");

            }
            catch (Exception x)
            {

                ModelState.AddModelError("Error", x.Message);
                return View(depertment);
            }
        }

        public ActionResult CrearDepartamento()
        {


            return View();
        }


        //Cargos
        public ActionResult Cargo()
        {
            var CargoLista = Cargos_Negocio.ListarCargos();
            return View(CargoLista);

        }

        public ActionResult AgregarCargo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarCargo(Cargo puesto)
        {

            try
            {
                Cargos_Negocio.Agregar_Cargos(puesto);
                return RedirectToAction("Cargo");

            }
            catch (Exception x)
            {

                ModelState.AddModelError("Error", x.Message);
                return View(puesto);
            }

   
        }

        [HttpPost]
        public ActionResult EliminarCargo(int id)
        {
            try
            {
                Cargos_Negocio.EliminarCargo(id);
                return Content("1");
            }
            catch (Exception x)
            {
                ModelState.AddModelError("", x.Message);
                return View();
            }
        }

        public ActionResult EditarCargo(int id )
        {
            var puesto = Cargos_Negocio.GetCargo(id);
            return View(puesto);

        }

        [HttpPost]
        public ActionResult EditarCargo(Cargo puesto)
        {
            try
            {
                Cargos_Negocio.EditarCargo(puesto);
                return RedirectToAction("Cargo");
            }
            catch (Exception x)
            {
                ModelState.AddModelError("Error", x.Message);
                return View(puesto);
            }
        }






    }
}
