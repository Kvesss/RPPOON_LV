using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_4
{
    class BankAccountMemento
    {
        public BankAccountMemento(string ownerName, string ownerAddress, decimal balance)
        {
            OwnerName = ownerName;
            OwnerAddress = ownerAddress;
            Balance = balance;
        }

        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
    }
}
