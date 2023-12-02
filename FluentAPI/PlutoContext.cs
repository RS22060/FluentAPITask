using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(t => t.Tags)
                .WithMany(t => t.Courses);

            modelBuilder.Entity<Course>()
                .Property(t => t.Price)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(t => t.Name)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Lecturer>()
                .HasMany(t => t.Courses)
                .WithRequired(t => t.Lecturer);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.Courses)
                .WithMany(t => t.Tags);

            base.OnModelCreating(modelBuilder);
        }
    }
}