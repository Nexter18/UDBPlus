using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class MasterRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;
        public MasterRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllMaster()
        {
            IEnumerable<SelectListItem> masterSelectListItems = new List<SelectListItem>();
            masterSelectListItems = (from obj in objUDBInfoDBEntities.Maestrias
                                  select new SelectListItem()
                                  {
                                      Text = obj.Name,
                                      Value = obj.Id.ToString(),
                                      Selected = true
                                  }).ToList();

            return masterSelectListItems;
        }
    }
}