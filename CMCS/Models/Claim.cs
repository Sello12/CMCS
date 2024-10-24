using System;
using System.ComponentModel.DataAnnotations;

namespace CMCS.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }  // Primary Key

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public double HoursWorked { get; set; }

        [Required]
        public double HourlyRate { get; set; }

        public string Notes { get; set; }

        public DateTime SubmittedOn { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending";
    }
}

