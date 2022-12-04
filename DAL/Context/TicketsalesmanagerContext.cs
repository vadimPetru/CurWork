using CurWork.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CurWork.DAL.Context;

public partial class TicketsalesmanagerContext : DbContext
{
    public TicketsalesmanagerContext()
    {
    }

    public TicketsalesmanagerContext(DbContextOptions<TicketsalesmanagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Charterclient> Charterclients { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog = TICKETSALESMANAGER;Integrated Security=True;TrustServerCertificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Charterclient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHARTERC__3214EC2710453DC1");

            entity.ToTable("CHARTERCLIENTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
            entity.Property(e => e.Movieid).HasColumnName("MOVIEID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Charterclients)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("FK__CHARTERCL__CUSTO__2B3F6F97");

            entity.HasOne(d => d.Movie).WithMany(p => p.Charterclients)
                .HasForeignKey(d => d.Movieid)
                .HasConstraintName("FK__CHARTERCL__MOVIE__2C3393D0");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC277F04A7FA");

            entity.ToTable("CUSTOMERS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Surname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SURNAME");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MOVIE__3214EC27062FDF63");

            entity.ToTable("MOVIE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateOfRelease)
                .HasColumnType("date")
                .HasColumnName("DATE_OF_RELEASE");
            entity.Property(e => e.Genre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GENRE");
            entity.Property(e => e.Moviename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOVIENAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
