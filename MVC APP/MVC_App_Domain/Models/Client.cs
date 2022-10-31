﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_Domain.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}
