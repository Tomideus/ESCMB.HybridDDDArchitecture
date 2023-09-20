using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain.Entities;


namespace ESCMB.Domain.Entities
{
    public class Account : DomainEntity<Domain.Validators.AccountValidator>
    {
        public string Id { get; private set; }
        public int Saldo { get; private set; }

        public Account(string id , int saldo)
        {
            Id = id;
            Saldo = saldo;
        }

    }
}
