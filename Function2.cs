using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp12345
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.Empty;
            //    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello, {name}. This HTTP triggered function executed successfully.";


            //test code 
            string folderName = string.Empty;
            int i = 1;
            string fileName = "file" + i + ".json";
            folderName = @"C:/ZoomFiles";
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            using (var writer = new StreamWriter($@"{folderName}\{fileName}", false))
            {
                responseMessage = "Testing Function2 to check azure functions";
                //writer.WriteLine("Test function to check azure functions");
            }
            //till here
            

            return new OkObjectResult(responseMessage);
        }
    }
}
