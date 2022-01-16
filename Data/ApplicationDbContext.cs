using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using csiWSGeniuzPOS.Model;

namespace csiWSGeniuzPOS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<csiWSGeniuzPOS.Model.CsPlu> CsPlu { get; set; }
    }
}
