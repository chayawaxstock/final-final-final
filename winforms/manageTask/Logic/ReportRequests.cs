

using manageTask.HelpModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace manageTask.Logic
{
   public class ReportRequests
    {
 

        public static List<ReportProject> CreateReportProjects()
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(GlobalProp.URI);
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/createReport/1").Result;
            if (response1.IsSuccessStatusCode)
            {
                List<ReportProject> report = JsonConvert.DeserializeObject<List<ReportProject>>(response1.Content.ReadAsStringAsync().Result);
                if (report != null)
                    return report;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }
            
        }


        public static List<ReportWorkers> CreateReportWorkers()
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(GlobalProp.URI);
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/createReport/2").Result;
            if (response1.IsSuccessStatusCode)
            {
                List<ReportWorkers> report = JsonConvert.DeserializeObject<List<ReportWorkers>>(response1.Content.ReadAsStringAsync().Result);
                if (report != null)
                    return report;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }
        }


    }
}
