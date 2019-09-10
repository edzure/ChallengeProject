using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
   [MetadataType(typeof(UserMetadata))]
   public partial class User { }

    [MetadataType(typeof(ProjectMetadata))]
    public partial class Project { }
}