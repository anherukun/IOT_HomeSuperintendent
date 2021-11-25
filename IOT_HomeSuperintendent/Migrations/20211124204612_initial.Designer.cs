﻿// <auto-generated />
using IOT_HomeSuperintendent.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IOT_HomeSuperintendent.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211124204612_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("IOT_HomeSuperintendent.Models.IOTDevice", b =>
                {
                    b.Property<string>("IDDevice")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeviceStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeviceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirmwareVersion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MacAddress")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.Property<string>("MeasurementUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDDevice");

                    b.HasIndex("MacAddress")
                        .IsUnique();

                    b.ToTable("IOTDevice");

                    b.HasData(
                        new
                        {
                            IDDevice = "38B9F907-5961-4589-90E8-9EC020B7D40D",
                            DataType = "float",
                            DeviceName = "Water Level Sensor",
                            DeviceStatus = "Online",
                            DeviceType = "Water Level Sensor",
                            FirmwareVersion = "1.0.1",
                            IPAddress = "192.168.31.99",
                            MacAddress = "47-1D-44-CB-BF-05",
                            MeasurementUnit = "%"
                        },
                        new
                        {
                            IDDevice = "74F61449-AFA3-4D38-BBDE-4CE2600732D6",
                            DataType = "float",
                            DeviceName = "Water Level Sensor",
                            DeviceStatus = "Online",
                            DeviceType = "Water Level Sensor",
                            FirmwareVersion = "1.0.1",
                            IPAddress = "192.168.31.100",
                            MacAddress = "01-2F-7A-93-A3-46",
                            MeasurementUnit = "%"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
