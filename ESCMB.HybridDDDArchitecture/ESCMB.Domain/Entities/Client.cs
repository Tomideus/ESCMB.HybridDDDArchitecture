using Common.Domain.Entities;
using ESCMB.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Entities
{
   
    public class Client:DomainEntity<Clientvalidator>
    {
        public string Id { get; private set; }
        public string Email { get; private set; }

        public Client()
        {

        }

        public Client(string id, string email)
        {
            Id = id;
            Email = email;
        }


    }

   
}
