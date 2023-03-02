using BigMuscleShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products{ get; set; }
        Task SaveChangesAsync();
    }
}
