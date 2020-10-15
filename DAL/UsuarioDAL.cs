using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Agregar(Usuario usuario)
        {
            try
            {
                using (var ctx = new RevistiaDbContext())
                {
                    ctx.Usuario.Add(usuario);
                    ctx.SaveChanges();
                }
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
                Usuario user = null;
                using (var ctx = new RevistiaDbContext())
                {
                    user = ctx.Usuario.Where(x => x.Id == id).FirstOrDefault();
                }

                return user;
            }
            catch
            {
                throw;
            }
        }

        public void Modificar(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}
