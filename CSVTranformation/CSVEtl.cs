using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CsvHelper;
using System.Collections.Generic;

namespace CSVTranformation
{
    public static class CSVEtl
    {
        [FunctionName("CSVEtl")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("ETL transformation");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            var data = JsonConvert.DeserializeObject(requestBody);
            log.LogInformation(data.ToString());

            //for(int i =0; i < data.Data.Count; i++) {
            //    log.LogInformation(data.Data[i].ToString());
            //}

            SortedSet<string> headers = new();
            List<string> values = new();

            JArray array = JArray.Parse(requestBody);
            foreach (JObject obj in array.Children<JObject>()) { 
                foreach(JProperty singleProp in obj.Properties())
                {
                    headers.Add(singleProp.Name);
                    values.Add(singleProp.Value.ToString());
                }
            }

            log.LogInformation("These are the headers: ");
            foreach (string v in headers) {
                log.LogInformation(v);
            }
            log.LogInformation("These are the values: ");
            foreach (string v in values)
            {
                log.LogInformation(v);
            }


            //using (var csv = File.OpenWrite("C:/Users/nenum/Desktop/Tests-files/test.csv"))
            //{
            //    using (var writer = new ChoCSVWriter<List<object>>(csv))
            //    {
            //        parser.Write(data.Data);
            //    }
            //}

            using(var writer = new StreamWriter("C:/Users/nenum/Desktop/Tests-files/test.csv"))
            using(var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                foreach (string h in headers)
                {
                    csv.WriteField(h);
                }
                csv.NextRecord();
                foreach (string v in values)
                {
                    csv.WriteField(v);
                }
                writer.Flush();
                
            }

            return new OkObjectResult("I'm working for now");
        }
    }
}
