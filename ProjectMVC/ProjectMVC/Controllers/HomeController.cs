using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private ChallengeModel db = new ChallengeModel();
        
        public ActionResult Index(int UserList=-1)
        {           
            var lUsers = new HomeViewModel();
            lUsers.UserList = getUserList();
            lUsers.UserProjectList = getUserProjectList(UserList);
            //lUsers.UserProjectNameList = getInfoList(new UserProjectViewModel());

            return View(lUsers);
        }

        private List<UserViewModel> getUserList()
        {
            var lUsers = new List<UserViewModel>();

            lUsers.Add(new UserViewModel() { Id = -1, FirstName = "--", LastName ="" });

            foreach (var item in db.User.ToList())
            {
                lUsers.Add(new UserViewModel() { Id = item.Id, FirstName = item.FirstName, LastName = item.LastName });
            }
            return lUsers;
        }

        [HttpPost]
        private List<UserProjectViewModel> getUserProjectList(int Id)
        {
            List<UserProject> lista = db.UserProject.ToList();
            List<Project> vlProjects = db.Project.ToList();
            var lUserProjects = new List<UserProjectViewModel>();
            
            var Projects =(from p in lista
                            where p.UserId.Equals(Id)
                            select new { p.ProjectId, p.IsActive }).ToList() ;

            foreach (var a in Projects)
            {
                foreach(Project p in vlProjects)
                {
                    if(p.Id == a.ProjectId)
                    {
                        string vActive = "";
                       if(a.IsActive)
                            vActive = "Active";
                       else
                            vActive = "Inactive";

                        lUserProjects.Add(new UserProjectViewModel()
                        {
                            ProjectId = p.Id
                                                         ,
                            UserId = Id
                                                         ,
                            Credits = p.Credits
                                                         ,
                            EndDate = p.EndDate
                                                         ,
                            StartDate = p.StartDate
                                                         ,
                            IsActive = vActive
                        });
                    }
                }
            }
            return lUserProjects;            
        }

        //private List<string> getInfoList(UserProjectViewModel list)
        //{
            
        //    var lNameProjects = new List<string>();
        //    PropertyInfo[] result = list.GetType().GetProperties();
        //    foreach (PropertyInfo pi in result)
        //    {
        //        lNameProjects.Add(pi.Name);
        //    }
        //    return lNameProjects;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}