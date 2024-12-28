using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public required DbSet<Mobile> Mobiles { get; set; }
    public required DbSet<Accessory> Accessories { get; set; }
    public required DbSet<Debtor> Debtors { get; set; }
}
