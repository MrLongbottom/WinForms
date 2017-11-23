﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormSolution.Models
{
    [Table("customers")]
    public class Customer
    {
        public int ID { get; set; }
        public List<Project> Projects { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Cvr { get; set; }
    }
}