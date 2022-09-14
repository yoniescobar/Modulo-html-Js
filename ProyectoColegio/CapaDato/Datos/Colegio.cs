using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CapaDato.Models;

namespace CapaDato.Datos
{
    public partial class Colegio : DbContext
    {
        public Colegio()
        {
        }

        public Colegio(DbContextOptions<Colegio> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<aspnet_Application> aspnet_Applications { get; set; } = null!;
        public virtual DbSet<aspnet_Membership> aspnet_Memberships { get; set; } = null!;
        public virtual DbSet<aspnet_Path> aspnet_Paths { get; set; } = null!;
        public virtual DbSet<aspnet_PersonalizationAllUser> aspnet_PersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<aspnet_Profile> aspnet_Profiles { get; set; } = null!;
        public virtual DbSet<aspnet_Role> aspnet_Roles { get; set; } = null!;
        public virtual DbSet<aspnet_SchemaVersion> aspnet_SchemaVersions { get; set; } = null!;
        public virtual DbSet<aspnet_User> aspnet_Users { get; set; } = null!;
        public virtual DbSet<aspnet_WebEvent_Event> aspnet_WebEvent_Events { get; set; } = null!;
        public virtual DbSet<vw_aspnet_Application> vw_aspnet_Applications { get; set; } = null!;
        public virtual DbSet<vw_aspnet_MembershipUser> vw_aspnet_MembershipUsers { get; set; } = null!;
        public virtual DbSet<vw_aspnet_Profile> vw_aspnet_Profiles { get; set; } = null!;
        public virtual DbSet<vw_aspnet_Role> vw_aspnet_Roles { get; set; } = null!;
        public virtual DbSet<vw_aspnet_User> vw_aspnet_Users { get; set; } = null!;
        public virtual DbSet<vw_aspnet_UsersInRole> vw_aspnet_UsersInRoles { get; set; } = null!;
        public virtual DbSet<vw_aspnet_WebPartState_Path> vw_aspnet_WebPartState_Paths { get; set; } = null!;
        public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shareds { get; set; } = null!;
        public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=MSI; Initial Catalog=Colegio; user id=soporte; password=12003906;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGrade");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectGrade");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Membersh__1788CC4C1A0BA89A");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MembershipApplication");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Membership)
                    .HasForeignKey<Membership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MembershipUser");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Parent)
                    .HasForeignKey<Parent>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parents_diameterUsers");

                entity.HasMany(d => d.Students_Users)
                    .WithMany(p => p.Parents_Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "ParentStudent",
                        l => l.HasOne<Student>().WithMany().HasForeignKey("Students_UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParentStudent_Student"),
                        r => r.HasOne<Parent>().WithMany().HasForeignKey("Parents_UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParentStudent_Parent"),
                        j =>
                        {
                            j.HasKey("Parents_UserId", "Students_UserId").IsClustered(false);

                            j.ToTable("ParentStudent");

                            j.HasIndex(new[] { "Students_UserId" }, "IX_FK_ParentStudent_Student");
                        });
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Profiles__1788CC4C9C9BD57E");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Profile)
                    .HasForeignKey<Profile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserProfile");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleApplication");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.TeacherUser)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TeacherUserId)
                    .HasConstraintName("FK_TeacherStudent");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_diameterUsers");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Teacher)
                    .HasForeignKey<Teacher>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teachers_diameterUsers");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.UserPassword).HasDefaultValueSql("('password')");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserApplication");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UsersInRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("UsersInRoleRole"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("UsersInRoleUser"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__UsersInR__AF2760AD4EED00D6");

                            j.ToTable("UsersInRoles");
                        });
            });

            modelBuilder.Entity<aspnet_Application>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98C3FA1CF0")
                    .IsClustered(false);

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<aspnet_Membership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D92752A59")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.aspnet_Memberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__160F4887");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.aspnet_Membership)
                    .HasForeignKey<aspnet_Membership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__17036CC0");
            });

            modelBuilder.Entity<aspnet_Path>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC581480E6A7")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.aspnet_Paths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__17F790F9");
            });

            modelBuilder.Entity<aspnet_PersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5930A47512");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.aspnet_PersonalizationAllUser)
                    .HasForeignKey<aspnet_PersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__18EBB532");
            });

            modelBuilder.Entity<aspnet_PersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC069FE20D2C")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.aspnet_PersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__19DFD96B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnet_PersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__1AD3FDA4");
            });

            modelBuilder.Entity<aspnet_Profile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C90FD5728");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.aspnet_Profile)
                    .HasForeignKey<aspnet_Profile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__1BC821DD");
            });

            modelBuilder.Entity<aspnet_Role>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B3FB72BC4")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.aspnet_Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__1CBC4616");
            });

            modelBuilder.Entity<aspnet_SchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1556CB669");
            });

            modelBuilder.Entity<aspnet_User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4DAC3E3596")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.aspnet_Users)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__1DB06A4F");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "aspnet_UsersInRole",
                        l => l.HasOne<aspnet_Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__1EA48E88"),
                        r => r.HasOne<aspnet_User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__1F98B2C1"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760ADD810A8D8");

                            j.ToTable("aspnet_UsersInRoles");

                            j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                        });
            });

            modelBuilder.Entity<aspnet_WebEvent_Event>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C8102973169A");

                entity.Property(e => e.EventId).IsFixedLength();
            });

            modelBuilder.Entity<vw_aspnet_Application>(entity =>
            {
                entity.ToView("vw_aspnet_Applications");
            });

            modelBuilder.Entity<vw_aspnet_MembershipUser>(entity =>
            {
                entity.ToView("vw_aspnet_MembershipUsers");
            });

            modelBuilder.Entity<vw_aspnet_Profile>(entity =>
            {
                entity.ToView("vw_aspnet_Profiles");
            });

            modelBuilder.Entity<vw_aspnet_Role>(entity =>
            {
                entity.ToView("vw_aspnet_Roles");
            });

            modelBuilder.Entity<vw_aspnet_User>(entity =>
            {
                entity.ToView("vw_aspnet_Users");
            });

            modelBuilder.Entity<vw_aspnet_UsersInRole>(entity =>
            {
                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<vw_aspnet_WebPartState_Path>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_Paths");
            });

            modelBuilder.Entity<vw_aspnet_WebPartState_Shared>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_Shared");
            });

            modelBuilder.Entity<vw_aspnet_WebPartState_User>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
