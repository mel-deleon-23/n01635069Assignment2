using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// CCC 2005 -> https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2005/stage1/juniorEn.pdf
        /// </summary>
        /// <param name="left">To input LEFT direction</param>
        /// <param name="right">To input RIGHT direction</param>
        /// <returns>
        //  GET api/J3/ReturningHome/L/JANE/R/ELM/L/HOME -> "Turn LEFT onto JANE street. Turn RIGHT onto BLANEY street. Turn LEFT into your HOME."
        /// </returns>

        [HttpGet]
        [Route("api/J3/ReturningHome/{left}/streetname/{right}/home")]
        public string ReturningHome(string left = "L", string right = "R")
        {
            //left = "L";
            //right = "R";
            string streetname = "";
            //string street1 = "JANE";
            //string street2 = "BLANEY";

            return "Turn "+left+ " onto " +streetname+ " street. Turn " +right+ " onto " +streetname+ " street. Turn " +left+ "into your HOME.";
        }

    }
}
