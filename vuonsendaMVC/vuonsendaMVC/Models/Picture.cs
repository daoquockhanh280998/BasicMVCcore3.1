﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vuonsendaMVC.Models
{
    public partial class Picture
    {
        [Key]
        public int PictureID { get; set; }
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
        public int? PictureCategoryID { get; set; }
        [StringLength(200)]
        public string Link { get; set; }

        [ForeignKey(nameof(CreateBy))]
        [InverseProperty(nameof(Account.Picture))]
        public virtual Account CreateByNavigation { get; set; }
        [ForeignKey(nameof(PictureCategoryID))]
        [InverseProperty("Picture")]
        public virtual PictureCategory PictureCategory { get; set; }
    }
}