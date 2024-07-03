namespace CRUDEF.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name can't be empty")]
        [MaxLength(20, ErrorMessage = "Not more than 20 alphabets")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> JoinDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [MinLength(2, ErrorMessage = "Minimum 2 digits")]
        [MaxLength(11, ErrorMessage = "Maximum 11 digits")]
        public string Cell { get; set; }

        [Range(1000, 60000, ErrorMessage = "Salary range should be between 1000 and 60000")]
        public Nullable<double> Salary { get; set; }
        public string Designation { get; set; }
    }
}