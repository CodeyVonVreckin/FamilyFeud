using Family_Feud.Models;
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
        public ActionResult FriendPicker()
        {
            return View();
        }
        public ActionResult GameBoard()
        {
            return View();
        }
        public ActionResult DavidsGameBoard(string team1, string team2)
        {
            PlayerInfo teamNames = new PlayerInfo();
            teamNames.TeamOne = team1;
            teamNames.TeamTwo = team2;

            return View(teamNames);
        }

        public ActionResult SteveScreen()
        {
            return View();
        }
    }
}