namespace eAdertisement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class eAdvertisementContext : DbContext
    {
        public eAdvertisementContext()
            : base("name=eAdvertisementContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<ExpiredVacancy> ExpiredVacancies { get; set; }
        public virtual DbSet<PendingVacancy> PendingVacancies { get; set; }
        public virtual DbSet<PublishedVacancy> PublishedVacancies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UnpublishedVacancy> UnpublishedVacancies { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ExpiredVacancy>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<PendingVacancy>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<PublishedVacancy>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<UnpublishedVacancy>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Attention)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Salary)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Centre)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.Duties)
                .IsUnicode(false);

            modelBuilder.Entity<Vacancy>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);
        }
    }
}
