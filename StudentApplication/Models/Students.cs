using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApplication.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GenderOfBirth { get; set; }
        public string? landlineNumber { get; set; }
        public string? CellPhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryOfBirth { get; set; }
        public DateTime? ImmigrationDate { get; set; }
        public string Nationality { get; set; }
        public string Institution { get; set; }

        public DateTime? ExportDate { get; set; }
    }
}
