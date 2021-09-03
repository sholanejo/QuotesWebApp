using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandomQuotesPage.Models;

namespace RandomQuotesPage.Models
{
    public class Repository
    {
        public static List<QuotesModel> RandomQuotes = new List<QuotesModel>
        {
            new QuotesModel{QuoteAuthor = "Guitar Heroes", Quote = "The road to glory is filled with many adversities"},
            new QuotesModel{QuoteAuthor = "Jesus Christ", Quote = "I am the way"},
            new QuotesModel{QuoteAuthor = "Eminem", Quote = "Had a dream I was king, I woke up, still king"},
            new QuotesModel{QuoteAuthor = "Shola", Quote = "I am KIng T Major"},
        };

        public static IEnumerable<QuotesModel> GetAll => RandomQuotes;

        public static List<QuotesModel> GetQuotes()
        {
            return RandomQuotes;
        }
        public static void AddQuote(QuotesModel quote)
        {
            RandomQuotes.Add(quote);
        }
    }
}
