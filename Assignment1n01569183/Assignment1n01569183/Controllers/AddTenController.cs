using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01569183.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns 10 more than the integer input {id}
        /// </summary>
        /// <param name="id">input number</param>
        /// <returns>10 more than the integer input</returns>
        /// <example>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        /// </example>
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
