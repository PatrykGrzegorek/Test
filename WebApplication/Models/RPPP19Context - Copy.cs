﻿//// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
//#nullable disable
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

//namespace WebApplication.Models
//{
//    public partial class RPPP19Context : DbContext
//    {
//        public RPPP19Context()
//        {
//        }

//        public RPPP19Context(DbContextOptions<RPPP19Context> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Class> Class { get; set; }
//        public virtual DbSet<Collection> Collection { get; set; }
//        public virtual DbSet<CommonName> CommonName { get; set; }
//        public virtual DbSet<Division> Division { get; set; }
//        public virtual DbSet<Expedition> Expedition { get; set; }
//        public virtual DbSet<Family> Family { get; set; }
//        public virtual DbSet<Genus> Genus { get; set; }
//        public virtual DbSet<Gpslocalization> Gpslocalization { get; set; }
//        public virtual DbSet<Habitat> Habitat { get; set; }
//        public virtual DbSet<Herbarium> Herbarium { get; set; }
//        public virtual DbSet<Kingdom> Kingdom { get; set; }
//        public virtual DbSet<Museum> Museum { get; set; }
//        public virtual DbSet<Observation> Observation { get; set; }
//        public virtual DbSet<Order> Order { get; set; }
//        public virtual DbSet<PartOfPlant> PartOfPlant { get; set; }
//        public virtual DbSet<Person> Person { get; set; }
//        public virtual DbSet<Reference> Reference { get; set; }
//        public virtual DbSet<Species> Species { get; set; }
//        public virtual DbSet<TypeOfReference> TypeOfReference { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Class>(entity =>
//            {
//                entity.Property(e => e.ClassId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("classId");

//                entity.Property(e => e.DivisionId).HasColumnName("divisionId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.HasOne(d => d.Division)
//                    .WithMany(p => p.Class)
//                    .HasForeignKey(d => d.DivisionId)
//                    .HasConstraintName("FK_Class_Division");
//            });

//            modelBuilder.Entity<Collection>(entity =>
//            {
//                entity.Property(e => e.CollectionId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("collectionId");

//                entity.Property(e => e.MuseumId).HasColumnName("museumId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.HasOne(d => d.Museum)
//                    .WithMany(p => p.Collection)
//                    .HasForeignKey(d => d.MuseumId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Collection_Museum");
//            });

//            modelBuilder.Entity<CommonName>(entity =>
//            {
//                entity.Property(e => e.CommonNameId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("commonNameId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.Property(e => e.ReferenceId).HasColumnName("referenceId");

//                entity.HasOne(d => d.Reference)
//                    .WithMany(p => p.CommonName)
//                    .HasForeignKey(d => d.ReferenceId)
//                    .HasConstraintName("FK_CommonName_Reference");
//            });

//            modelBuilder.Entity<Division>(entity =>
//            {
//                entity.Property(e => e.DivisionId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("divisionId");

//                entity.Property(e => e.KingdomId).HasColumnName("kingdomId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.HasOne(d => d.Kingdom)
//                    .WithMany(p => p.Division)
//                    .HasForeignKey(d => d.KingdomId)
//                    .HasConstraintName("FK_Division_Kingdom");
//            });

//            modelBuilder.Entity<Expedition>(entity =>
//            {
//                entity.Property(e => e.ExpeditionId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("expeditionId");

//                entity.Property(e => e.Discription)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("discription");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");
//            });

//            modelBuilder.Entity<Family>(entity =>
//            {
//                entity.Property(e => e.FamilyId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("familyId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.Property(e => e.OrderId).HasColumnName("orderId");

//                entity.HasOne(d => d.Order)
//                    .WithMany(p => p.Family)
//                    .HasForeignKey(d => d.OrderId)
//                    .HasConstraintName("FK_Family_Order");
//            });

//            modelBuilder.Entity<Genus>(entity =>
//            {
//                entity.Property(e => e.GenusId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("genusId");

//                entity.Property(e => e.FamilyId).HasColumnName("familyId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.HasOne(d => d.Family)
//                    .WithMany(p => p.Genus)
//                    .HasForeignKey(d => d.FamilyId)
//                    .HasConstraintName("FK_Genus_Family");
//            });

