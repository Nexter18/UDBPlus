using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class CourseTypeRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public CourseTypeRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCourseType()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objUDBInfoDBEntities.CourseTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.CourseName,
                                      Value = obj.CourseTypeId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}