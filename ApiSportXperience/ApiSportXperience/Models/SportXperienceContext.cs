using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiSportXperience.Models;

public partial class SportXperienceContext : DbContext
{
    public SportXperienceContext()
    {
    }

    public SportXperienceContext(DbContextOptions<SportXperienceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Lot> Lots { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Option> Options { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<RecommendedLevel> RecommendedLevels { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Sport> Sports { get; set; }

    public virtual DbSet<Ubication> Ubications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress; Trusted_Connection=True; Encrypt=false; Database=SportXperience");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Event__7944C810CEAE430E");

            entity.ToTable("Event");

            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.MaxAge).HasColumnName("maxAge");
            entity.Property(e => e.MaxParticipantsNumber).HasColumnName("maxParticipantsNumber");
            entity.Property(e => e.MinAge).HasColumnName("minAge");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Reward)
                .HasMaxLength(200)
                .HasColumnName("reward");
            entity.Property(e => e.StartDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("startDate");

            entity.HasOne(d => d.RecommendedLevel).WithMany(p => p.Events)
                .HasForeignKey(d => d.RecommendedLevelId)
                .HasConstraintName("FK__Event__Recommend__5535A963");

            entity.HasOne(d => d.Sport).WithMany(p => p.Events)
                .HasForeignKey(d => d.SportId)
                .HasConstraintName("FK__Event__SportId__5629CD9C");

            entity.HasOne(d => d.Ubication).WithMany(p => p.Events)
                .HasForeignKey(d => d.UbicationId)
                .HasConstraintName("FK__Event__Ubication__5441852A");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__Gender__4E24E9F7E71BED1D");

            entity.ToTable("Gender");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Lot>(entity =>
        {
            entity.HasKey(e => e.LotId).HasName("PK__Lot__4160EFADBB06B595");

            entity.ToTable("Lot");

            entity.HasOne(d => d.Event).WithMany(p => p.Lots)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Lot__EventId__5CD6CB2B");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Message__C87C0C9CD509C32E");

            entity.ToTable("Message");

            entity.Property(e => e.Comment)
                .HasColumnType("ntext")
                .HasColumnName("comment");
            entity.Property(e => e.PublicMessage).HasColumnName("publicMessage");
            entity.Property(e => e.PublishedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("publishedDate");
            entity.Property(e => e.UserDni).HasMaxLength(9);

            entity.HasOne(d => d.Event).WithMany(p => p.Messages)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Message__EventId__59FA5E80");

            entity.HasOne(d => d.UserDniNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.UserDni)
                .HasConstraintName("FK__Message__UserDni__59063A47");
        });

        modelBuilder.Entity<Option>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PK__Options__92C7A1FF74981288");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");

            entity.HasOne(d => d.Product).WithMany(p => p.Options)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Options__Product__628FA481");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => new { e.EventId, e.UserDni }).HasName("PK__Particip__9BBCF967725EDEF3");

            entity.ToTable("Participant");

            entity.Property(e => e.UserDni).HasMaxLength(9);
            entity.Property(e => e.Organizer).HasColumnName("organizer");

            entity.HasOne(d => d.Event).WithMany(p => p.Participants)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__Event__656C112C");

            entity.HasOne(d => d.UserDniNavigation).WithMany(p => p.Participants)
                .HasForeignKey(d => d.UserDni)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__UserD__66603565");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDA8DC549D");

            entity.ToTable("Product");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");

            entity.HasOne(d => d.Lot).WithMany(p => p.Products)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK__Product__LotId__5FB337D6");
        });

        modelBuilder.Entity<RecommendedLevel>(entity =>
        {
            entity.HasKey(e => e.RecommendedLevelId).HasName("PK__Recommen__401340A542AF7707");

            entity.ToTable("RecommendedLevel");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__Result__976902081C075B00");

            entity.ToTable("Result");

            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.UserDni).HasMaxLength(9);

            entity.HasOne(d => d.Participant).WithMany(p => p.Results)
                .HasForeignKey(d => new { d.EventId, d.UserDni })
                .HasConstraintName("FK__Result__693CA210");
        });

        modelBuilder.Entity<Sport>(entity =>
        {
            entity.HasKey(e => e.SportId).HasName("PK__Sport__7A41AF3CAE1B57EB");

            entity.ToTable("Sport");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Ubication>(entity =>
        {
            entity.HasKey(e => e.UbicationId).HasName("PK__Ubicatio__008819ECE9A2E7D1");

            entity.ToTable("Ubication");

            entity.Property(e => e.CityName)
                .HasMaxLength(200)
                .HasColumnName("cityName");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Dni).HasName("PK__Users__D87608A604D62960");

            entity.Property(e => e.Dni)
                .HasMaxLength(9)
                .HasColumnName("dni");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birthDate");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("lastName");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .HasColumnName("mail");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Gender).WithMany(p => p.Users)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK__Users__GenderId__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
