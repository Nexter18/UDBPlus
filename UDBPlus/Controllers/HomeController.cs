using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Repositories;

namespace UDBPlus.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CourseRepository objCourseRepository = new CourseRepository();
            CourseTypeRepository objCourseTypeRepository = new CourseTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objCourseRepository.GetAllCourses(),objCourseTypeRepository.GetAllCourseType());
            return View(objMultipleModels);
        }
    }
}