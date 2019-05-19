using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagement.Models
{
    public class Contact
    {
        
        public int ContactId { get; set; } //initialize the id

        [Required] //make sure not empty
        [Display(Name = "First Name*", Prompt = "Please enter the contact's name")]
        public string FirstName { get; set; } //initialize the FirstName

        [Required] //make sure not empty
        [Display(Name = "Last Name*", Prompt = "Please enter the contact's surname")]
        public string LastName { get; set; } //initialize the LastName

        [Required] //make sure not empty
        [EmailAddress] //make sure that is valid email address
        [Display(Name = "Email*", Prompt = "Please enter a valid email address")]
        public string Email { get; set; } //initialize the Email

        public string Address { get; set; } //initialize the Address

        [Phone]
        public string Phone { get; set; } //initialize the 

        [Phone]
        public string Phone2 { get; set; } //initialize the 

        [Phone]
        public string Phone3 { get; set; } //initialize the 

        internal void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
