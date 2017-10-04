using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoScrum.Models
{
    public class Roles
    {

        public permisos modeloPermisos { get;  set; }
        public AspNetRoles modeloNetRoles { get; set; }
        
        public List<permisos> listaPermisos { get; set; }

        public List<AspNetRoles> listaRoles { get; set; }
    }
}