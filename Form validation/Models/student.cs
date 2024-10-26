using System.ComponentModel.DataAnnotations;

namespace Form_validation.Models
{
    public class student
    {
        [Required (ErrorMessage ="Name is must")]
        [StringLength(15,MinimumLength =3,ErrorMessage="Name must be in mimimum 3 to maximum 15 character")]
        public string Name{ get; set; }

        [Required(ErrorMessage ="Surname is must") ]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Surname must be in mimimum 3 to maximum 15 character")]
        public string Surname { get; set; }

      

        [EmailAddress(ErrorMessage ="Email is must")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Email must be in mimimum 5 to maximum 25 character")]
        public string Email { get; set; }
        


        [Required (ErrorMessage ="Age should be in number")]
        [StringLength(90, MinimumLength = 5, ErrorMessage = "Age must be in mimimum 5 to maximum 90 character")]

        public int Age { get; set; }




    }
}
