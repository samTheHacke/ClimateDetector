using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace climate.Models
{
    public partial class WeatherDBContext : DbContext
    {
        public WeatherDBContext()
        {
        }

        public WeatherDBContext(DbContextOptions<WeatherDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<WeatherDetail> WeatherDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WeatherDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__userDeta__DD701264925AED12");

                entity.ToTable("userDetails");

                entity.Property(e => e.Uid)
                    .ValueGeneratedNever()
                    .HasColumnName("uid");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<WeatherDetail>(entity =>
            {
                entity.HasKey(e => e.Wid)
                    .HasName("PK__WeatherD__30F153BB0FC3BD7B");

                entity.Property(e => e.Wid)
                    .ValueGeneratedNever()
                    .HasColumnName("wid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Humidity).HasColumnName("humidity");

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.Property(e => e.Visibility).HasColumnName("visibility");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
