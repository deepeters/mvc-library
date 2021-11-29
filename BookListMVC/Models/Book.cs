﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        public String Name { get; set; }

        public String Author { get; set; }

        public String ISBN { get; set; }
    }
}