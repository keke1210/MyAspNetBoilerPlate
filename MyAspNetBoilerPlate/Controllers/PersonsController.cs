using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MyAspNetBoilerPlate.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/{version:apiVersion}/[controller]")]
    public class PersonsController : ODataController
    {
        [HttpGet]
        [EnableQuery]
        public IQueryable<Person> Get()
        {
            return new string[]
                { "Alice", "Bob", "Chloe", "Dorothy", "Emma", "Fabian", "Garry", "Hannah", "Julian" }
                .Select(v => new Person { FirstName = v, Id = Guid.NewGuid(), Age = new Random().Next(80) })
                .AsQueryable();
        }

        public class Person
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public int Age { get; set; }
        }
    }
}
