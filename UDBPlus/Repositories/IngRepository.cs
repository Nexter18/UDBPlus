using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class IngRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public IngRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllIng()
        {
            IEnumerable<SelectListItem> ingSelectListItems = new List<SelectListItem>();
            ingSelectListItems = (from obj in objUDBInfoDBEntities.Ingenierias
                                  select new SelectListItem()
                                  {
                                      Text = obj.Name,
                                      Value = obj.Id.ToString(),
                                      Selected = true
                                  }).ToList();

            return ingSelectListItems;
        }
    }
}