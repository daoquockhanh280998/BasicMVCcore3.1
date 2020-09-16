﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vuonsendaMVC.Models
{
    public partial class Article
    {
        [Key]
        public int ArticleID { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(4000)]
        public string Dercription { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [StringLength(255)]
        public string Thumb { get; set; }
        [StringLength(4000)]
        public string Content { get; set; }
        public int? ViewTime { get; set; }
        public double? Price { get; set; }
        public double? OldPrice { get; set; }
        [StringLength(4000)]
        public string Promotions { get; set; }
        [StringLength(4000)]
        public string WarrantyPolicy { get; set; }
        [StringLength(4000)]
        public string Specifications { get; set; }
        [StringLength(4000)]
        public string Accessories { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public int? Position { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; }
        public int? ArticleCategoryID { get; set; }
        [StringLength(1000)]
        public string sourcelink { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; }
        [StringLength(500)]
        public string SourcePage { get; set; }

        [ForeignKey(nameof(ArticleCategoryID))]
        [InverseProperty("Article")]
        public virtual ArticleCategory ArticleCategory { get; set; }
        [ForeignKey(nameof(CreateBy))]
        [InverseProperty(nameof(Account.Article))]
        public virtual Account CreateByNavigation { get; set; }
    }
}