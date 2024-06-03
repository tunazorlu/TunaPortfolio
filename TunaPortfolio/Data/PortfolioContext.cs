using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using static TunaPortfolio.Data.PortfolioContext;

namespace TunaPortfolio.Data
{
    public class PortfolioContext(DbContextOptions<PortfolioContext> options) : IdentityDbContext<IdentityUser>(options)
    {
       /* public DbSet<Deneyim> Deneyimler { get; set; }
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Hakkimda> Hakkimdalar { get; set; }
        public DbSet<Hobi> Hobiler { get; set; }
        public DbSet<Iletisim> Iletisimler { get; set; }
        public DbSet<Sertifika> Sertifikalar { get; set; }
        public DbSet<Yetenek> Yetenekler { get; set; }*/
    }
}
