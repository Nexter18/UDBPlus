using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDBPlus.Models;
using UDBPlus.Repositories;
using UDBPlus.ViewModel;

namespace UDBPlus.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IngRepository ingRepository = new IngRepository();
            LicRepository licRepository = new LicRepository();
            MasterRepository masterRepository = new MasterRepository();
            TecRepository tecRepository = new TecRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(ingRepository.GetAllIng(), licRepository.GetAllLic(), masterRepository.GetAllMaster(), tecRepository.GetAllTec());
            return View(objMultipleModels);
        }

        public ActionResult Messages()
        {
            UDBInfoDBEntities db = new UDBInfoDBEntities();
            List<MessageType> list = db.MessageTypes.ToList();
            ViewBag.MessageType = new SelectList(list, "MessageTypeId", "MessageType");
            return View();
        }

        public ActionResult SaveInfo(MessageViewModel model)
        {
            try
            {
                UDBInfoDBEntities db = new UDBInfoDBEntities();

                Message mess = new Message
                {
                    CName = model.CName,
                    Email = model.Email,
                    Message1 = model.Message
                };

                db.Messages.Add(mess);
                db.SaveChanges();

                int latestMessId = mess.MessageId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}