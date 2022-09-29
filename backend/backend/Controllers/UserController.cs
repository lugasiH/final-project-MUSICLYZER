using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DAL.models;

namespace backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
       
        [HttpPost]
        [Route("check")]
        public bool checkUser(User u)
        {
            return u.CheckUser(u);
        }
        [HttpPost]
        [Route("add")]
        public bool addUser(User u)
        {
            return u.AddUser(u);
        }
    }
}
