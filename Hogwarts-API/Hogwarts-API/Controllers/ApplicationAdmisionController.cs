using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hogwarts.Application.Interfaces;
using Hogwarts.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hogwarts_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationAdmisionController : ControllerBase
    {

        private readonly IApplicationAdmisionApplication _applicationAdmisionApplication; 
        public ApplicationAdmisionController(IApplicationAdmisionApplication applicationAdmisionApplication) 
        {
            _applicationAdmisionApplication = applicationAdmisionApplication;
        }

        // GET: api/<ApplicationAdmisionController>
        [HttpGet]
        public async Task<List<ApplicationAdmision>> Get()
        {
            return await _applicationAdmisionApplication.Get();
        }

        // GET api/<ApplicationAdmisionController>/5
        [HttpGet("{id}")]
        public async Task<ApplicationAdmision> Get(int id)
        {
            return await _applicationAdmisionApplication.Get(id);
        }

        // POST api/<ApplicationAdmisionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApplicationAdmisionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApplicationAdmisionController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _applicationAdmisionApplication.Delete(id);
        }
    }
}
