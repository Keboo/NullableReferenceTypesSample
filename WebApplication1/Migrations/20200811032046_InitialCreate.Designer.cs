﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20200811032046_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("WebApplication1.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WebApplication1.WeatherEvent", b =>
                {
                    b.Property<int>("WeatherEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("WeatherEventId");

                    b.HasIndex("LocationId");

                    b.ToTable("WeatherEvents");
                });

            modelBuilder.Entity("WebApplication1.WeatherEvent", b =>
                {
                    b.HasOne("WebApplication1.Location", "Blog")
                        .WithMany("Events")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}