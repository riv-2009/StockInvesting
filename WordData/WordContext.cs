using Microsoft.EntityFrameworkCore;
using WordFinder.Models;

namespace WordData
{
    public class WordContext: DbContext
    {
        public DbSet<DictionaryWords> DictionaryWords { get; set; }

    }
}   