using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class CrmContext : DbContext
    {        
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
