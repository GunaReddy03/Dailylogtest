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
    [Migration("20230222100117_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PromiseApp.Models.MidWifeModels.Dailylog_Triage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DailyLogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfAdmission")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRefferalOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateofVisit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EDD")
                        .HasColumnType("datetime2");

                    b.Property<string>("IPNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LMP")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOftheMother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Pathways_Of_Care")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeOfAssesment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeofVisit")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("examination_type")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DailyLogId");

                    b.ToTable("dailylog_Triages");
                });

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

            modelBuilder.Entity("PromiseApp.Models.MidWifeModels.Dailylog_Triage", b =>
                {
                    b.HasOne("newproject.Models.DailyLog", "DailyLog")
                        .WithMany()
                        .HasForeignKey("DailyLogId");

                    b.OwnsOne("PromiseApp.Models.MidWifeModels.DemographicDetailsTriage", "DemographicDetailsTriage", b1 =>
                        {
                            b1.Property<int>("Dailylog_TriageId")
                                .HasColumnType("int");

                            b1.Property<int>("Abortion")
                                .HasColumnType("int");

                            b1.Property<string>("Consanguinity")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("GestationalAgeinWeeks")
                                .HasColumnType("int");

                            b1.Property<int>("Gravida")
                                .HasColumnType("int");

                            b1.Property<int>("Living")
                                .HasColumnType("int");

                            b1.Property<string>("NameOfCompanion")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Para")
                                .HasColumnType("int");

                            b1.Property<bool?>("YearsOfMarriage")
                                .HasColumnType("bit");

                            b1.HasKey("Dailylog_TriageId");

                            b1.ToTable("dailylog_Triages");

                            b1.ToJson("DemographicDetailsTriage");

                            b1.WithOwner()
                                .HasForeignKey("Dailylog_TriageId");
                        });

                    b.OwnsOne("PromiseApp.Models.MidWifeModels.Status_of_mother", "Status_Of_Mother", b1 =>
                        {
                            b1.Property<int>("Dailylog_TriageId")
                                .HasColumnType("int");

                            b1.Property<bool?>("StatusOfMother")
                                .HasColumnType("bit");

                            b1.HasKey("Dailylog_TriageId");

                            b1.ToTable("dailylog_Triages");

                            b1.ToJson("Status_Of_Mother");

                            b1.WithOwner()
                                .HasForeignKey("Dailylog_TriageId");
                        });

                    b.OwnsOne("PromiseApp.Models.MidWifeModels.Traige_Category", "Traige_Category", b1 =>
                        {
                            b1.Property<int>("Dailylog_TriageId")
                                .HasColumnType("int");

                            b1.Property<bool?>("Green")
                                .HasColumnType("bit");

                            b1.Property<bool?>("Red")
                                .HasColumnType("bit");

                            b1.Property<bool?>("Yellow")
                                .HasColumnType("bit");

                            b1.HasKey("Dailylog_TriageId");

                            b1.ToTable("dailylog_Triages");

                            b1.ToJson("Traige_Category");

                            b1.WithOwner()
                                .HasForeignKey("Dailylog_TriageId");
                        });

                    b.OwnsOne("PromiseApp.Models.MidWifeModels.Vitals_Triage", "Vitals_Triage", b1 =>
                        {
                            b1.Property<int>("Dailylog_TriageId")
                                .HasColumnType("int");

                            b1.Property<int>("BMI")
                                .HasColumnType("int");

                            b1.Property<int>("BloodPressure")
                                .HasColumnType("int");

                            b1.Property<bool>("Fetal_Heart_Rate_Monitored")
                                .HasColumnType("bit");

                            b1.Property<int>("Fetal_Heart_rate")
                                .HasColumnType("int");

                            b1.Property<int>("Height")
                                .HasColumnType("int");

                            b1.Property<bool>("NotifiedDoc")
                                .HasColumnType("bit");

                            b1.Property<bool>("Notified_Doctor")
                                .HasColumnType("bit");

                            b1.Property<string>("Nutritional_Status")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<bool?>("Present_Complaints")
                                .HasColumnType("bit");

                            b1.Property<int>("Pulse")
                                .HasColumnType("int");

                            b1.Property<int>("Respiration")
                                .HasColumnType("int");

                            b1.Property<int>("Weight")
                                .HasColumnType("int");

                            b1.Property<int>("temperature")
                                .HasColumnType("int");

                            b1.HasKey("Dailylog_TriageId");

                            b1.ToTable("dailylog_Triages");

                            b1.ToJson("Vitals_Triage");

                            b1.WithOwner()
                                .HasForeignKey("Dailylog_TriageId");
                        });

                    b.Navigation("DailyLog");

                    b.Navigation("DemographicDetailsTriage");

                    b.Navigation("Status_Of_Mother");

                    b.Navigation("Traige_Category");

                    b.Navigation("Vitals_Triage");
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