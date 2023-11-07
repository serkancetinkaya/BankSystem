using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BankRepository:IBankRepository
    {
        public EntityLayer.Bank CreateBank(EntityLayer.Bank bank)
        {
            using (var bankDbContext = new BankDbContext())
            {
                bankDbContext.Banks.Add(bank);
                bankDbContext.SaveChanges();
                return bank;
            }
        }

        public void DeleteBank(int id)
        {
            using (var bankDbContext = new BankDbContext())
            {
                var deleteBank = GetBank(id);
                bankDbContext.Banks.Remove(deleteBank);
                bankDbContext.SaveChanges();
            }
        }

        public List<EntityLayer.Bank> GetBank()
        {
            using (var bankDbContext = new BankDbContext())
            {
                return bankDbContext.Banks.ToList();
            }
        }

        public EntityLayer.Bank GetBank(int id)
        {
            using (var bankDbContext = new BankDbContext())
            {
                return bankDbContext.Banks.Find(id);
            }
        }

        public EntityLayer.Bank UpdateBank(EntityLayer.Bank bank)
        {
            using (var bankDbContext = new BankDbContext())
            {
                bankDbContext.Banks.Update(bank);
                bankDbContext.SaveChanges();
                return bank;
            }
        }
    }
}
