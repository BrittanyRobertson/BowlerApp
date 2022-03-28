﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BowlerApp.Models
{
    public class Bowler
    {
        [Required]
        [Key]
        public int BowlerID { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }
        public int TeamID { get; set; }
    }
}
