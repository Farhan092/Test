using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practice.Models
{
    public class Product
    {

        [DisplayName("Id")]
        [Required]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required]
        public int Price { get; set; }


        [DisplayName("Quantity")]
        [Required]
        public int Quantity { get; set; }


        [DisplayName("Category")]
        public string Category { get; set; }

        [DisplayName("ProductionDate")]
        [Required]
        [DataType(DataType.Date)]
        public string ProductionDate { get; set; }

        public bool IsDisposable { get; set; }

        [DisplayName("Helpline")]
        [DataType(DataType.PhoneNumber)]
        public int Helpline { get; set; }


        [DisplayName("Support Mail")]

        [DataType(DataType.EmailAddress)]
        public string SupportMail { get; set; }


    }
}