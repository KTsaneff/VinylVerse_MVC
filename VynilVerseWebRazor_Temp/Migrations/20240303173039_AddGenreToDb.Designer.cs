﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VynilVerseWebRazor_Temp.Data;

#nullable disable

namespace VynilVerseWebRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240303173039_AddGenreToDb")]
    partial class AddGenreToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VynilVerseWebRazor_Temp.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Country"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Electronic"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Funk"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Latin"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Pop"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Punk"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Reggae"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Rock"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}