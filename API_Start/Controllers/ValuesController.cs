using API_Start.Entities;
using API_Start.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Start.Controllers
{
    public class ValuesController : ApiController
    {
        ApplicationDbContext _dbContext=new ApplicationDbContext();

        public ValuesController()
        {
          
        }
        // GET api/values
        public IEnumerable<Employees> Get()
        {
           var list= _dbContext.Employees.ToList();
           return list;
        }

        // GET api/values/5
        public IEnumerable<Employees> Get(string Name)
        {
            var list = _dbContext.Employees.Where(e => e.FirstName.Contains(Name)).ToList();
            return list;
        }

        // POST api/values
        public void Post([FromBody]string FirstName,string LastName, string Gender, int Salary)
        {
            Employees new_emp = new Employees
            {
               FirstName=FirstName,
               LastName=LastName,
               Salary=Salary,
               Gender=Gender
            };
            _dbContext.Employees.Add(new_emp);
            _dbContext.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
