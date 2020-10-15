using DAL;
using Dominio;
using System;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _mUsuario { get; set; }

        public UsuarioBLL()
        {
            _mUsuario = new UsuarioDAL();
        }

        public void Agregar(Usuario usuario)
        {
            try
            {
                usuario.FechaAlta = DateTime.Now;
                _mUsuario.Agregar(usuario);
            }
            catch
            {
                throw;
            }
        }

        public Usuario Consultar(string id)
        {
            try
            {
                return _mUsuario.Consultar(id);
            }
            catch
            {
                throw;
            }
        }

        public void Modificar(Usuario user)
        {
            try
            {
                _mUsuario.Modificar(user);
            }
            catch
            {
                throw;
            }
        }
    }
}
