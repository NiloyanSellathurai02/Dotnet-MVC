﻿// <auto-generated />
using System;
using E_Sport_1A2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Sport_1A2.Migrations
{
    [DbContext(typeof(E_Sport_1A2Context))]
    [Migration("20240416101947_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Sport_1A2.Models.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Teamid")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Teamid");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("E_Sport_1A2.Models.Team", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("currentRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("playedGames")
                        .HasColumnType("int");

                    b.Property<int>("playersCount")
                        .HasColumnType("int");

                    b.Property<int>("won")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("E_Sport_1A2.Models.Player", b =>
                {
                    b.HasOne("E_Sport_1A2.Models.Team", null)
                        .WithMany("players")
                        .HasForeignKey("Teamid");
                });

            modelBuilder.Entity("E_Sport_1A2.Models.Team", b =>
                {
                    b.Navigation("players");
                });
#pragma warning restore 612, 618
        }
    }
}
