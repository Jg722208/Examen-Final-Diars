using EF_N00024113.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EF_N00024113.Controllers
{
    public class BaseController: Controller
    {
        private readonly Ef_Context context;
        public BaseController(Ef_Context context)
        {
            this.context = context;
        }

        protected Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Usuarios.Where(o => o.NombreUsuario == claim.Value).FirstOrDefault();
            return user;
        }
    }
}