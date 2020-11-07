using System;

namespace Hogwarts.Models
{
    public class ApplicationAdmision : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public int Age { get; set; }
        public string House { get; set; }
    }
}
