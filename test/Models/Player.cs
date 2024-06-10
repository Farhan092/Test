using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labtask.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }

      
    }

    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Stadium
    {
        
        public string Location { get; set; }
        public string Capacity { get; set; }
    }
}