using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoScrum.Controllers
{
    public class RolesController : Controller
    {

        Models.patopurificEntities baseDatos = new Models.patopurificEntities();
        // GET: Roles
        public ActionResult Index()
        {

            Models.Roles modelo = new Models.Roles();
            modelo.ListaRoles = baseDatos.AspNetRoles.ToList();
            modelo.ListaPermisos = baseDatos.permisos.ToList();
            return View(modelo);
        }
    }
}