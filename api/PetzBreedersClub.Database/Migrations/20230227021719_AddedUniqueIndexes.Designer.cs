﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230227021719_AddedUniqueIndexes")]
    partial class AddedUniqueIndexes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Offspring", b =>
                {
                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("ChildId", "ParentId");

                    b.HasIndex("ParentId");

                    b.ToTable("Offspring");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.AffixEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AffixSyntax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("Affixes");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Species")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedFileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.ToTable("BreedFiles");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedStandardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<string>("Coat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisqualifyingFaults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eyes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreedId")
                        .IsUnique();

                    b.ToTable("BreedStandards");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.MemberEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.PetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<int>("BreederId")
                        .HasColumnType("int");

                    b.Property<string>("CallName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PedigreeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ShowName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SireId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("BreederId");

                    b.HasIndex("DamId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PedigreeNumber")
                        .IsUnique();

                    b.HasIndex("SireId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Offspring", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.PetEntity", null)
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzBreedersClub.Database.Models.PetEntity", null)
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.AffixEntity", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.MemberEntity", "Owner")
                        .WithMany("Affixes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedFileEntity", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.BreedEntity", "Breed")
                        .WithMany("BreedFiles")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Breed");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedStandardEntity", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.BreedEntity", "Breed")
                        .WithOne("BreedStandard")
                        .HasForeignKey("PetzBreedersClub.Database.Models.BreedStandardEntity", "BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Breed");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.MemberEntity", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.UserEntity", "User")
                        .WithOne("Member")
                        .HasForeignKey("PetzBreedersClub.Database.Models.MemberEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.PetEntity", b =>
                {
                    b.HasOne("PetzBreedersClub.Database.Models.BreedEntity", "Breed")
                        .WithMany()
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzBreedersClub.Database.Models.MemberEntity", "Breeder")
                        .WithMany("BredPets")
                        .HasForeignKey("BreederId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PetzBreedersClub.Database.Models.PetEntity", "Dam")
                        .WithMany()
                        .HasForeignKey("DamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PetzBreedersClub.Database.Models.MemberEntity", "Owner")
                        .WithMany("OwnedPets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PetzBreedersClub.Database.Models.PetEntity", "Sire")
                        .WithMany()
                        .HasForeignKey("SireId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Breed");

                    b.Navigation("Breeder");

                    b.Navigation("Dam");

                    b.Navigation("Owner");

                    b.Navigation("Sire");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.BreedEntity", b =>
                {
                    b.Navigation("BreedFiles");

                    b.Navigation("BreedStandard");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.MemberEntity", b =>
                {
                    b.Navigation("Affixes");

                    b.Navigation("BredPets");

                    b.Navigation("OwnedPets");
                });

            modelBuilder.Entity("PetzBreedersClub.Database.Models.UserEntity", b =>
                {
                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
