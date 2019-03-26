using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPORTHUBAPI.Models
{
    public class UserLogin
    {
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}