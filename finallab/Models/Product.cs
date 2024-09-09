using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalLabCF.Models
{
    public class Product
    {
       public int Id { get; set; }

       [Required]
       [Display(Name = "Product Name")]
       public string Name { get; set; }
       public int CategoryId { get; set; }

       [Display(Name = "Product Price")]
       public double Price { get; set; }

       public Category Category { get; set; }
    }
}