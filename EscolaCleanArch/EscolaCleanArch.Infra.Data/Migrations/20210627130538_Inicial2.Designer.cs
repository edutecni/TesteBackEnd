﻿// <auto-generated />
using System;
using EscolaCleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaCleanArch.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210627130538_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EscolaCleanArch.Domain.Entities.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RA")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            CursoId = 3,
                            Nome = "Eduardo Alves Canuto",
                            Periodo = "Manhã",
                            RA = "00001"
                        },
                        new
                        {
                            AlunoId = 2,
                            CursoId = 2,
                            Nome = "Viviane Fidelis do Nascimento",
                            Periodo = "Tarde",
                            RA = "00002"
                        },
                        new
                        {
                            AlunoId = 3,
                            CursoId = 1,
                            Nome = "Thiago Fidelis Alves Canuto",
                            Periodo = "Noite",
                            RA = "00003"
                        },
                        new
                        {
                            AlunoId = 4,
                            CursoId = 3,
                            Nome = "Eduardo Pereira",
                            Periodo = "Manhã",
                            RA = "00004"
                        },
                        new
                        {
                            AlunoId = 5,
                            CursoId = 3,
                            Nome = "Elaine Farias",
                            Periodo = "Tarde",
                            RA = "00005"
                        },
                        new
                        {
                            AlunoId = 6,
                            CursoId = 1,
                            Nome = "Eduardo Cout",
                            Periodo = "Noite",
                            RA = "00006"
                        },
                        new
                        {
                            AlunoId = 7,
                            CursoId = 3,
                            Nome = "Gabriel Silva",
                            Periodo = "Manhã",
                            RA = "00007"
                        },
                        new
                        {
                            AlunoId = 8,
                            CursoId = 2,
                            Nome = "Viviane Araujo",
                            Periodo = "Tarde",
                            RA = "00008"
                        },
                        new
                        {
                            AlunoId = 9,
                            CursoId = 1,
                            Nome = "Thiago Silva Farias",
                            Periodo = "Noite",
                            RA = "00009"
                        },
                        new
                        {
                            AlunoId = 10,
                            CursoId = 3,
                            Nome = "Gabriel Medina",
                            Periodo = "Manhã",
                            RA = "00010"
                        },
                        new
                        {
                            AlunoId = 11,
                            CursoId = 2,
                            Nome = "Olávo Freitas",
                            Periodo = "Tarde",
                            RA = "00011"
                        },
                        new
                        {
                            AlunoId = 12,
                            CursoId = 1,
                            Nome = "Nicóle Kidman",
                            Periodo = "Noite",
                            RA = "00012"
                        });
                });

            modelBuilder.Entity("EscolaCleanArch.Domain.Entities.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            Nome = "Ensino Fundamental"
                        },
                        new
                        {
                            CursoId = 2,
                            Nome = "Ensino Médio"
                        },
                        new
                        {
                            CursoId = 3,
                            Nome = "Faculdade"
                        },
                        new
                        {
                            CursoId = 4,
                            Nome = "Pós-Graduação"
                        });
                });

            modelBuilder.Entity("EscolaCleanArch.Domain.Entities.Diciplina", b =>
                {
                    b.Property<int>("DiciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("NotaMinima")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("DiciplinaId");

                    b.ToTable("Diciplinas");

                    b.HasData(
                        new
                        {
                            DiciplinaId = 1,
                            CursoId = 1,
                            Nome = "Portugês Ensino Fundamental",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 2,
                            CursoId = 1,
                            Nome = "Matemática Ensino Fundamental",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 3,
                            CursoId = 1,
                            Nome = "Ciências Ensino Fundamental",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 4,
                            CursoId = 1,
                            Nome = "Histógia Ensino Fundamental",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 5,
                            CursoId = 1,
                            Nome = "Geográfia Ensino Fundamental",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 6,
                            CursoId = 2,
                            Nome = "Portugês Ensino Médio",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 7,
                            CursoId = 2,
                            Nome = "Matemática Ensino Médio",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 8,
                            CursoId = 2,
                            Nome = "Fisíca Ensino Médio",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 9,
                            CursoId = 2,
                            Nome = "Histógia Ensino Médio",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 10,
                            CursoId = 2,
                            Nome = "Geográfia Ensino Médio",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 11,
                            CursoId = 3,
                            Nome = "Portugês Faculdade",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 12,
                            CursoId = 3,
                            Nome = "Matemática Faculdade",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 13,
                            CursoId = 3,
                            Nome = "Fisíca Faculdade",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 14,
                            CursoId = 3,
                            Nome = "Histógia Faculdade",
                            NotaMinima = 7.0m
                        },
                        new
                        {
                            DiciplinaId = 15,
                            CursoId = 3,
                            Nome = "Geográfia Faculdade",
                            NotaMinima = 7.0m
                        });
                });

            modelBuilder.Entity("EscolaCleanArch.Domain.Entities.NotasAluno", b =>
                {
                    b.Property<int>("NotaAlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("DiciplinaId")
                        .HasColumnType("int");

                    b.Property<decimal>("NotaDiciplina")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("NotaAlunoId");

                    b.ToTable("NotasAlunos");

                    b.HasData(
                        new
                        {
                            NotaAlunoId = 1,
                            AlunoId = 1,
                            CursoId = 3,
                            DiciplinaId = 11,
                            NotaDiciplina = 7.0m
                        },
                        new
                        {
                            NotaAlunoId = 2,
                            AlunoId = 1,
                            CursoId = 3,
                            DiciplinaId = 12,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 3,
                            AlunoId = 1,
                            CursoId = 3,
                            DiciplinaId = 13,
                            NotaDiciplina = 5.0m
                        },
                        new
                        {
                            NotaAlunoId = 4,
                            AlunoId = 1,
                            CursoId = 3,
                            DiciplinaId = 14,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 5,
                            AlunoId = 1,
                            CursoId = 3,
                            DiciplinaId = 15,
                            NotaDiciplina = 6.0m
                        },
                        new
                        {
                            NotaAlunoId = 6,
                            AlunoId = 4,
                            CursoId = 3,
                            DiciplinaId = 11,
                            NotaDiciplina = 7.0m
                        },
                        new
                        {
                            NotaAlunoId = 7,
                            AlunoId = 4,
                            CursoId = 3,
                            DiciplinaId = 12,
                            NotaDiciplina = 7.0m
                        },
                        new
                        {
                            NotaAlunoId = 8,
                            AlunoId = 4,
                            CursoId = 3,
                            DiciplinaId = 13,
                            NotaDiciplina = 5.0m
                        },
                        new
                        {
                            NotaAlunoId = 9,
                            AlunoId = 4,
                            CursoId = 3,
                            DiciplinaId = 14,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 10,
                            AlunoId = 4,
                            CursoId = 3,
                            DiciplinaId = 15,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 11,
                            AlunoId = 5,
                            CursoId = 3,
                            DiciplinaId = 11,
                            NotaDiciplina = 10.0m
                        },
                        new
                        {
                            NotaAlunoId = 12,
                            AlunoId = 5,
                            CursoId = 3,
                            DiciplinaId = 12,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 13,
                            AlunoId = 5,
                            CursoId = 3,
                            DiciplinaId = 13,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 14,
                            AlunoId = 5,
                            CursoId = 3,
                            DiciplinaId = 14,
                            NotaDiciplina = 5.0m
                        },
                        new
                        {
                            NotaAlunoId = 15,
                            AlunoId = 5,
                            CursoId = 3,
                            DiciplinaId = 15,
                            NotaDiciplina = 6.0m
                        },
                        new
                        {
                            NotaAlunoId = 16,
                            AlunoId = 3,
                            CursoId = 1,
                            DiciplinaId = 1,
                            NotaDiciplina = 7.0m
                        },
                        new
                        {
                            NotaAlunoId = 17,
                            AlunoId = 3,
                            CursoId = 1,
                            DiciplinaId = 2,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 18,
                            AlunoId = 3,
                            CursoId = 1,
                            DiciplinaId = 3,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 19,
                            AlunoId = 3,
                            CursoId = 1,
                            DiciplinaId = 4,
                            NotaDiciplina = 5.0m
                        },
                        new
                        {
                            NotaAlunoId = 20,
                            AlunoId = 3,
                            CursoId = 1,
                            DiciplinaId = 5,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 21,
                            AlunoId = 6,
                            CursoId = 1,
                            DiciplinaId = 1,
                            NotaDiciplina = 6.0m
                        },
                        new
                        {
                            NotaAlunoId = 22,
                            AlunoId = 6,
                            CursoId = 1,
                            DiciplinaId = 2,
                            NotaDiciplina = 7.0m
                        },
                        new
                        {
                            NotaAlunoId = 23,
                            AlunoId = 6,
                            CursoId = 1,
                            DiciplinaId = 3,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 24,
                            AlunoId = 6,
                            CursoId = 1,
                            DiciplinaId = 4,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 25,
                            AlunoId = 6,
                            CursoId = 1,
                            DiciplinaId = 5,
                            NotaDiciplina = 10.0m
                        },
                        new
                        {
                            NotaAlunoId = 26,
                            AlunoId = 2,
                            CursoId = 2,
                            DiciplinaId = 6,
                            NotaDiciplina = 10.0m
                        },
                        new
                        {
                            NotaAlunoId = 27,
                            AlunoId = 2,
                            CursoId = 2,
                            DiciplinaId = 7,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 28,
                            AlunoId = 2,
                            CursoId = 2,
                            DiciplinaId = 8,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 29,
                            AlunoId = 2,
                            CursoId = 2,
                            DiciplinaId = 9,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 30,
                            AlunoId = 2,
                            CursoId = 2,
                            DiciplinaId = 10,
                            NotaDiciplina = 10.0m
                        },
                        new
                        {
                            NotaAlunoId = 31,
                            AlunoId = 8,
                            CursoId = 2,
                            DiciplinaId = 6,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 32,
                            AlunoId = 8,
                            CursoId = 2,
                            DiciplinaId = 7,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 33,
                            AlunoId = 8,
                            CursoId = 2,
                            DiciplinaId = 8,
                            NotaDiciplina = 9.0m
                        },
                        new
                        {
                            NotaAlunoId = 34,
                            AlunoId = 8,
                            CursoId = 2,
                            DiciplinaId = 9,
                            NotaDiciplina = 8.0m
                        },
                        new
                        {
                            NotaAlunoId = 35,
                            AlunoId = 8,
                            CursoId = 2,
                            DiciplinaId = 10,
                            NotaDiciplina = 10.0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}