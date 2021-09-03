using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomQuotesPage.Models
{
    public class QuotesModel
    {
        [Required(ErrorMessage ="This field is required")]
        public string QuotePoster { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string QuoteAuthor { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Quote { get; set; }
    }
}
