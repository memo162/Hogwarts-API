using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
