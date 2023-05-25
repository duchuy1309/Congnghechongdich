
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace KLTN_21.Models
{
    public class CountryContext: DbContext 
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
            
        }
        public DbSet<CountryItem> CountryItems { get; set; } = null!;
    }
}
