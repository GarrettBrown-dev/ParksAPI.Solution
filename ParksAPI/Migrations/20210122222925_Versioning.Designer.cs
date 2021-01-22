﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    [Migration("20210122222925_Versioning")]
    partial class Versioning
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ParkLocation")
                        .IsRequired();

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "A 1200-mile area of land best known for its amazing waterfalls and rock formations.",
                            ParkLocation = "Sierra-Nevada Mountains, California, USA.",
                            ParkName = "Yosemite National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "Decommissioned fort on the Puget Sound, home to a vast array of bunkers and museums.",
                            ParkLocation = "Port Townsand, Washington, USA.",
                            ParkName = "Fort Wardon State Park"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "A massive lake that lies in the remnants of the ancient volcano Mazama. The ninth deepest lake in the world.",
                            ParkLocation = "Southern Oregon, USA",
                            ParkName = "Crater Lake National Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
