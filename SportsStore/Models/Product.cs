﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a product description")]
        public string Description { get; set; }

        [Required]
        [Range(.01, double.MaxValue, ErrorMessage = "Please enter a positive number")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please specify category")]
        public string Category { get; set; }
    }
}
