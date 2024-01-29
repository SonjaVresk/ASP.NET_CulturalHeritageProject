using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CulturalHeritageBL.DALModels
{
    public partial class CulturalHeritageContext : DbContext
    {
        public CulturalHeritageContext()
        {
        }

        public CulturalHeritageContext(DbContextOptions<CulturalHeritageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgeCategory> AgeCategories { get; set; } = null!;
        public virtual DbSet<Exhibition> Exhibitions { get; set; } = null!;
        public virtual DbSet<ExhibitionPhotography> ExhibitionPhotographies { get; set; } = null!;
        public virtual DbSet<ExhibitionVideo> ExhibitionVideos { get; set; } = null!;
        public virtual DbSet<Heritage> Heritages { get; set; } = null!;
        public virtual DbSet<HeritageCategory> HeritageCategories { get; set; } = null!;
        public virtual DbSet<Photography> Photographies { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeCategory>(entity =>
            {
                entity.HasKey(e => e.IDAgeCategory)
                    .HasName("PK__AgeCateg__F5A7BF491A365FC4");

                entity.ToTable("AgeCategory");

                entity.Property(e => e.IDAgeCategory).HasColumnName("IDAgeCategory");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<Exhibition>(entity =>
            {
                entity.HasKey(e => e.IDExhibition)
                    .HasName("PK__Exhibiti__F55143D9BA202626");

                entity.ToTable("Exhibition");

                entity.Property(e => e.IDExhibition).HasColumnName("IDExhibition");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.HeritageId).HasColumnName("HeritageID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Heritage)
                    .WithMany(p => p.Exhibitions)
                    .HasForeignKey(d => d.HeritageId)
                    .HasConstraintName("FK__Exhibitio__Herit__4AB81AF0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Exhibitions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Exhibitio__UserI__4BAC3F29");
            });

            modelBuilder.Entity<ExhibitionPhotography>(entity =>
            {
                entity.HasKey(e => e.IDExhibitionPhoto)
                    .HasName("PK__Exhibiti__D342C5CDC9107F25");

                entity.ToTable("ExhibitionPhotography");

                entity.Property(e => e.IDExhibitionPhoto).HasColumnName("IDExhibitionPhoto");

                entity.Property(e => e.ExhibitionId).HasColumnName("ExhibitionID");

                entity.Property(e => e.PhotographyId).HasColumnName("PhotographyID");

                entity.HasOne(d => d.Exhibition)
                    .WithMany(p => p.ExhibitionPhotographies)
                    .HasForeignKey(d => d.ExhibitionId)
                    .HasConstraintName("FK__Exhibitio__Exhib__4E88ABD4");

                entity.HasOne(d => d.Photography)
                    .WithMany(p => p.ExhibitionPhotographies)
                    .HasForeignKey(d => d.PhotographyId)
                    .HasConstraintName("FK__Exhibitio__Photo__4F7CD00D");
            });

            modelBuilder.Entity<ExhibitionVideo>(entity =>
            {
                entity.HasKey(e => e.IDExhibitionVideo)
                    .HasName("PK__Exhibiti__362E2076B564CC7C");

                entity.ToTable("ExhibitionVideo");

                entity.Property(e => e.IDExhibitionVideo).HasColumnName("IDExhibitionVideo");

                entity.Property(e => e.ExhibitionId).HasColumnName("ExhibitionID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.Exhibition)
                    .WithMany(p => p.ExhibitionVideos)
                    .HasForeignKey(d => d.ExhibitionId)
                    .HasConstraintName("FK__Exhibitio__Exhib__6FE99F9F");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.ExhibitionVideos)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK__Exhibitio__Video__70DDC3D8");
            });

            modelBuilder.Entity<Heritage>(entity =>
            {
                entity.HasKey(e => e.IDHeritage)
                    .HasName("PK__Heritage__FBBC95B02FCCF8E3");

                entity.ToTable("Heritage");

                entity.Property(e => e.IDHeritage).HasColumnName("IDHeritage");

                entity.Property(e => e.AgeCategoryId).HasColumnName("AgeCategoryID");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.HeritageCategoryId).HasColumnName("HeritageCategoryID");

                entity.Property(e => e.Title).HasMaxLength(300);

                entity.HasOne(d => d.AgeCategory)
                    .WithMany(p => p.Heritages)
                    .HasForeignKey(d => d.AgeCategoryId)
                    .HasConstraintName("FK__Heritage__AgeCat__412EB0B6");

                entity.HasOne(d => d.HeritageCategory)
                    .WithMany(p => p.Heritages)
                    .HasForeignKey(d => d.HeritageCategoryId)
                    .HasConstraintName("FK__Heritage__Herita__403A8C7D");
            });

            modelBuilder.Entity<HeritageCategory>(entity =>
            {
                entity.HasKey(e => e.IDHeritageCategory)
                    .HasName("PK__Heritage__9CEE6DBC2C32F251");

                entity.ToTable("HeritageCategory");

                entity.Property(e => e.IDHeritageCategory).HasColumnName("IDHeritageCategory");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<Photography>(entity =>
            {
                entity.HasKey(e => e.IDPhotography)
                    .HasName("PK__Photogra__5A08DD8E96C939CF");

                entity.ToTable("Photography");

                entity.Property(e => e.IDPhotography).HasColumnName("IDPhotography");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.HeritageId).HasColumnName("HeritageID");

                entity.Property(e => e.PicturePath).HasMaxLength(300);

                entity.HasOne(d => d.Heritage)
                    .WithMany(p => p.Photographies)
                    .HasForeignKey(d => d.HeritageId)
                    .HasConstraintName("FK__Photograp__Herit__440B1D61");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IDRole)
                    .HasName("PK__Role__A1BA16C4B3B74BEB");

                entity.ToTable("Role");

                entity.Property(e => e.IDRole).HasColumnName("IDRole");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IDUser)
                    .HasName("PK__User__EAE6D9DF19803D4B");

                entity.ToTable("User");

                entity.Property(e => e.IDUser).HasColumnName("IDUser");

                entity.Property(e => e.FirstName).HasMaxLength(300);

                entity.Property(e => e.LastName).HasMaxLength(300);

                entity.Property(e => e.Password).HasMaxLength(90);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username).HasMaxLength(300);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__User__RoleID__398D8EEE");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.IDVideo)
                    .HasName("PK__Video__6521D6B33F9CDDCB");

                entity.ToTable("Video");

                entity.Property(e => e.IDVideo).HasColumnName("IDVideo");

                entity.Property(e => e.Description).HasMaxLength(900);

                entity.Property(e => e.HeritageId).HasColumnName("HeritageID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VideoPath).HasMaxLength(300);

                entity.HasOne(d => d.Heritage)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.HeritageId)
                    .HasConstraintName("FK__Video__HeritageI__46E78A0C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Video__UserID__47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
