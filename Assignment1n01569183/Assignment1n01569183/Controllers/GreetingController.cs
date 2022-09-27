using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01569183.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World!"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST /api/Greeting -> Hello World!
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!" where id is an integer value.
        /// </summary>
        /// <param name="id">integer number of people to greet</param>
        /// <returns>Greetings to {id} people!</returns>
        /// <example>
        /// GET /api/Greeting/3 -> Greetings to 3 people!
        /// GET /api/Greeting/6 -> Greetings to 6 people!
        /// GET /api/Greeting/0 -> Greetings to 0 people!
        /// </example>
        public string Get(int id)
        {
            string greetPeople = "Greetings to " + id + " people!";
            return greetPeople;
        }
    }
}
