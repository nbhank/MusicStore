﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    public class Payment
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Amount { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string ProductInfo { get; set; }
        public string Email { get; set; }
    }
}
