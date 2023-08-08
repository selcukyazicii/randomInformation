﻿// <auto-generated />
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InformationContext))]
    partial class InformationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entity.Concrete.Dare", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("content2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("game_type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Games2");
                });

            modelBuilder.Entity("Entity.Concrete.Truth", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("game_type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Entity.Concrete.bidijital_contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("bidijital_medya");
                });
#pragma warning restore 612, 618
        }
    }
}
