using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Index("TeacherUserId", Name = "IX_FK_TeacherStudent")]
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            Parents_Users = new HashSet<Parent>();
        }

        [Key]
        public Guid UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public Guid? TeacherUserId { get; set; }

        [ForeignKey("TeacherUserId")]
        [InverseProperty("Students")]
        public virtual Teacher? TeacherUser { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Student")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("StudentUser")]
        public virtual ICollection<Grade> Grades { get; set; }

        [ForeignKey("Students_UserId")]
        [InverseProperty("Students_Users")]
        public virtual ICollection<Parent> Parents_Users { get; set; }
    }
}
