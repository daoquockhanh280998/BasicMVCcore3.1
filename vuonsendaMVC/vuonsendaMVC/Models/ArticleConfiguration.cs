﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace vuonsendaMVC.Models
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> entity)
        {
            entity.HasOne(d => d.ArticleCategory)
                .WithMany(p => p.Article)
                .HasForeignKey(d => d.ArticleCategoryID)
                .HasConstraintName("FK_Article_ArticleCategory");

            entity.HasOne(d => d.CreateByNavigation)
                .WithMany(p => p.Article)
                .HasForeignKey(d => d.CreateBy)
                .HasConstraintName("FK_Article_Account");
        }
    }
}
