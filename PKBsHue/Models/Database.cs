using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKBsHue.Models
{
    public class Database : DbContext
    {
        public Database(){
            
        }
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
        public virtual DbSet<BenhNhanModel> BenhNhanModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                optionsBuilder.UseSqlServer("ServerLAPTOP-DCE5GAKD\\SQLEXPRESS;Database=TestDB;Trusted_Connection=True;");

            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BenhNhanModel>(entity =>

            {

                entity.ToTable("BenhNhan");

                entity.Property(e => e.CMND)

                    .HasMaxLength(50)

                    .IsUnicode(false);

                entity.Property(e => e.HoTen)

                    .HasMaxLength(50)

                    .IsUnicode(false);

                entity.Property(e => e.MaBN)

                    .HasMaxLength(50)

                    .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
