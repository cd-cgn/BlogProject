//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

//namespace BlogMS.Major.Models
//{
//    public partial class BlogDBContext : DbContext
//    {
//        public BlogDBContext()
//        {
//        }

//        public BlogDBContext(DbContextOptions<BlogDBContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Blog> Blogs { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=localhost;initial catalog=MyTestDB;Integrated Security=True;ConnectRetryCount=0");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Blog>(entity =>
//            {
//                entity.ToTable("blog");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Author)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("author");

//                entity.Property(e => e.Body)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("body");

//                entity.Property(e => e.Title)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("title");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
