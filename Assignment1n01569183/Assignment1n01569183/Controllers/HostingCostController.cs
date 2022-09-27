using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01569183.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the cost of web hosting and maintenance over a series of fortnights based on user integer input in days.
        /// </summary>
        /// <param name="id">integer days of service</param>
        /// <returns>3 strings that describe total hosting cost</returns>
        /// <example>GET .../api/HostingCost/10</example>
        public string [] Get(int id)
        {
            if(id <= 0)
            {
                id += 1;
            }
            decimal fortnight = Math.Ceiling(id / 14m);
            if (id % 14 == 0) fortnight += 1;
            decimal tax = 0.13m;
            decimal rate = 5.50m;
            decimal totalBeforeTax = Math.Round(rate * fortnight, 2);
            decimal totalTax = Math.Round(tax * totalBeforeTax, 2);
            decimal totalHostingCost = Math.Round(totalBeforeTax + totalTax, 2);

            string firstMessage = $"{fortnight} fortnights at ${rate}/FN = ${totalBeforeTax} CAD.";
            string secondMessage = $"HST 13% = ${totalTax} CAD";
            string thirdMessage = $"Total = ${totalHostingCost} CAD";

            string [] outputs = { firstMessage, secondMessage, thirdMessage };
            return outputs;
        }
    }
}
