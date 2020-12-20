﻿// <auto-generated />
using EFCoreBasic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreBasic.Migrations
{
    [DbContext(typeof(GardenContext))]
    partial class GardenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EFCoreBasic.Bed", b =>
                {
                    b.Property<int>("BedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GardenId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("BedId");

                    b.HasIndex("GardenId");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("EFCoreBasic.Crop", b =>
                {
                    b.Property<int>("CropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CropId");

                    b.ToTable("Crops");
                });

            modelBuilder.Entity("EFCoreBasic.CropAssignment", b =>
                {
                    b.Property<int>("CropAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BedId")
                        .HasColumnType("int");

                    b.Property<int>("CropId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CropAssignmentId");

                    b.HasIndex("BedId");

                    b.HasIndex("CropId");

                    b.ToTable("CropAssignments");
                });

            modelBuilder.Entity("EFCoreBasic.Garden", b =>
                {
                    b.Property<int>("GardenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GardenId");

                    b.ToTable("Gardens");
                });

            modelBuilder.Entity("EFCoreBasic.Bed", b =>
                {
                    b.HasOne("EFCoreBasic.Garden", "Garden")
                        .WithMany("Beds")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garden");
                });

            modelBuilder.Entity("EFCoreBasic.CropAssignment", b =>
                {
                    b.HasOne("EFCoreBasic.Bed", "Bed")
                        .WithMany("CropAssignments")
                        .HasForeignKey("BedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreBasic.Crop", "Crop")
                        .WithMany("CropAssignments")
                        .HasForeignKey("CropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bed");

                    b.Navigation("Crop");
                });

            modelBuilder.Entity("EFCoreBasic.Bed", b =>
                {
                    b.Navigation("CropAssignments");
                });

            modelBuilder.Entity("EFCoreBasic.Crop", b =>
                {
                    b.Navigation("CropAssignments");
                });

            modelBuilder.Entity("EFCoreBasic.Garden", b =>
                {
                    b.Navigation("Beds");
                });
#pragma warning restore 612, 618
        }
    }
}
