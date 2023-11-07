using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BankManager:IBankService
    {
        private IBankRepository _bankRepository;
        public BankManager()
        {
            _bankRepository=new BankRepository();
        }
        public Bank CreateBank(Bank bank)
        {
            return _bankRepository.CreateBank(bank);
        }

        public void DeleteBank(int id)
        {
            _bankRepository.DeleteBank(id);
        }

        public List<Bank> GetBank()
        {
            return _bankRepository.GetBank();
        }

        public Bank GetBank(int id)
        {
            if(id > 0)
            {
                return _bankRepository.GetBank(id);
            }
            throw new Exception("Müşteri ID sıfırdan büyük bir değer almalı");
        }

        public Bank UpdateBank(Bank bank)
        {
            return _bankRepository.UpdateBank(bank);
        }
    }
}
