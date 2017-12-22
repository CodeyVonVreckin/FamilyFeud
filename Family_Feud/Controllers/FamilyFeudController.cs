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
        const string _pubKey = "pub-c-12219e16-c45b-411e-aa5a-977e1a130441";
        const string _subKey = "sub-c-e53da4be-c647-11e7-8d13-12daa3930087";
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
            GameData gameData = new GameData();
            
            gameData.TeamOne = team1;
            gameData.TeamTwo = team2;
            
            gameData.PubKey = _pubKey;
            gameData.SubKey = _subKey;
            
            gameData.Channel = gameData.GenerateChannelName();

            return View(gameData);
        }

        public ActionResult SteveScreen(string team1, string team2, string channel)
        {
            GameData data = new GameData();
            
            data.TeamOne = team1;
            data.TeamTwo = team2;
           
            data.PubKey = _pubKey;
            data.SubKey = _subKey;
            
            data.Channel = channel;

            return View(data);
        }
    }
}