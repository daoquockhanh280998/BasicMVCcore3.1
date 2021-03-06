﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vuonsendaMVC.Models
{
    public partial class PictureMainCategory
    {
        public PictureMainCategory()
        {
            PictureCategory = new HashSet<PictureCategory>();
        }

        [Key]
        public int PictureMainCategoryID { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [StringLength(255)]
        public string Thumb { get; set; }
        public bool? Status { get; set; }
        public int? Position { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        public int? ViewTime { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; }

        [ForeignKey(nameof(CreateBy))]
        [InverseProperty(nameof(Account.PictureMainCategory))]
        public virtual Account CreateByNavigation { get; set; }
        [InverseProperty("PictureMainCategory")]
        public virtual ICollection<PictureCategory> PictureCategory { get; set; }
    }
}