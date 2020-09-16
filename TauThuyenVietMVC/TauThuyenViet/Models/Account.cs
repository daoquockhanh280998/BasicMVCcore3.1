﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TauThuyenViet.Models
{
    public partial class Account
    {
        public Account()
        {
            Article = new HashSet<Article>();
            ArticleCategory = new HashSet<ArticleCategory>();
            ArticleMainCategory = new HashSet<ArticleMainCategory>();
            Contact = new HashSet<Contact>();
            ContactCategory = new HashSet<ContactCategory>();
            Product = new HashSet<Product>();
            ProductCategory = new HashSet<ProductCategory>();
            ProductMainCategory = new HashSet<ProductMainCategory>();
        }

        [Key]
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(150)]
        public string Password { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [StringLength(255)]
        public string Thumb { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Mobi { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public bool? Gender { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [StringLength(50)]
        public string AccountCategoryID { get; set; }

        [ForeignKey("AccountCategoryID")]
        [InverseProperty("Account")]
        public virtual AccountCategory AccountCategory { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<Article> Article { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<ArticleCategory> ArticleCategory { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<ArticleMainCategory> ArticleMainCategory { get; set; }
        [InverseProperty("ApproveByNavigation")]
        public virtual ICollection<Contact> Contact { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<ContactCategory> ContactCategory { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<Product> Product { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        [InverseProperty("CreateByNavigation")]
        public virtual ICollection<ProductMainCategory> ProductMainCategory { get; set; }
    }
}