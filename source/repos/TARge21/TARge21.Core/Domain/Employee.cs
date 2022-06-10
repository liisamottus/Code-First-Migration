using System;
using System.ComponentModel.DataAnnotations;

namespace TARge21.Core
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}