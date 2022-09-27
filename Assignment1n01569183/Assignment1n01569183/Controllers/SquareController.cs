using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01569183.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input {id}
        /// </summary>
        /// <param name="id">integer input number</param>
        /// <returns>squared result of input</returns>
        /// <example>
        /// GET /api/Square/2 -> 4
        /// GET /api/Square/-2 -> 4
        /// GET /api/Square/10 -> 100
        /// 
        /// </example>
        public int Get(int id)
        {
            int idSquared = id * id;
            return idSquared;
        }
    }
}
