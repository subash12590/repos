using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxJquery.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<transactionModels> transactionModels { get; set; }
    }
}
