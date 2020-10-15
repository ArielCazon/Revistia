using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevistiaTP.Models
{
    public class HomeModel : BaseModel
    {
        public string Busqueda { get; set; }

        public HomeModel(Usuario usuario)
        {
            this.Usuario = usuario;
            Busqueda = "";
        }
    }
}