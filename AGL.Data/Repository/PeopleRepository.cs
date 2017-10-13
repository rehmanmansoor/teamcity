using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGL.Data;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Configuration;
using System.Threading.Tasks;

namespace AGL.Data
{
  public class PeopleRepository : IPeopleRepository
  {
    public PeopleRepository()
    {
        GetJsonData();
    }

    private string JsonData { get; set; }

    private bool GetJsonData()
    {
     string url = ConfigurationManager.AppSettings["AglServicesUrl"];

      using (var client = new HttpClient())
      {
        var response = client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
          var responseContent = response.Content;
          JsonData= responseContent.ReadAsStringAsync().Result;
        }
      }

      return true; 
    }

    public List<People> GetPeopleList()
    {
      List<People> list = null;

      list = JsonConvert.DeserializeObject<List<People>>(JsonData);

      return list;

    }

    
  }
}