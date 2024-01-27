using HospitalApp.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Data.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Medication>()
                .HasOne(m => m.User)
                .WithMany(u => u.UserMedications)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Medication>()
                .HasOne(m => m.Doctor)
                .WithMany(u => u.DoctorMedications)
                .HasForeignKey(m => m.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Users)
                .WithMany(u => u.UserAppointments)
                .HasForeignKey(a => a.UsersId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctors)
                .WithMany(u => u.DoctorAppointments)
                .HasForeignKey(a => a.DoctorsId);

            modelBuilder.Entity<LaboratoryTest>()
                .HasOne(a => a.User)
                .WithMany(u => u.UserLaboratoryTests)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LaboratoryTest>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.DoctorLaboratoryTests)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<LaboratoryTest>()
                .HasOne(lt => lt.Hospital)
                .WithMany(h => h.LaboratoryTests)
                .HasForeignKey(lt => lt.HospitalId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Medication>()
          .HasOne(m => m.Hospital)
          .WithMany(h => h.Medications)
          .HasForeignKey(m => m.HospitalId)
          .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Hospital>()
                 .HasMany(h => h.Medications)
                 .WithOne(m => m.Hospital)
                 .HasForeignKey(m => m.HospitalId)
                 .OnDelete(DeleteBehavior.Restrict);


        }


        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugMedication> DrugMedications { get; set; }
        public DbSet<LaboratoryTest> LaboratoryTests { get; set; }
        public DbSet<Discharge> Discharges { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<UserHospitals> UserHospitals { get; set; }
        public DbSet<ConfirmEmailToken> ConfirmEmailTokens { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

    }



}
