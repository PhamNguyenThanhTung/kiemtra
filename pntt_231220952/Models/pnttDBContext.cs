using Microsoft.EntityFrameworkCore;
using pntt_231220952.Models;


namespace pntt_231220952.Models
{
    public class pnttDBContext: DbContext
    {
        public pnttDBContext(DbContextOptions<pnttDBContext>options)
            : base(options) { 
        }
        public DbSet<PnttComputer> pnttComputers { get; set; }
    }
}
