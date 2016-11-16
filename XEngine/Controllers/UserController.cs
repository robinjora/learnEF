using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.DAL;
using XEngine.Repositories;

namespace XEngine.Controllers
{
    public class UserController : Controller
    {
        private ISysUserRepository userRepository = new SysUserRepository(new XEngineContext());
        //
        // GET: /User/
        public ActionResult Index()
        {
            var users = userRepository.GetUsers();
            return View(users);
        }
	}
}