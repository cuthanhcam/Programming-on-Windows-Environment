namespace Session_08.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(6)]
        public string StudentID { get; set; }

        [StringLength(40)]
        public string StudentName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(3)]
        public string ClassID { get; set; }

        public virtual Class Class { get; set; }
    }
}
