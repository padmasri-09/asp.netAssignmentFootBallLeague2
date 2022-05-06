using Assignment1asp.net;
using Assignment1FootBallLeague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1asp.net
{
   public  class FootBallLeagueContext
    {
        public object FootBallLeagues { get; private set; }

        // GET: FootBallLeague
        public ActionResult Index()
        {
            FootBallLeagueContext league = new FootBallLeagueContext();
            List<FootBallLeague> ll = league.FootBallLeagues.ToList();
            return View(ll);
        }
    }
}
