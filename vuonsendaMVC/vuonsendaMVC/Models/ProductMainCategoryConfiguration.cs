﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace vuonsendaMVC.Models
{
    public class ProductMainCategoryConfiguration : IEntityTypeConfiguration<ProductMainCategory>
    {
        public void Configure(EntityTypeBuilder<ProductMainCategory> entity)
        {
            entity.HasOne(d => d.CreateByNavigation)
                .WithMany(p => p.ProductMainCategory)
                .HasForeignKey(d => d.CreateBy)
                .HasConstraintName("FK_ProductMainCategory_Account");
        }
    }
}
