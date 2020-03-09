using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Start.ViewModels
{
    public class EditVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}