//            modelBuilder.Entity<Gpslocalization>(entity =>
//            {
//                entity.ToTable("GPSLocalization");

//                entity.Property(e => e.GpslocalizationId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("GPSLocalizationId");

//                entity.Property(e => e.Latitude).HasColumnName("latitude");

//                entity.Property(e => e.Longitude).HasColumnName("longitude");

//                entity.Property(e => e.MarginOfError).HasColumnName("marginOfError");
//            });

//            modelBuilder.Entity<Habitat>(entity =>
//            {
//                entity.Property(e => e.HabitatId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("habitatId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.Property(e => e.NationalClassification)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("nationalClassification");
//            });

//            modelBuilder.Entity<Herbarium>(entity =>
//            {
//                entity.Property(e => e.HerbariumId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("herbariumId");

//                entity.Property(e => e.CollectionId).HasColumnName("collectionId");

//                entity.Property(e => e.InventoryNumber).HasColumnName("inventoryNumber");

//                entity.Property(e => e.PersonCollectorId).HasColumnName("personCollectorId");

//                entity.Property(e => e.PersonDetermineId).HasColumnName("personDetermineId");

//                entity.Property(e => e.PiecesOfPlantsId).HasColumnName("piecesOfPlantsId");

//                entity.Property(e => e.SpiecesId).HasColumnName("spiecesId");

//                entity.Property(e => e.YearOfCollection)
//                    .HasColumnType("date")
//                    .HasColumnName("yearOfCollection");

//                entity.HasOne(d => d.Collection)
//                    .WithMany(p => p.Herbarium)
//                    .HasForeignKey(d => d.CollectionId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Herbarium_Collection");

//                entity.HasOne(d => d.PersonCollector)
//                    .WithMany(p => p.HerbariumPersonCollector)
//                    .HasForeignKey(d => d.PersonCollectorId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Herbarium_Person");

//                entity.HasOne(d => d.PersonDetermine)
//                    .WithMany(p => p.HerbariumPersonDetermine)
//                    .HasForeignKey(d => d.PersonDetermineId)
//                    .HasConstraintName("FK_Herbarium_Person1");

//                entity.HasOne(d => d.PiecesOfPlants)
//                    .WithMany(p => p.Herbarium)
//                    .HasForeignKey(d => d.PiecesOfPlantsId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Herbarium_PartOfPlant");

//                entity.HasOne(d => d.Spieces)
//                    .WithMany(p => p.Herbarium)
//                    .HasForeignKey(d => d.SpiecesId)
//                    .HasConstraintName("FK_Herbarium_Species");
//            });

//            modelBuilder.Entity<Kingdom>(entity =>
//            {
//                entity.Property(e => e.KingdomId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("kingdomId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("name");
//            });

//            modelBuilder.Entity<Museum>(entity =>
//            {
//                entity.HasKey(e => e.MuseumId)
//                    .HasName("museumId")
//                    .IsClustered(false); ;

//                entity.Property(e => e.City)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("city");

//                entity.Property(e => e.Country)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("country");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.Property(e => e.PostalCode)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("postalCode");

//                entity.Property(e => e.StreetName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("streetName");

//                entity.Property(e => e.StreetNumber)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("streetNumber");
//            });

//            modelBuilder.Entity<Observation>(entity =>
//            {
//                entity.Property(e => e.ObservationId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("observationId");

//                entity.Property(e => e.Date)
//                    .HasColumnType("date")
//                    .HasColumnName("date");

//                entity.Property(e => e.ExpeditionId).HasColumnName("expeditionId");

//                entity.Property(e => e.GpslocalizationId).HasColumnName("GPSLocalizationId");

//                entity.Property(e => e.HabitatId).HasColumnName("habitatId");

//                entity.Property(e => e.PersonId).HasColumnName("personId");

//                entity.Property(e => e.SpeciesId).HasColumnName("speciesId");

//                entity.HasOne(d => d.Expedition)
//                    .WithMany(p => p.Observation)
//                    .HasForeignKey(d => d.ExpeditionId)
//                    .HasConstraintName("FK_Observation_Expedition");

//                entity.HasOne(d => d.Gpslocalization)
//                    .WithMany(p => p.Observation)
//                    .HasForeignKey(d => d.GpslocalizationId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Observation_GPSLocalization");

