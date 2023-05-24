using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUsersCopy.Models
{
    public class SubjectModel
    {
        public SubjectModel()
        {
            SubjectList = new List<SelectListItem>();
        }

        [DisplayName("Subjects")]
        public List<SelectListItem> SubjectList
        {
            get;
            set;
        }
    }
}