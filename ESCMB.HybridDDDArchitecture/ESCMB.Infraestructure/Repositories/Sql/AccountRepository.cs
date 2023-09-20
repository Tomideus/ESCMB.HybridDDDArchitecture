using Common.Infraestructure.Repositories.Sql;
using ESCMB.Application.Repositories.Sql;
using ESCMB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Infraestructure.Repositories.Sql
{
    internal class AccountRepository : BaseRepository<Domain.Entities.Account>, IAccountRepository
    {
        public AccountRepository(StoreDbContext context) : base(context)
        {
        }

        public async Task<string> AddOneAsync(Domain.Entities.Account entity)
        {
            entity = entity ?? throw new ArgumentNullException(nameof(entity));

            await Repository.AddAsync(entity);
            await Context.SaveChangesAsync();

            return Context.Entry(entity).Property("Id").CurrentValue.ToString();
        }

    }
}
