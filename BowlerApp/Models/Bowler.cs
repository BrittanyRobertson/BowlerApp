using System;
using System.ComponentModel.DataAnnotations;

namespace BowlerApp.Models
{
    public class Bowler
    {
        [Required]
        [Key]
        public int BowlerID { get; set; }

        [StringLength(50, ErrorMessage="Max Length for Last Name is 50 characters")]
        public string BowlerLastName { get; set; }

        [StringLength(50, ErrorMessage = "Max Length for First Name is 50 characters")]
        public string BowlerFirstName { get; set; }

        [StringLength(1, ErrorMessage = "Max Length for Middle Initial is 1 character")]
        public string BowlerMiddleInit { get; set; }

        [StringLength(50, ErrorMessage = "Max Length for Last Name is 50 characters")]
        public string BowlerAddress { get; set; }

        [StringLength(50, ErrorMessage = "Max Length for City is 50 characters")]
        public string BowlerCity { get; set; }

        [StringLength(2, ErrorMessage = "Max Length for State is 2 characters")]
        public string BowlerState { get; set; }

        [StringLength(10, ErrorMessage = "Max Length for Zip Code is 10 characters")]
        public string BowlerZip { get; set; }

        [StringLength(14, ErrorMessage = "Max Length for Phone Number is 14 characters")]
        public string BowlerPhoneNumber { get; set; }

        // sets up foreign key relationship
        public int TeamID { get; set; }
        public Team Team { get; set; }
    }
}
