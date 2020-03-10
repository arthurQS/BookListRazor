using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "bla bla bla")]
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
    }
}
