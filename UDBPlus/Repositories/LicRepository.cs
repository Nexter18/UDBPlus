using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class LicRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public LicRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllLic()
        {
            IEnumerable<SelectListItem> licSelectListItems = new List<SelectListItem>();
            licSelectListItems = (from obj in objUDBInfoDBEntities.Licenciaturas
                                  select new SelectListItem()
                                  {
                                      Text = obj.Name,
                                      Value = obj.Id.ToString(),
                                      Selected = true
                                  }).ToList();

            return licSelectListItems;
        }
    }
}