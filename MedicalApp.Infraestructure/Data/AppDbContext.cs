using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MedicalApp.Domain.Authentication;
using MedicalApp.Domain.Entities.EmpleadoFolder;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infraestructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Patient> Patients { get; set; }
        public DbSet<RefreshToken> RefreshTokens {get; set;}
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<HorarioConsulta> HorarioConsultas { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<ApplicationUser>().ToTable("Users");
        //    modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        //    modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        //    modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        //    modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        //    modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        //    modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        //}
    }
}
