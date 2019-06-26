using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chinook.WebApi.Repository;
using Chinook.WebApi.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace Chinook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        public ValuesController(IUnitOfWorkEngine unitOfWorkEngine)
        {
            _unitOfWork = unitOfWorkEngine.GetUnitOfWork(WebApi.Models.DataBaseSelector.SqlServer);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _unitOfWork.Album.
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
