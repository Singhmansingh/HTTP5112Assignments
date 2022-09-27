using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01569183.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Takes an input ID, performs 4 mathematical operations on it, then returns the result
        /// </summary>
        /// <param name="id">integer input number</param>
        /// <returns>mathematical result</returns>\
        /// <example>
        /// GET /api/NumberMachine/10 -> 119.3333
        /// GET /api/NumberMachine/-5 -> 19.3333
        /// GET /api/NumberMachine/30 -> 252.66667
        /// </example>
        public string Get(int id)
        {
            double result = (((id + 10) * 20) / 3) - 14;
            string response = "The result of (((ID + 10) * 20) / 3) - 14, with ID = " + id + " is " + result;
            return response;
        }
    }
}
