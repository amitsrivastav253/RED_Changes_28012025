using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REDMIS.Models
{
    public class Login
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ProcId { get; set; }
        public string msg { get; set; }
        public int DistrictId { get; set; }
        public int DivisionId { get; set; }
        public int ZoneId { get; set; }
        public int CircleId { get; set; }
        public int UserTypeId { get; set; }
    }
}