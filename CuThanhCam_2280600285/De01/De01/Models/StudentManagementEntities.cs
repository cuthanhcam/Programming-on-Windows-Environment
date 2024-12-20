using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De01.Models
{
    public partial class StudentManagementEntities : DbContext
    {
        public StudentManagementEntities()
            : base("name=StudentManagementEntities")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.ClassID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ClassID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
