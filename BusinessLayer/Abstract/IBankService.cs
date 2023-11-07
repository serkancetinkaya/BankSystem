using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBankService
    {
        List<Bank> GetBank();
        Bank GetBank(int id);
        Bank CreateBank(Bank bank);
        Bank UpdateBank(Bank bank);
        void DeleteBank(int id);
    }
}
