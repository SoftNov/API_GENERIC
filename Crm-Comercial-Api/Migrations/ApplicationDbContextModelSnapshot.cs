﻿// <auto-generated />
using System;
using Crm.Comercial.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crm.Comercial.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Contato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DD")
                        .IsRequired()
                        .HasColumnType("varchar(3) CHARACTER SET utf8mb4")
                        .HasMaxLength(3);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("NumTelefone")
                        .IsRequired()
                        .HasColumnType("varchar(9) CHARACTER SET utf8mb4")
                        .HasMaxLength(9);

                    b.HasKey("Id");

                    b.ToTable("TBL_CONTATO");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Login", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("NomeUsr")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("TBL_LOGIN");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Classe")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("FlagAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IconColor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Path")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Visible")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("TBL_MENU");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Perfil", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Flag")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TBL_PERFIL");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cnpj")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long?>("ContatoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("FlgAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("LoginId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeFatasia")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("PerfilId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId");

                    b.HasIndex("LoginId");

                    b.ToTable("TBL_USUARIO");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Validacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CodValidacao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtEnvio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtValidacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("TBL_VALIDACAO");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.VinculoMenu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("Criar")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Deletar")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Editar")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PerfilId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Visualizar")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("TBL_VINCULO_MENU");
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.Usuario", b =>
                {
                    b.HasOne("Crm.Comercial.Domain.Model.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId");

                    b.HasOne("Crm.Comercial.Domain.Model.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Crm.Comercial.Domain.Model.VinculoMenu", b =>
                {
                    b.HasOne("Crm.Comercial.Domain.Model.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
