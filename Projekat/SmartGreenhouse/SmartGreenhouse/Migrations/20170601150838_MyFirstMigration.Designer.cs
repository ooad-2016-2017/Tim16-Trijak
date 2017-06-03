using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SmartGreenhouse.Model;

namespace SmartGreenhouse.Migrations
{
    [DbContext(typeof(GreenhouseContext))]
    [Migration("20170601150838_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SmartGreenhouse.Model.Izvjestaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzvjestaja");

                    b.Property<int?>("TipIzvjestajaId");

                    b.HasKey("Id");

                    b.HasIndex("TipIzvjestajaId");

                    b.ToTable("Izvjestaji");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumNarudzbe");

                    b.HasKey("Id");

                    b.ToTable("Narudzbe");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Ponuda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojSadnica");

                    b.HasKey("Id");

                    b.ToTable("Ponude");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.PreuzimanjeInformacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("NivoVode");

                    b.Property<double>("Osvijetljenost");

                    b.Property<double>("Temperatura");

                    b.Property<double>("VlaznostZemljista");

                    b.Property<double>("VlaznostZraka");

                    b.HasKey("Id");

                    b.ToTable("PreuzeteInformacije");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Sadnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<int>("Kolicina");

                    b.Property<int?>("NarudzbaId");

                    b.Property<string>("Naziv");

                    b.Property<int?>("PonudaId");

                    b.Property<int>("Pozicija");

                    b.Property<int>("Prodato");

                    b.HasKey("Id");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("PonudaId");

                    b.ToTable("Sadnice");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Statistika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzvjestaja");

                    b.Property<int?>("VrstaSadniceId");

                    b.HasKey("Id");

                    b.HasIndex("VrstaSadniceId");

                    b.ToTable("Statistike");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.TipIzvjestaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipoviIzvjestaja");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.TipKorisnika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipoviKorisnika");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Izvjestaj", b =>
                {
                    b.HasOne("SmartGreenhouse.Model.TipIzvjestaja", "TipIzvjestaja")
                        .WithMany()
                        .HasForeignKey("TipIzvjestajaId");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Sadnica", b =>
                {
                    b.HasOne("SmartGreenhouse.Model.Narudzba")
                        .WithMany("Sadnice")
                        .HasForeignKey("NarudzbaId");

                    b.HasOne("SmartGreenhouse.Model.Ponuda")
                        .WithMany("SadniceUPonudi")
                        .HasForeignKey("PonudaId");
                });

            modelBuilder.Entity("SmartGreenhouse.Model.Statistika", b =>
                {
                    b.HasOne("SmartGreenhouse.Model.Sadnica", "VrstaSadnice")
                        .WithMany()
                        .HasForeignKey("VrstaSadniceId");
                });
        }
    }
}
