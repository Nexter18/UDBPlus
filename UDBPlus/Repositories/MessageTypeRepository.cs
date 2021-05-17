using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;

namespace UDBPlus.Repositories
{
    public class MessageTypeRepository
    {
        private UDBInfoDBEntities objUDBInfoDBEntities;

        public MessageTypeRepository()
        {
            objUDBInfoDBEntities = new UDBInfoDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllMessType()
        {
            IEnumerable<SelectListItem> messtSelectListItems = new List<SelectListItem>();
            messtSelectListItems = (from obj in objUDBInfoDBEntities.MessageTypes
                                select new SelectListItem()
                                {
                                    Text = obj.MessageType1,
                                    Value = obj.MessageTypeId.ToString(),
                                     Selected = true
                                }).ToList();

            return messtSelectListItems;
        }
    }
}