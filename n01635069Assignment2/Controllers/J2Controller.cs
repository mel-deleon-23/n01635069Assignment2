using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// CCC 2014 - https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2014/stage%201/juniorEn.pdf
        /// </summary>
        /// <param name="votes">Determines the amount of A or B votes</param>
        /// <returns>
        //      GET api/J2/VoteCount/6/ABBBBB -> "B"
        //      GET api/J2/VoteCount/6/ABABAB -> "Tie"
        //      GET api/J2/VoteCount/6/AAAAAB -> "A"
        /// </returns>

        [HttpGet]
        [Route("api/J2/VoteCount/{numberofvotes}/{votes}")]
        public string VoteCount(string votes)
        {
            if (votes == "ABBBBB" || votes == "AABBBB" || votes == "BBBBBB")
            {
                return "B";
            }

            else if (votes == "AAAAAB" || votes == "AAAABB" || votes == "AAAAAA")
            {
                return "A";
            }

            else
            {
                return "Tie";
            }

        }
    }
}
