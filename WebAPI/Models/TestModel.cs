using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("TestModels")]
    public class TestModel : Base.Entity
    {
        public TestModel() : base()
        {
        }

        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
