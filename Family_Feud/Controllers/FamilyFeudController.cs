using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Family_Feud.Controllers
{
    public class FamilyFeudController : Controller
    {
        // GET: FamilyFeud
        public ActionResult StartPage()
        {
            return View();
        }
        public ActionResult FamilyPicker()
        {
            return View();
        }
        public ActionResult GameBoard()
        {
            return View();
        }
        public ActionResult DavidsGameBoard()
        {            
            return View();
        }
        
        public ActionResult GetQuestions()
        {
            
            var questions = Url.Action("../Content/Questions/FamilyFeudQuestions.json");
            return Json(questions, JsonRequestBehavior.AllowGet);
        }
    }
}