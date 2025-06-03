using Microsoft.EntityFrameworkCore;
using MobileManager.Model;

namespace MobileManager.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public required DbSet<Mobile> Mobiles { get; set; }
        public required DbSet<Accessory> Accessories { get; set; }
        public required DbSet<Debtor> Debtors { get; set; }
    }
}
