﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRNAssG8.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UserId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}