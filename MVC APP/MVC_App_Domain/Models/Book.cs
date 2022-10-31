using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_Domain.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public string Title { get; set; }   
        public string Description { get; set; }

        [BindProperty,DataType("month")]   
        public DateTime? YearOfIssue { get; set; }

        public int NumberOfPages { get; set; }

        public string FK_Publisher { get; set; }

    }
}
