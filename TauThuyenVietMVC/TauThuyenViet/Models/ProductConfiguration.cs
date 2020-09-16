﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TauThuyenViet.Models
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasOne(d => d.CreateByNavigation)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.CreateBy)
                .HasConstraintName("FK_Product_Account");

            entity.HasOne(d => d.ProductCategory)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.ProductCategoryID)
                .HasConstraintName("FK_Product_ProductCategory");
        }
    }
}