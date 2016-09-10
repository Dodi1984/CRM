using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication.Data;

namespace CRM.Migrations.Crm
{
    [DbContext(typeof(CrmContext))]
    partial class CrmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("CRM.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("CUI");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("CRM.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthDate");

                    b.Property<long>("CNP");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PersonId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("CRM.Models.Person", b =>
                {
                    b.HasOne("CRM.Models.Company", "Company")
                        .WithMany("Persons")
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
