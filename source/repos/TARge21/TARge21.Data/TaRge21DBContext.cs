using System;
using Microsoft.EntityFrameworkCore;
using TARge21.Core;

namespace TARge21.Data
{
    public class TaRge21DBContext: DbContext
    {
        public TaRge21DBContext(DbContextOptions<TaRge21DBContext> options) : base(options)     
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}