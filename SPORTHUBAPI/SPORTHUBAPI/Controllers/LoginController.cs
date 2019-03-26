using SPORTHUBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPORTHUBAPI.Controllers
{
    public class LoginController : ApiController
    {
        public DBContext db = new DBContext();

        [HttpPost]
        public IHttpActionResult AddUsers(UserLogin ObjUsers)
        {
            if (ObjUsers != null)
            {
                db.Login.Add(ObjUsers);
                if (db.SaveChanges() == 1)
                {
                    return Ok("Saved");
                }
                else return Ok("Not Saved");
            }
            return Ok(" Not Saved");
        }
        //Android p kr ab khud yhi yhi ip d new wli thk ha
        //Postman chla run kr
        [HttpGet]
        public IHttpActionResult GetUsers()
        {


            return Ok(db.Team.ToList());

        }
    }
}
