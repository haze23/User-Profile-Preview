﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UPP.Model;

namespace UPP.Api.Migrations
{
    [DbContext(typeof(DbEntites))]
    partial class DbEntitesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UPP.Api.Model.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AreaId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("UPP.Api.Model.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsigneeId")
                        .HasColumnType("int");

                    b.Property<int>("ConsignorId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("UPP.Api.Model.BookingDescription", b =>
                {
                    b.Property<int>("BookingDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ActualWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Createdby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GrossWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("RateCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WeightTypeId")
                        .HasColumnType("int");

                    b.HasKey("BookingDescriptionId");

                    b.HasIndex("BookingId");

                    b.HasIndex("RateId");

                    b.HasIndex("WeightTypeId");

                    b.ToTable("BookingDEscription");
                });

            modelBuilder.Entity("UPP.Api.Model.Consignee", b =>
                {
                    b.Property<int>("ConsigneeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Address")
                        .HasColumnType("int");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("ConsigneeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("ConsigneeId");

                    b.HasIndex("AreaId");

                    b.HasIndex("CountryId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Consignee");
                });

            modelBuilder.Entity("UPP.Api.Model.Consignor", b =>
                {
                    b.Property<int>("ConsignorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Address")
                        .HasColumnType("int");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("ConsignorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("ConsignorId");

                    b.HasIndex("AreaId");

                    b.HasIndex("CountryId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Consignor");
                });

            modelBuilder.Entity("UPP.Api.Model.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("UPP.Api.Model.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DespatchTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryId");

                    b.HasIndex("BookingId");

                    b.HasIndex("TruckId");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("UPP.Api.Model.DeliveryDriver", b =>
                {
                    b.Property<int>("DeliveryDriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("assistantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("driverId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DeliveryDriverId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("driverId");

                    b.ToTable("DeliveryDriver");
                });

            modelBuilder.Entity("UPP.Api.Model.FuelType", b =>
                {
                    b.Property<int>("FuelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuelTypeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuelTypeId");

                    b.ToTable("FuelType");
                });

            modelBuilder.Entity("UPP.Api.Model.PaymentTypes", b =>
                {
                    b.Property<int>("PaymentTypesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentTypesDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypesId");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("UPP.Api.Model.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("UPP.Api.Model.Rate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RateDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RateId");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("UPP.Api.Model.TransmissionType", b =>
                {
                    b.Property<int>("TransmissionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TransmissionTypeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransmissionTypeId");

                    b.ToTable("TransmissionType");
                });

            modelBuilder.Entity("UPP.Api.Model.Truck", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSold")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LicencePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransmissionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TruckDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TruckNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("TruckId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("UPP.Api.Model.WeightType", b =>
                {
                    b.Property<int>("WeightTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("WeightTypeDesc")
                        .HasColumnType("int");

                    b.HasKey("WeightTypeId");

                    b.ToTable("WeightType");
                });

            modelBuilder.Entity("UPP.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpDeptId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EquityId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmpDeptId");

                    b.HasIndex("EquityId");

                    b.HasIndex("GenderId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Contact = "0791814332",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "infor@walden.co.za",
                            EmpDeptId = 0,
                            EmployeeNo = "EMP-0124",
                            EquityId = 1,
                            Firstname = "Walden",
                            GenderId = 1,
                            Lastname = "Schmidt",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Website = "www.walden.co.za"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Contact = "0718798898",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "infor@roselee.co.za",
                            EmpDeptId = 0,
                            EmployeeNo = "EMP-0088",
                            EquityId = 2,
                            Firstname = "RoseLee",
                            GenderId = 2,
                            Lastname = "Cheryl",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Website = "www.roselee.co.za"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Contact = "0670058981",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "infor@evans.co.za",
                            EmpDeptId = 0,
                            EmployeeNo = "EMP-0136",
                            EquityId = 1,
                            Firstname = "Evans",
                            GenderId = 1,
                            Lastname = "Mazi",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Website = "www.evans.co.za"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Contact = "0791814332",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "infor@kagiso.co.za",
                            EmpDeptId = 0,
                            EmployeeNo = "EMP-0461",
                            EquityId = 1,
                            Firstname = "Kagiso",
                            GenderId = 1,
                            Lastname = "Mandla",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Website = "www.kagiso.co.za"
                        },
                        new
                        {
                            EmployeeId = 5,
                            Contact = "0791814332",
                            Dob = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "infor@caroline.co.za",
                            EmpDeptId = 0,
                            EmployeeNo = "EMP-0661",
                            EquityId = 2,
                            Firstname = "Caroline",
                            GenderId = 2,
                            Lastname = "Smith",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Website = "www.caroline.co.za"
                        });
                });

            modelBuilder.Entity("UPP.Model.EmployeeDepartment", b =>
                {
                    b.Property<int>("EmpDeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ActiveYn")
                        .HasColumnType("bit");

                    b.Property<string>("EmpDeptDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpDeptId");

                    b.ToTable("EmployeeDepartments");
                });

            modelBuilder.Entity("UPP.Model.Equity", b =>
                {
                    b.Property<int>("EquityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EquityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquityDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquityId");

                    b.ToTable("Equities");

                    b.HasData(
                        new
                        {
                            EquityId = 1,
                            EquityCode = "BLK",
                            EquityDesc = "Black"
                        },
                        new
                        {
                            EquityId = 2,
                            EquityCode = "WHT",
                            EquityDesc = "White"
                        });
                });

            modelBuilder.Entity("UPP.Model.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderCode = "M",
                            GenderDesc = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderCode = "F",
                            GenderDesc = "Female"
                        });
                });

            modelBuilder.Entity("UPP.Api.Model.BookingDescription", b =>
                {
                    b.HasOne("UPP.Api.Model.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.WeightType", "WeightType")
                        .WithMany()
                        .HasForeignKey("WeightTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Rate");

                    b.Navigation("WeightType");
                });

            modelBuilder.Entity("UPP.Api.Model.Consignee", b =>
                {
                    b.HasOne("UPP.Api.Model.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Country");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("UPP.Api.Model.Consignor", b =>
                {
                    b.HasOne("UPP.Api.Model.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Country");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("UPP.Api.Model.Delivery", b =>
                {
                    b.HasOne("UPP.Api.Model.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.Truck", "Truck")
                        .WithMany()
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("UPP.Api.Model.DeliveryDriver", b =>
                {
                    b.HasOne("UPP.Api.Model.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("driverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("UPP.Api.Model.Truck", b =>
                {
                    b.HasOne("UPP.Api.Model.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Api.Model.TransmissionType", "TransmissionType")
                        .WithMany()
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuelType");

                    b.Navigation("TransmissionType");
                });

            modelBuilder.Entity("UPP.Model.Employee", b =>
                {
                    b.HasOne("UPP.Model.EmployeeDepartment", "EmployeeDepartment")
                        .WithMany()
                        .HasForeignKey("EmpDeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Model.Equity", "Equity")
                        .WithMany()
                        .HasForeignKey("EquityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UPP.Model.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeDepartment");

                    b.Navigation("Equity");

                    b.Navigation("Gender");
                });
#pragma warning restore 612, 618
        }
    }
}
