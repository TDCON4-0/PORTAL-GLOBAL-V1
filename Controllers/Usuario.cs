using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal_Global.Controllers
{
    public  class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<int> IdIdioma { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Status { get; set; }
        public string Compania { get; set; }
        public string Departamento { get; set; }
        public string Manager { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
       // public Nullable<int> IDPerfilUsuario { get; set; }
       // public Nullable<int> IDArea { get; set; }
        public string Token { get; set; }
        public string _token { get; set; }

        public string TimeOut { get; set; }


    }


}
