using Microsoft.EntityFrameworkCore;
using MobileManager.Data;
using MobileManager.Model;

namespace MobileManager.Service
{
    public class MobileManagerService(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        #region Mobile
        public async Task<Mobile?> GetMobile(Guid id) =>
            await _context.Mobiles.AsNoTracking().SingleOrDefaultAsync(m => m.Id == id);

        public async Task<IEnumerable<Mobile>> GetMobiles() =>
            await _context.Mobiles.AsNoTracking().ToListAsync();

        public async Task<Mobile> AddMobile(Mobile mobile)
        {
            await _context.Mobiles.AddAsync(mobile);
            await _context.SaveChangesAsync();
            return mobile;
        }

        public async Task UpdateMobile(Mobile mobile)
        {
            _context.Mobiles.Update(mobile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMobile(Mobile mobile)
        {
            _context.Mobiles.Remove(mobile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllMobiles()
        {
            await _context.Mobiles.ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Accessory
        public async Task<Accessory?> GetAccessory(Guid id) =>
            await _context.Accessories.AsNoTracking().SingleOrDefaultAsync(a => a.Id == id);

        public async Task<IEnumerable<Accessory>> GetAccessories() =>
            await _context.Accessories.AsNoTracking().ToListAsync();

        public async Task<Accessory> AddAccessory(Accessory accessory)
        {
            await _context.Accessories.AddAsync(accessory);
            await _context.SaveChangesAsync();
            return accessory;
        }

        public async Task UpdateAccessory(Accessory accessory)
        {
            _context.Accessories.Update(accessory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAccessory(Accessory accessory)
        {
            _context.Accessories.Remove(accessory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllAccessories()
        {
            await _context.Accessories.ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Debtor
        public async Task<Debtor?> GetDebtor(Guid id) =>
            await _context.Debtors.AsNoTracking().SingleOrDefaultAsync(d => d.Id == id);

        public async Task<IEnumerable<Debtor>> GetDebtors() =>
            await _context.Debtors.AsNoTracking().ToListAsync();

        public async Task<Debtor> AddDebtor(Debtor debtor)
        {
            await _context.Debtors.AddAsync(debtor);
            await _context.SaveChangesAsync();
            return debtor;
        }

        public async Task UpdateDebtor(Debtor debtor)
        {
            _context.Debtors.Update(debtor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDebtor(Debtor debtor)
        {
            _context.Debtors.Remove(debtor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllDebtors()
        {
            await _context.Debtors.ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }
        #endregion
    }

}
