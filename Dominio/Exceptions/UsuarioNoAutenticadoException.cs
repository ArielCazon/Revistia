using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class UsuarioNoAutenticadoException : Exception
    {
        public UsuarioNoAutenticadoException() : base("No tiene permisos suficientes para poder acceder.")
        {
        }

        public UsuarioNoAutenticadoException(string message) : base(message)
        {
        }

        public UsuarioNoAutenticadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UsuarioNoAutenticadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
