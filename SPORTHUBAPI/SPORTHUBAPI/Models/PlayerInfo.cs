using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPORTHUBAPI.Models
{
    public class PlayerInfo
    {
        [Key]
        public long PlayerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPhoneNo { get; set; }
        public string Sport { get; set; }
        public string City { get; set; }
        public string role { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
     

     
        
    }
}