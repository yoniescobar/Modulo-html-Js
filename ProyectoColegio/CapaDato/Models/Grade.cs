using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Index("StudentUserId", Name = "IX_FK_StudentGrade")]
    [Index("SubjectId", Name = "IX_FK_SubjectGrade")]
    public partial class Grade
    {
        [Key]
        public int Id { get; set; }
        public string Assessment { get; set; } = null!;
        public string? Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AssessmentDate { get; set; }
        public int SubjectId { get; set; }
        public Guid StudentUserId { get; set; }

        [ForeignKey("StudentUserId")]
        [InverseProperty("Grades")]
        public virtual Student StudentUser { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("Grades")]
        public virtual Subject Subject { get; set; } = null!;
    }
}
