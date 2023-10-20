using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment2.Controllers
{

    
    public class J1Controller : ApiController
    {

        /// <summary>
        /// CCC 2016 - https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2016/stage%201/juniorEn.pdf
        /// Recieve number of games the player wins to determin what group they belong in
        /// </summary>
        /// <param name="winloss">The input for win or loss</param>
        /// <returns>
        //      GET api/J1/TournamentSelection/LLLLLL -> "-1"
        //      GET api/J1/TournamentSelection/WLLLLL -> "1"
        //      GET api/J1/TournamentSelection/WLWLLL -> "1"
        //      GET api/J1/TournamentSelection/WLWLWL -> "2"
        //      GET api/J1/TournamentSelection/WWWWLL -> "2"
        //      GET api/J1/TournamentSelection/WWWWWL -> "3"
        //      GET api/J1/TournamentSelection/WWWWWW -> "3"
        /// </returns>
        [HttpGet]
        [Route("api/J1/TournamentSelection/{winloss}")]
        public int TournamentSelection(string winloss)
        {
            int loss = -1;
            int group1 = 1;
            int group2 = 2;
            int group3 = 3;

            if (winloss == "WLLLLL" || winloss == "WLWLLL")
            {
                return group1;
            }

            else if (winloss == "WLWLWL" || winloss == "WWWWLL")
            {
                return group2;
            }

            else if (winloss == "WWWWWL" || winloss == "WWWWWW")
            {
                return group3;
            }

            else 
            {
                return loss;
            }
        }


    }
}
