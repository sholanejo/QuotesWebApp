using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomQuotesPage.Models
{
    public class QuotesModel
    {
        [Required(ErrorMessage = "Please enter a valid name for author")]
        public string QuoteAuthor { get; set; }
        [Required(ErrorMessage = "please enter a valid quote text")]
        public string Quote { get; set; }
    }
}
