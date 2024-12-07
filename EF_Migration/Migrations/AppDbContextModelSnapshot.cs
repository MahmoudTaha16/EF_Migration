﻿// <auto-generated />
using EF_Migration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Migration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Migration.Utilities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int");

                    b.Property<int>("instructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("instructorId");

                    b.ToTable("Courses", "Co");
                });

            modelBuilder.Entity("EF_Migration.Utilities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Instructors", "Co");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bajour",
                            Name = "Mahmoud",
                            salary = 30000m
                        },
                        new
                        {
                            Id = 2,
                            Address = "shebin",
                            Name = "Taha",
                            salary = 20000m
                        },
                        new
                        {
                            Id = 3,
                            Address = "Menofia",
                            Name = "Issam",
                            salary = 60000m
                        });
                });

            modelBuilder.Entity("EF_Migration.Utilities.Course", b =>
                {
                    b.HasOne("EF_Migration.Utilities.Instructor", "instructor")
                        .WithMany()
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
