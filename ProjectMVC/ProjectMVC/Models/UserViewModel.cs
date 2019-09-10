using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }        
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }                
    }
}