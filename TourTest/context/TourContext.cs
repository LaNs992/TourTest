
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TourTest.Models;
using Type = TourTest.Models.Type;

namespace TourTest.context
{
    public partial class TourContext : DbContext
    {
        public TourContext()
        {
        }

        public TourContext(DbContextOptions<TourContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<HotelComment> HotelComments { get; set; } = null!;
        public virtual DbSet<HotelImage> HotelImages { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Tour> Tours { get; set; } = null!;
        public virtual DbSet<Type> Types { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-URICGBM\\SQLEXPRESS;Database=Tour;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Country");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("Hotel");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hotel_Country");

                entity.HasMany(d => d.Tours)
                    .WithMany(p => p.Hotels)
                    .UsingEntity<Dictionary<string, object>>(
                        "HotelOfTour",
                        l => l.HasOne<Tour>().WithMany().HasForeignKey("TourId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_HotelOfTour_Tour"),
                        r => r.HasOne<Hotel>().WithMany().HasForeignKey("HotelId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_HotelOfTour_Hotel"),
                        j =>
                        {
                            j.HasKey("HotelId", "TourId");

                            j.ToTable("HotelOfTour");
                        });
            });

            modelBuilder.Entity<HotelComment>(entity =>
            {
                entity.ToTable("HotelComment");

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HotelComments)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HotelComment_Hotel");
            });

            modelBuilder.Entity<HotelImage>(entity =>
            {
                entity.ToTable("HotelImage");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HotelImages)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HotelImage_Hotel");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Order");

                entity.Property(e => e.DateOrder).HasColumnName("Date_Order");

                entity.Property(e => e.PickUpCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PickUpPoint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TourId).HasColumnName("Tour_id");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Tour");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Role");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Role");
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.ToTable("Tour");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.TourCountry)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.TourCountryNavigation)
                    .WithMany(p => p.Tours)
                    .HasForeignKey(d => d.TourCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_Country");

                entity.HasMany(d => d.Types)
                    .WithMany(p => p.Tours)
                    .UsingEntity<Dictionary<string, object>>(
                        "TypeOfTour",
                        l => l.HasOne<Type>().WithMany().HasForeignKey("TypeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TypeOfTour_Type"),
                        r => r.HasOne<Tour>().WithMany().HasForeignKey("TourId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TypeOfTour_Tour"),
                        j =>
                        {
                            j.HasKey("TourId", "TypeId");

                            j.ToTable("TypeOfTour");

                            j.IndexerProperty<string>("TypeId").HasMaxLength(50).IsUnicode(false);
                        });
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
