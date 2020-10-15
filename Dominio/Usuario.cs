using System;
using Dominio.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public string Id { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public DateTime FechaAlta { get; set; }

        public Usuario()
        {
            TipoUsuario = TipoUsuario.Anonimo;
        }
    }
}
