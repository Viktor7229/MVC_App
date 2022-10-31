using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_Domain.Models
{
    public class BookCopies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CopiesFK_Book { get; set; }

        public int CopiesNumberOfCopies { get; set; }

        public string CopiesFK_Library { get; set; }

    }
}
