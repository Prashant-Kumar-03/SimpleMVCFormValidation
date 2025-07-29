using System.ComponentModel.DataAnnotations; //this one is for validation like using [Required], [StringLength(n)], etc.

namespace MVCFormValidation.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }
    }
}