//                entity.HasOne(d => d.Habitat)
//                    .WithMany(p => p.Observation)
//                    .HasForeignKey(d => d.HabitatId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Observation_Habitat");

//                entity.HasOne(d => d.Person)
//                    .WithMany(p => p.Observation)
//                    .HasForeignKey(d => d.PersonId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Observation_Person");

//                entity.HasOne(d => d.Species)
//                    .WithMany(p => p.Observation)
//                    .HasForeignKey(d => d.SpeciesId)
//                    .HasConstraintName("FK_Observation_Species");
//            });

//            modelBuilder.Entity<Order>(entity =>
//            {
//                entity.Property(e => e.OrderId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("orderId");

//                entity.Property(e => e.ClassId).HasColumnName("classId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.HasOne(d => d.Class)
//                    .WithMany(p => p.Order)
//                    .HasForeignKey(d => d.ClassId)
//                    .HasConstraintName("FK_Order_Class");
//            });

//            modelBuilder.Entity<PartOfPlant>(entity =>
//            {
//                entity.HasKey(e => e.PlantId);

//                entity.Property(e => e.PlantId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("plantId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");
//            });

//            modelBuilder.Entity<Person>(entity =>
//            {
//                entity.Property(e => e.PersonId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("personId");

//                entity.Property(e => e.LastName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("lastName");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");

//                entity.Property(e => e.Title)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("title");
//            });

//            modelBuilder.Entity<Reference>(entity =>
//            {
//                entity.Property(e => e.ReferenceId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("referenceId");

//                entity.Property(e => e.AuthorId).HasColumnName("authorId");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("description");

//                entity.Property(e => e.SpeciesId).HasColumnName("speciesId");

//                entity.Property(e => e.Title)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("title");

//                entity.Property(e => e.TypeOfReferenceId).HasColumnName("typeOfReferenceId");

//                entity.Property(e => e.Year)
//                    .HasColumnType("date")
//                    .HasColumnName("year");

//                entity.HasOne(d => d.Author)
//                    .WithMany(p => p.Reference)
//                    .HasForeignKey(d => d.AuthorId)
//                    .HasConstraintName("FK_Reference_Person");

//                entity.HasOne(d => d.Species)
//                    .WithMany(p => p.Reference)
//                    .HasForeignKey(d => d.SpeciesId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Reference_Species");

//                entity.HasOne(d => d.TypeOfReference)
//                    .WithMany(p => p.Reference)
//                    .HasForeignKey(d => d.TypeOfReferenceId)
//                    .HasConstraintName("FK_Reference_TypeOfReference");
//            });

//            modelBuilder.Entity<Species>(entity =>
//            {
//                entity.Property(e => e.Id)
//                    .ValueGeneratedNever()
//                    .HasColumnName("id");

//                entity.Property(e => e.CommonNameId).HasColumnName("commonNameId");

//                entity.Property(e => e.FullName)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("fullName");

//                entity.Property(e => e.IsAutochthonous)
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("isAutochthonous");

//                entity.Property(e => e.IsEndemic)
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("isEndemic");

//                entity.Property(e => e.IsInvasive)
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("isInvasive");

//                entity.Property(e => e.IsWeed)
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("isWeed");

//                entity.Property(e => e.LatinName)
//                    .IsRequired()
//                    .HasMaxLength(32)
//                    .IsUnicode(false)
//                    .HasColumnName("latinName");

//                entity.Property(e => e.TaxonomicTree).HasColumnName("taxonomicTree");

//                entity.HasOne(d => d.CommonName)
//                    .WithMany(p => p.Species)
//                    .HasForeignKey(d => d.CommonNameId)
//                    .OnDelete(DeleteBehavior.SetNull)
//                    .HasConstraintName("FK_Species_CommonName");

//                entity.HasOne(d => d.TaxonomicTreeNavigation)
//                    .WithMany(p => p.Species)
//                    .HasForeignKey(d => d.TaxonomicTree)
//                    .HasConstraintName("FK_Species_Genus");
//            });

//            modelBuilder.Entity<TypeOfReference>(entity =>
//            {
//                entity.Property(e => e.TypeOfReferenceId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("typeOfReferenceId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("name");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}