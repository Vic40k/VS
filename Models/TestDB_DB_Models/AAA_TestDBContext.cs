using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Model
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<FactoryComponents> FactoryComponents { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=prosrvna.prometad.ru;Initial Catalog=TestDB;Persist Security Info=True;User ID=datasa;Password=KoSt55RoMa;Connection Timeout=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasDatabaseName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasDatabaseName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasDatabaseName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.DeviceCode)
                    .IsUnique();

                entity.HasIndex(e => e.Expiration);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<FactoryComponents>(entity =>
            {
                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AsCh)
                    .HasColumnName("AS_CH")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DNam)
                    .HasColumnName("D_NAM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatFirst)
                    .HasColumnName("DAT_FIRST")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLast)
                    .HasColumnName("DAT_LAST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDel)
                    .HasColumnName("DATA_DEL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dbenennung)
                    .HasColumnName("DBENENNUNG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flagview)
                    .HasColumnName("FLAGVIEW")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.KolGib)
                    .HasColumnName("KOL_GIB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolOnePodv)
                    .HasColumnName("KOL_ONE_PODV")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.KolPodv)
                    .HasColumnName("KOL_PODV")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolSv)
                    .HasColumnName("KOL_SV")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.LenSv)
                    .HasColumnName("LEN_SV")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LenSvZ)
                    .HasColumnName("LEN_SV_Z")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LitD)
                    .HasColumnName("LIT_D")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LustZon)
                    .HasColumnName("LUST_ZON")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialAjur)
                    .HasColumnName("MaterialAJUR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Артикул материала в базе данных программы АЖУР");

                entity.Property(e => e.Me)
                    .HasColumnName("ME")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.PrjName)
                    .HasColumnName("PRJ_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PullPlanMethod).HasColumnName("PULL_PLAN_METHOD");

                entity.Property(e => e.Rbenennung)
                    .HasColumnName("RBENENNUNG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSvZ)
                    .HasColumnName("S_SV_Z")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Smch)
                    .HasColumnName("SMCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supermarket).HasColumnName("SUPERMARKET");

                entity.Property(e => e.TimeLine)
                    .HasColumnName("TIME_LINE")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Unit39)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на ЗМК, Москва");

                entity.Property(e => e.Unit44)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на УЗМК, Узловая");

                entity.Property(e => e.Zag).HasColumnName("ZAG");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
