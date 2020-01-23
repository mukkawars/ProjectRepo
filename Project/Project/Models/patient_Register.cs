//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class patient_Register
    {
        [Required(ErrorMessage = "This Feild is required.")]
        public string first_Name { get; set; }
        [Required(ErrorMessage = "This Feild is required.")]
        public string last_Name { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long mob_Number { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This Feild is required.")]
        public string password { get; set; }
   


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }



        [Required(ErrorMessage = "This Feild is required.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not valid")]
        public string email_Id { get; set; }



        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string dob { get; set; }
        [Display(Name = "Gender:")]
        [Required(ErrorMessage = "This Feild is required.")]
        public string sex { get; set; }
        [Required(ErrorMessage = "This Feild is required.")]
        public string address { get; set; }


        public string LoginErrorMessage { get; set; }
    }
}
