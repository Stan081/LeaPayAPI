﻿// <auto-generated />
using System;
using Lea.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lea.Repository.Migrations
{
    [DbContext(typeof(LeaContext))]
    [Migration("20240913200716_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lea.Data.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Lea.Data.Models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CardReference")
                        .HasColumnType("uuid");

                    b.Property<int>("CardType")
                        .HasColumnType("integer");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("IssueDate")
                        .HasColumnType("date");

                    b.Property<int>("MerchantId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Lea.Data.Models.CardMerchant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("MerchantId")
                        .HasColumnType("integer");

                    b.Property<string>("MerchantReference")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CardMerchants");
                });

            modelBuilder.Entity("Lea.Data.Models.CreditPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IssueType")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<double>("Point")
                        .HasColumnType("double precision");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CreditPoints");
                });

            modelBuilder.Entity("Lea.Data.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentType")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Lea.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Passrecoverytoken")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Passrecoverytokentimeout")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("RecoveryEmail")
                        .HasColumnType("text");

                    b.Property<int?>("Token")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("TokenTimeout")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int>("UserTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
