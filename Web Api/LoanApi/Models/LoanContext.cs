using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoanApi.Models
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options)
            : base(options)
        {
        }

        public DbSet<Loan> Loans { get; set; }

    }
}
