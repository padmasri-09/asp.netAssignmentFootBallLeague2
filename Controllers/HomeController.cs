using Assignment1asp.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1FootBallLeague
{
    
    public class FootBallLeagueController : Controller
    {
        // GET: FootBallLeague
        public ActionResult Index()
        {
            FootBallLeagueContext league = new FootBallLeagueContext();
            List<FootBallLeagueController> ll = league.FootBallLeagues.ToList();
            return View(ll);
        }

        private class FootBallLeagueContext
        {
            internal object FootBallLeagues;

            public FootBallLeagueContext()
            {
            }
        }
    }
}

    