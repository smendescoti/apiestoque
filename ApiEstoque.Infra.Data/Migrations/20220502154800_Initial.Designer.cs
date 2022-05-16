﻿// <auto-generated />
using System;
using ApiEstoque.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiEstoque.Infra.Data.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20220502154800_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiEstoque.Infra.Data.Entities.Estoque", b =>
                {
                    b.Property<Guid>("IdEstoque")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDESTOQUE");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACRIACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NOME");

                    b.HasKey("IdEstoque");

                    b.ToTable("ESTOQUE", (string)null);
                });

            modelBuilder.Entity("ApiEstoque.Infra.Data.Entities.Produto", b =>
                {
                    b.Property<Guid>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDPRODUTO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACRIACAO");

                    b.Property<Guid>("IdEstoque")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDESTOQUE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NOME");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRECO");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdEstoque");

                    b.ToTable("PRODUTO", (string)null);
                });

            modelBuilder.Entity("ApiEstoque.Infra.Data.Entities.Produto", b =>
                {
                    b.HasOne("ApiEstoque.Infra.Data.Entities.Estoque", "Estoque")
                        .WithMany("Produtos")
                        .HasForeignKey("IdEstoque")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estoque");
                });

            modelBuilder.Entity("ApiEstoque.Infra.Data.Entities.Estoque", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
