using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_CRUDUsingEF.Models
{
    [MetadataType(typeof(TrainerMetadata))]
    public partial class Trainer
    {
        [Required]
        [Compare("Email", ErrorMessage = "Email and Confirm Email should be same")]
        public string ConfirmEmail { get; set; }
    }

    public class TrainerMetadata
    {
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should have 3 to 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter experience")]
        [Range(8, 15, ErrorMessage = "Experience should be between 8 and 15 years")]
        public Nullable<int> Experience { get; set; }

        [Required(ErrorMessage = "Please enter city")]
        [MaxLength(10, ErrorMessage = "City should have maximum 10 characters")]
        [MinLength(4, ErrorMessage = "City should have more than 4 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Email is required")]
        // [RegularExpression(@ "[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid Email")]
        // [EmailAddress(ErrorMessage = "Invalid Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date")]
        // [Range(18, 40, ErrorMessage = "Age should be between 18 to 40 years")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    }
}