﻿// <auto-generated />
using System;
using ELearning.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ELearning.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200922054658_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ELearning.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DateOfBirth = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Nishant",
                            LastName = "Pathak"
                        },
                        new
                        {
                            StudentId = 2,
                            DateOfBirth = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Gaurang",
                            LastName = "Majethiya"
                        });
                });

            modelBuilder.Entity("ELearning.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 8, 60, 33, 144, 30, 0, 224, 85, 137, 76, 94, 15, 48, 100, 173, 137, 98, 44, 246, 17, 164, 134, 147, 65, 105, 169, 111, 24, 143, 92, 132, 215, 62, 128, 242, 92, 127, 62, 180, 37, 40, 18, 196, 121, 48, 66, 187, 201, 5, 18, 63, 220, 98, 239, 94, 92, 255, 26, 152, 133, 134, 107, 41, 191 },
                            PasswordSalt = new byte[] { 129, 156, 246, 179, 159, 80, 207, 25, 43, 168, 54, 187, 255, 162, 73, 160, 80, 113, 179, 145, 225, 249, 124, 105, 12, 132, 122, 14, 240, 157, 132, 38, 10, 116, 170, 1, 159, 233, 82, 152, 174, 10, 77, 247, 42, 131, 66, 51, 146, 35, 176, 206, 248, 82, 93, 222, 120, 152, 2, 105, 133, 145, 235, 97, 1, 83, 5, 160, 56, 117, 58, 77, 124, 10, 157, 142, 130, 21, 116, 83, 61, 147, 79, 55, 113, 163, 223, 173, 186, 113, 223, 41, 137, 137, 244, 62, 71, 139, 99, 153, 35, 108, 170, 143, 11, 107, 45, 163, 116, 165, 66, 132, 237, 198, 236, 197, 52, 182, 13, 183, 251, 120, 182, 170, 57, 66, 154, 53 },
                            UserName = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
