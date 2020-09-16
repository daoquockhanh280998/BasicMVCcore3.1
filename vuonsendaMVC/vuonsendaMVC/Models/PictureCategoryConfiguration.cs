﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace vuonsendaMVC.Models
{
    public class PictureCategoryConfiguration : IEntityTypeConfiguration<PictureCategory>
    {
        public void Configure(EntityTypeBuilder<PictureCategory> entity)
        {
            entity.HasOne(d => d.CreateByNavigation)
                .WithMany(p => p.PictureCategory)
                .HasForeignKey(d => d.CreateBy)
                .HasConstraintName("FK_PictureCategory_Account");

            entity.HasOne(d => d.PictureMainCategory)
                .WithMany(p => p.PictureCategory)
                .HasForeignKey(d => d.PictureMainCategoryID)
                .HasConstraintName("FK_PictureCategory_PictureMainCategory");
        }
    }
}
