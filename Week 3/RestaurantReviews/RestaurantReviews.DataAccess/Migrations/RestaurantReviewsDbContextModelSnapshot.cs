﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReviews.DataAccess.Entities;

namespace RestaurantReviews.DataAccess.Migrations
{
    [DbContext(typeof(RestaurantReviewsDbContext))]
    partial class RestaurantReviewsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantReviews.DataAccess.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Restaurant","RR");
                });

            modelBuilder.Entity("RestaurantReviews.DataAccess.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantId")
                        .HasColumnName("RestaurantID");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Score");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Review","RR");
                });

            modelBuilder.Entity("RestaurantReviews.DataAccess.Entities.Review", b =>
                {
                    b.HasOne("RestaurantReviews.DataAccess.Entities.Restaurant", "Restaurant")
                        .WithMany("Review")
                        .HasForeignKey("RestaurantId")
                        .HasConstraintName("FK_Review_Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}
