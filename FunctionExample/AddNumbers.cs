using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FunctionExample.Contracts;

namespace FunctionExample
{
    public class AddNumbers
    {
        private readonly ICalculator _calculator;

        public AddNumbers(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [FunctionName("AddNumbers")]
        public async Task<IActionResult> Get(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Add numbers function processed a request.");

            int integer1 = Convert.ToInt32(req.Query["integer1"]);
            int integer2 = Convert.ToInt32(req.Query["integer2"]);

            var sum =_calculator.Add(integer1, integer2);

            return (ActionResult)new OkObjectResult(sum.ToString());
        }
    }
}
