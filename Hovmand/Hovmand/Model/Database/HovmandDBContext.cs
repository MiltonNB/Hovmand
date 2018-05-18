﻿using System.Diagnostics;
using Hovmand.Model.Domain;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Hovmand.Model.Database
{
    public partial class HovmanddbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Pipeline> Pipelines { get; set; }
        public virtual DbSet<Product> Products { get; set; }    
        public virtual DbSet<User> Users { get; set; }
        private string _dbContextOptionsBuilderSettings = File.ReadAllText(@".\DBContextOptionsBuilderString.txt");


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_dbContextOptionsBuilderSettings);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(o => o.ContactId);
                entity.Property(e => e.ContactId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("contact_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(25);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(25);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(o => o.CustomerId);
                entity.Property(e => e.CustomerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("customer_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(25);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(25);

                entity.Property(e => e.Cvr).HasColumnName("cvr");

                entity.Property(e => e.FkContactId).HasColumnName("fk_contact_id");

                entity.Property(e => e.FkLocationId).HasColumnName("fk_location_id");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.FkContact)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Contacts");

                entity.HasOne(d => d.FkLocation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Locations");
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(o => o.LeadId);
                entity.Property(e => e.LeadId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("lead_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCustomersId).HasColumnName("fk_customers_id");

                entity.Property(e => e.FkPipelineId).HasColumnName("fk_pipeline_id");

                entity.Property(e => e.FkUserId).HasColumnName("fk_user_id");

                entity.Property(e => e.Information)
                    .IsRequired()
                    .HasColumnName("information")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkCustomers)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.FkCustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leads_Customers");

                entity.HasOne(d => d.FkPipeline)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.FkPipelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leads_Pipelines");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leads_Users");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(o => o.LocationId);
                entity.Property(e => e.LocationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("location_id");

                entity.Property(e => e.Areacode).HasColumnName("areacode");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(o => o.OfferId);
                entity.Property(e => e.OfferId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("offer_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkLeadId).HasColumnName("fk_lead_id");

                entity.Property(e => e.FkProductId).HasColumnName("fk_product_id");

                entity.Property(e => e.Information)
                    .IsRequired()
                    .HasColumnName("information")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.FkLead)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.FkLeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offers_Leads");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offers_Products");
            });

            modelBuilder.Entity<Pipeline>(entity =>
            {
                entity.HasKey(o => o.PipelineId);
                entity.Property(e => e.PipelineId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pipeline_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastEdit)
                    .HasColumnName("date_last_edit")
                    .HasColumnType("datetime");

                entity.Property(e => e.Information)
                    .IsRequired()
                    .HasColumnName("information")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(o => o.ProductId);
                entity.Property(e => e.ProductId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("product_id");

                entity.Property(e => e.InStock).HasColumnName("in_stock");

                entity.Property(e => e.Information)
                    .IsRequired()
                    .HasColumnName("information")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(o => o.UserId);
                entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("user_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(25);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(25);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")  
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(10);

            });
        }
    }
}
