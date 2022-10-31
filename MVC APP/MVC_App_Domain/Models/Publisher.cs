using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_Domain.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public string Name { get; set; }    
        public string Country { get; set; } 
    }
}
