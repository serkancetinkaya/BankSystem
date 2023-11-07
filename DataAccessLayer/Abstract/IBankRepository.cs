using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBankRepository
    {
        List<Bank> GetBank();
        Bank GetBank(int id);
        Bank CreateBank(Bank bank);
        Bank UpdateBank(Bank bank);
        void DeleteBank(int id);
    }
}
