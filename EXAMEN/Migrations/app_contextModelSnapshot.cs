﻿// <auto-generated />
using System;
using EXAMEN.Controllers.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EXAMEN.Migrations
{
    [DbContext(typeof(app_context))]
    partial class app_contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa1", b =>
                {
                    b.Property<int>("Clasa1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clasa1Id"), 1L, 1);

                    b.Property<int>("Clasa2ReferenceClasa2Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("EvenimentId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Clasa1Id");

                    b.HasIndex("Clasa2ReferenceClasa2Id");

                    b.ToTable("Clasa1");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa2", b =>
                {
                    b.Property<int>("Clasa2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clasa2Id"), 1L, 1);

                    b.Property<int>("Clasa3ReferenceClasa3Id")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Clasa2Id");

                    b.HasIndex("Clasa3ReferenceClasa3Id");

                    b.ToTable("Clasa2");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa3", b =>
                {
                    b.Property<int>("Clasa3Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clasa3Id"), 1L, 1);

                    b.Property<int>("EvenimentId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipareId")
                        .HasColumnType("int");

                    b.HasKey("Clasa3Id");

                    b.HasIndex("EvenimentId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Clasa3");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Eveniment", b =>
                {
                    b.Property<int>("EvenimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvenimentId"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EvenimentId");

                    b.ToTable("Evenimente");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"), 1L, 1);

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Participare", b =>
                {
                    b.Property<int>("EvenimentId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int?>("Clasa1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Clasa2Id")
                        .HasColumnType("int");

                    b.Property<int>("ParticipareId")
                        .HasColumnType("int");

                    b.HasKey("EvenimentId", "ParticipantId");

                    b.HasIndex("Clasa1Id");

                    b.HasIndex("Clasa2Id");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Participari");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa1", b =>
                {
                    b.HasOne("EXAMEN.Controllers.Model.Clasa2", "Clasa2Reference")
                        .WithMany()
                        .HasForeignKey("Clasa2ReferenceClasa2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasa2Reference");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa2", b =>
                {
                    b.HasOne("EXAMEN.Controllers.Model.Clasa3", "Clasa3Reference")
                        .WithMany()
                        .HasForeignKey("Clasa3ReferenceClasa3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasa3Reference");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa3", b =>
                {
                    b.HasOne("EXAMEN.Controllers.Model.Eveniment", "Eveniment")
                        .WithMany()
                        .HasForeignKey("EvenimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EXAMEN.Controllers.Model.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eveniment");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Participare", b =>
                {
                    b.HasOne("EXAMEN.Controllers.Model.Clasa1", null)
                        .WithMany("Participanti")
                        .HasForeignKey("Clasa1Id");

                    b.HasOne("EXAMEN.Controllers.Model.Clasa2", null)
                        .WithMany("Evenimente")
                        .HasForeignKey("Clasa2Id");

                    b.HasOne("EXAMEN.Controllers.Model.Eveniment", "Eveniment")
                        .WithMany("Participari")
                        .HasForeignKey("EvenimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EXAMEN.Controllers.Model.Participant", "Participant")
                        .WithMany("Participari")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eveniment");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa1", b =>
                {
                    b.Navigation("Participanti");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Clasa2", b =>
                {
                    b.Navigation("Evenimente");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Eveniment", b =>
                {
                    b.Navigation("Participari");
                });

            modelBuilder.Entity("EXAMEN.Controllers.Model.Participant", b =>
                {
                    b.Navigation("Participari");
                });
#pragma warning restore 612, 618
        }
    }
}
