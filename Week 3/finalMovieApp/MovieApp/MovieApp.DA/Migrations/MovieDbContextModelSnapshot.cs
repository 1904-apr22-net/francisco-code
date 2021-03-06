﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.DA;

namespace MovieApp.DA.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieApp.DA.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("MovieApp.DA.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GenreId");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("DATETIME2");

                    b.Property<string>("Title")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            ReleaseDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Star Wars IV"
                        });
                });

            modelBuilder.Entity("MovieApp.DA.Entities.Movie", b =>
                {
                    b.HasOne("MovieApp.DA.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
