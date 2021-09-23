﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pension_Management;

namespace Pension_Management.Migrations
{
    [DbContext(typeof(PensionerContext))]
    [Migration("20210923095531_AddingDb2")]
    partial class AddingDb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pension_Management.Pensioner", b =>
                {
                    b.Property<long>("AadharNo")
                        .HasColumnType("bigint");

                    b.Property<double>("Allowances")
                        .HasColumnType("float");

                    b.Property<long>("BankAccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PensionAmount")
                        .HasColumnType("float");

                    b.Property<string>("PensionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalaryEarned")
                        .HasColumnType("float");

                    b.HasKey("AadharNo");

                    b.ToTable("Pensioners");
                });
#pragma warning restore 612, 618
        }
    }
}
