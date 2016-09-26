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

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<string>("CUI")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("CallBackDate");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<bool>("CourseLvl1")
                        .IsRequired();

                    b.Property<bool>("CourseLvl2")
                        .IsRequired();

                    b.Property<bool>("CourseLvl3")
                        .IsRequired();

                    b.Property<string>("DateOfTheFifthContact")
                        .IsRequired();

                    b.Property<string>("DateOfTheFirstContact")
                        .IsRequired();

                    b.Property<string>("DateOfTheFourthContact")
                        .IsRequired();

                    b.Property<string>("DateOfTheSecondContact")
                        .IsRequired();

                    b.Property<string>("DateOfTheThirdContact")
                        .IsRequired();

                    b.Property<string>("Discution1")
                        .IsRequired();

                    b.Property<string>("Discution2")
                        .IsRequired();

                    b.Property<string>("Discution3")
                        .IsRequired();

                    b.Property<string>("Discution4")
                        .IsRequired();

                    b.Property<string>("Discution5")
                        .IsRequired();

                    b.Property<string>("FieldOfActivity")
                        .IsRequired();

                    b.Property<bool>("HasAutoPark");

                    b.Property<string>("J")
                        .IsRequired();

                    b.Property<string>("LongDiscutions");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("NrOfDrivers")
                        .IsRequired();

                    b.Property<bool>("PreviousContract")
                        .IsRequired();

                    b.Property<string>("ServicesOfInterest")
                        .IsRequired();

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("CRM.Models.ContactPerson", b =>
                {
                    b.Property<int>("ContactPersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthDate");

                    b.Property<long>("CNP");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("PositionInCompany");

                    b.HasKey("ContactPersonId");

                    b.HasIndex("CompanyId");

                    b.ToTable("ContactPerson");
                });

            modelBuilder.Entity("CRM.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<long>("CNP");

                    b.Property<string>("Courses");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("CRM.Models.ContactPerson", b =>
                {
                    b.HasOne("CRM.Models.Company", "Company")
                        .WithMany("Persons")
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
