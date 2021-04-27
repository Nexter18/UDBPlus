using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class CourseRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public CourseRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCourses()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objUDBInfoDBEntities.Courses
                                  select new SelectListItem()
                                  {
                                      Text = obj.Course,
                                      Value = obj.CourseId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}