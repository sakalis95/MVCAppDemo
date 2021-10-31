﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcApp2;

namespace MvcApp2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211029164643_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcApp2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mindaugas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Petras"
                        });
                });

            modelBuilder.Entity("MvcApp2.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Damien Chazelle",
                            Name = "Whiplash",
                            Year = 2014
                        },
                        new
                        {
                            Id = 2,
                            Director = "Quentin Tarantino",
                            Name = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = 3,
                            Director = "Sergio Leone",
                            Name = "The Good, the Bad and the Ugly",
                            Year = 1966
                        },
                        new
                        {
                            Id = 4,
                            Director = "Sidney Lumet",
                            Name = "12 Angry Men",
                            Year = 1957
                        },
                        new
                        {
                            Id = 5,
                            Director = "Michel Gondry",
                            Name = "Eternal Sunshine of the Spotless Mind",
                            Year = 2004
                        },
                        new
                        {
                            Id = 6,
                            Director = "Milos Forman",
                            Name = "One Flew Over the Cuckoo's Nest",
                            Year = 1975
                        },
                        new
                        {
                            Id = 7,
                            Director = "Frank Darabont",
                            Name = "The Green Mile",
                            Year = 1999
                        },
                        new
                        {
                            Id = 8,
                            Director = "Roberto Benigni",
                            Name = "Life Is Beautiful",
                            Year = 1997
                        },
                        new
                        {
                            Id = 9,
                            Director = "Jean-Pierre Jeunet",
                            Name = "Amélie",
                            Year = 2001
                        },
                        new
                        {
                            Id = 10,
                            Director = "Luc Besson",
                            Name = "Léon: The Professional",
                            Year = 1994
                        });
                });
#pragma warning restore 612, 618
        }
    }
}