using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OMS_API.Models;
using OMS_API.Repository;

namespace OMS_API.Controllers
{
    [Produces("application/json")]
    [Route("api/PullProjectData")]
    public class PullProjectDataController : Controller
    {
        PullProjectDataRes pullprojectdataRes = new PullProjectDataRes();
        // GET: api/PushProjectData
        [HttpGet]
        public IEnumerable<string> GetData()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/PushProjectData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/PushProjectData
        [HttpPost]      
        public ActionResult Post(string secretKey,[FromBody] PullProjectData model)
        {
            if (secretKey != null )
            {
                var result = pullprojectdataRes.GetAllData(ProjectID: model.projectID, SourceID: model.sourceID, DateFrom: model.datefrom, DateEnd: model.dateend);
                return Json(result);
            }
            return NoContent(); ;
        }
        
        // PUT: api/PushProjectData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
