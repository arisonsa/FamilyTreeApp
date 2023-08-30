using System;

namespace FamilyTreeApp.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? EndDate { get; set; }
        public string Biography { get; set; }
    }
}