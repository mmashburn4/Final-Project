﻿// <auto-generated />
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("Final_Project.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecordLabelID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArtistID");

                    b.HasIndex("RecordLabelID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Final_Project.Models.RecordLabel", b =>
                {
                    b.Property<int>("RecordLabelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("RecordLabelID");

                    b.ToTable("RecordLabels");
                });

            modelBuilder.Entity("Final_Project.Models.Artist", b =>
                {
                    b.HasOne("Final_Project.Models.RecordLabel", "RecordLabel")
                        .WithMany("Artists")
                        .HasForeignKey("RecordLabelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
