using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ProjectMVC.Models
{
    public class HomeViewModel
    {
        public List<UserViewModel> UserList { get; set; }
        public List<UserProjectViewModel> UserProjectList { get; set; }
        //public List<string> UserProjectNameList { get; set; }
    }
}