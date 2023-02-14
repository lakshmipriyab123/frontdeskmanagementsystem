﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VMS.Infrastructure.VMS.Infrastructure.Repository;

#nullable disable

namespace VMS.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogDBContext))]
    partial class CatalogDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VMS.Core.Domain.Models.VisitorForm.Visitor", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CheckInTime")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("CheckOutTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CheckOutTime")
                        .HasColumnOrder(8);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email")
                        .HasColumnOrder(3);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MobileNumber")
                        .HasColumnOrder(4);

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId")
                        .HasColumnOrder(1);

                    b.Property<string>("SecurityInCharge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SecurityInCharge")
                        .HasColumnOrder(9);

                    b.Property<string>("VisitType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VisitType")
                        .HasColumnOrder(5);

                    b.Property<string>("VisitorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VisitorId")
                        .HasColumnOrder(10);

                    b.Property<string>("VisitorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VisitorName")
                        .HasColumnOrder(2);

                    b.Property<string>("WhomToMeet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("WhomToMeet")
                        .HasColumnOrder(6);

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("modifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("Visitor");
                });
#pragma warning restore 612, 618
        }
    }
}
