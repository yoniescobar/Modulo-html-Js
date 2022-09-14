using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public Guid UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(20)]
        public string Class { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("Teacher")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("TeacherUser")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
