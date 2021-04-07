using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;
using System.IO;
using Newtonsoft.Json;

namespace Dashboard.Controllers
{
    public class UserProfilesController : Controller
    {
        // GET: UserProfiles
        public ActionResult Dashboard()
        {
            var userprofile = new UserProfile();
            return View(userprofile);
        }
    }
}