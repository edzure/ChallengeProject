using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class UserProjectViewModel
    {
        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public string TimeToStart { get
                                    {
                                        TimeSpan result= StartDate.Subtract(DateTime.Today);
                                        if (result.Days > 0)
                                            return result.Days.ToString();
                                        else
                                            return "Started";
                                     }
                                }

        public DateTime EndDate { get; set; }

        public int Credits { get; set; }

        public string IsActive { get; set; }
    }
}