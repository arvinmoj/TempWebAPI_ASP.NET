using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class TestModelVM
    {
        public TestModelVM() : base()
        {
        }

        // *****
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        // *****

        // *****
        [Display(Name = "Age")]
        public int Age { get; set; }
        // *****

        // *****
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        // *****

    }
}