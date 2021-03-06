﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WhoozatAPI.Entities;

namespace WhoozatAPI.Migrations
{
    [DbContext(typeof(WhoozatDBContext))]
    [Migration("20171112205812_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("WhoozatAPI.Entities.Estate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<sbyte>("active");

                    b.Property<string>("address");

                    b.Property<string>("city");

                    b.Property<DateTime>("creationDate");

                    b.Property<int>("idCountry");

                    b.Property<int>("idEstate");

                    b.Property<int?>("idUserEstate");

                    b.Property<DateTime>("lastUpdate");

                    b.Property<string>("name");

                    b.Property<string>("phone");

                    b.Property<string>("photo");

                    b.Property<string>("postalCode");

                    b.Property<string>("state");

                    b.Property<int>("unitsNumber");

                    b.HasKey("Id");

                    b.ToTable("Estates");
                });
#pragma warning restore 612, 618
        }
    }
}
