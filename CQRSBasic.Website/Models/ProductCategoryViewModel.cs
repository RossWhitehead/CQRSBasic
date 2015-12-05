﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSBasic.Website.Models
{
    public class ProductCategoryViewModel
    {
        [Required]
        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name="Name")]
        public string ProductCategoryName { get; set; }
    }
}
