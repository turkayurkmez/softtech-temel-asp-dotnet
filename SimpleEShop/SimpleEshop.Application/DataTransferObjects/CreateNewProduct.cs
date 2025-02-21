﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEshop.Application.DataTransferObjects
{
    public class CreateNewProduct
    {
        [Required(ErrorMessage = "Ad alanı boş olamaz")]
        public string Name { get; set; }

        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }

        public string? ImageUrl { get; set; }
    }
}
