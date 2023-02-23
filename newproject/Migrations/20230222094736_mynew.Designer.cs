﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newproject.DBContext;

#nullable disable

namespace newproject.Migrations
{
    [DbContext(typeof(MidWifeDbContext))]
    [Migration("20230222094736_mynew")]
    partial class mynew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("newproject.Models.AncOpd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ANCRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DailyLogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOftheMother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DailyLogId");

                    b.ToTable("AncOpds");
                });

            modelBuilder.Entity("newproject.Models.DailyLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AreaOfPosting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityPosed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DailyLogs");
                });

            modelBuilder.Entity("newproject.Models.AncOpd", b =>
                {
                    b.HasOne("newproject.Models.DailyLog", "DailyLog")
                        .WithMany()
                        .HasForeignKey("DailyLogId");

                    b.Navigation("DailyLog");
                });
#pragma warning restore 612, 618
        }
    }
}
