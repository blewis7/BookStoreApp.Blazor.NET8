using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data;

public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
{
    public BookStoreDbContext()
    {
    }

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC072BD00103");

            entity.Property(e => e.Bio).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC0739DB17D5");

            entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EA36CC5CA7").IsUnique();

            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Summary).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_Books_Authors");
        });


        modelBuilder.Entity<IdentityRole>().HasData(
           new IdentityRole
           {
               Name = "User",
               NormalizedName = "USER",
               Id = "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d"
           },
           new IdentityRole
           {
               Name = "Administrator",
               NormalizedName = "ADMINISTRATOR",
               Id = "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c"
           }
       );

        //var hasher = new PasswordHasher<ApiUser>();
        //string adminHash = hasher.HashPassword(null, "P@ssword1");

        modelBuilder.Entity<ApiUser>().HasData(
            new ApiUser
            {
                Id = "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b",
                Email = "admin@bookstore.com",
                NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                UserName = "admin@bookstore.com",
                NormalizedUserName = "ADMIN@BOOKSTORE.COM",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = "1f3c53ae14626035383b39c207564d32d083e8fd",
                ConcurrencyStamp = "a1111111-b222-c333-d444-e55555555555",
                SecurityStamp = "f1111111-g222-h333-i444-j55555555555"
            },
            new ApiUser
            {
                Id = "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9",
                Email = "user@bookstore.com",
                NormalizedEmail = "USER@BOOKSTORE.COM",
                UserName = "user@bookstore.com",
                NormalizedUserName = "USER@BOOKSTORE.COM",
                FirstName = "System",
                LastName = "User",
                PasswordHash = "1f3c53ae14626035383b39c207564d32d083e8fd",
                ConcurrencyStamp = "k1111111-l222-m333-n444-o55555555555",
                SecurityStamp = "p1111111-q222-r333-s444-t55555555555"
            }
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d",
                UserId = "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9"
            },
            new IdentityUserRole<string>
            {
                RoleId = "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c",
                UserId = "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b"
            }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
