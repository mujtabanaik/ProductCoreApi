﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCoreApi.Context;

namespace ProductCoreApi.Migrations
{
    [DbContext(typeof(CoreContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCoreApi.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("creadtedDate");

                    b.Property<string>("createdBy");

                    b.Property<string>("description");

                    b.Property<float>("discount");

                    b.Property<float>("mrc");

                    b.Property<float>("nrc");

                    b.Property<string>("productName");

                    b.HasKey("productId");

                    b.ToTable("Product","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
