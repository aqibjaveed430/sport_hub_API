using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPORTHUBAPI.Models
{
    public class TeamRegister
    {
        [Key]
        public long UserId { get; set; }
        public string TeamName { get; set; }
        public string TeamSport { get; set; }
        public string CityName { get; set; }
        public string TeamArea { get; set; }
        public string PhoneNo { get; set; }

    }
}