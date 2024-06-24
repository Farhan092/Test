using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practice.Models
{
    public class Employee
    {

        [Display(Name = "Please enter user id")]
        
        public int Id { get; set; }
          public string Name { get; set; }

        [DataType(DataType.Password)]

          public string Password { get; set; }
    }
}