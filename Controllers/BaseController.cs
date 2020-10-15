using BLL;
using Dominio;
using Dominio.Exceptions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevistiaTP.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public BaseController()
        {

        }

        public BaseController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set
            {
                _userManager = value;
            }
        }

        public ActionResult NotFoundError()
        {
            return View("~/Views//NotFoundError.cshtml");
        }

        public bool UsuarioAutenticado()
        {
            return User.Identity.IsAuthenticated ? true : false;
        }

        public bool UsuarioAdmin()
        {
            if (UsuarioAutenticado())
            {
                UsuarioBLL _gUsuario = new UsuarioBLL();
                return _gUsuario.Consultar(User.Identity.GetUserId()).TipoUsuario == Dominio.Enums.TipoUsuario.Admin ? true : false;
            }
            else
            {
                throw new UsuarioNoAutenticadoException();
            }
        }

        public Usuario CargarUsuario()
        {
            UsuarioBLL _gUsuario = new UsuarioBLL();

            Usuario user = new Usuario();
            var idUserLogueado = User.Identity.GetUserId();
            if (idUserLogueado != null) user = _gUsuario.Consultar(idUserLogueado);

            return user;
        }
    }
}