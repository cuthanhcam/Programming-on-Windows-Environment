namespace Lab04_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(11)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        public int FacultyID { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
