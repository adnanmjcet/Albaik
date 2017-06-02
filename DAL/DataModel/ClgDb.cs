namespace DAL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClgDb : DbContext
    {
        public ClgDb()
            : base("name=ClgDb")
        {
        }

        public virtual DbSet<Canteen> Canteens { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Canteen>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Canteen>()
                .Property(e => e.MenuType)
                .IsUnicode(false);

            modelBuilder.Entity<Canteen>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<College>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Affiliation)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Contactno)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Hods)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phoneno)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.AcademicYear)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsFixedLength();
        }
    }
}
