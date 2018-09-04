﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AndreaDipreApi.Migrations
{
    [DbContext(typeof(KarmaDatabaseContext))]
    partial class KarmaDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("Channel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("hex(randomblob(16))");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("Karma", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article");

                    b.Property<Guid>("ChannelId");

                    b.Property<int>("Score");

                    b.HasKey("Name");

                    b.ToTable("Karmas");
                });
#pragma warning restore 612, 618
        }
    }
}
