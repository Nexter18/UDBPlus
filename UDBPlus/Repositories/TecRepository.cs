using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class TecRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public TecRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllTec()
        {
            IEnumerable<SelectListItem> tecSelectListItems = new List<SelectListItem>();
            tecSelectListItems = (from obj in objUDBInfoDBEntities.Tecnicos
                                  select new SelectListItem()
                                  {
                                      Text = obj.Name,
                                      Value = obj.Id.ToString(),
                                      Selected = true
                                  }).ToList();

            return tecSelectListItems;
        }
    }
}