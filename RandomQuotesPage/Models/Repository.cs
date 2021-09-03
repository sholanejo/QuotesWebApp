using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomQuotesPage.Models
{
    public class Repository
    {
        private static List<QuotesModel> quotes = new List<QuotesModel>();
        public static IEnumerable<QuotesModel> Quotes => quotes;
        public static void AddQuote(QuotesModel quote)
        {
            quotes.Add(quote);
        }
    }
}
