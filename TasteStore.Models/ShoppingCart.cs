﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TasteStore.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Quantity = 1;
        }

        public int Id { get; set; }

        public int MenuItemId { get; set; }

        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }

        public string ApplicationUserId { get; set; }

        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Range(1, 100, ErrorMessage = "Please select a quantity between 1 and 100")]
        public int Quantity { get; set; }
    }
}
