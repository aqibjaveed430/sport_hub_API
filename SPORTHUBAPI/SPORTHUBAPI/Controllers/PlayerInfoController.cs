using SPORTHUBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPORTHUBAPI.Controllers
{
    public class PlayerInfoController : ApiController
    {

        public DBContext db = new DBContext();

        [HttpPost]
        public IHttpActionResult AddUsers(PlayerInfo ObjUsers)
        {
            if (ObjUsers != null)
            {
                db.Player.Add(ObjUsers);
                if (db.SaveChanges() == 1)
                {
                    return Ok("Saved");
                }
                else return Ok("Not Saved");
            }
            return Ok(" Not Saved");
        }

        [HttpGet]
        public IHttpActionResult GetUsers()
        {


            return Ok(db.Player.ToList());

        }
    }
}
