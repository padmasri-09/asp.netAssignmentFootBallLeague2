using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignment1asp.net
{
   public  class FootBallLeague
    {
        public DbSet<FootBallLeague> FootBallLeagues { get; set; }
    }
}