using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using app.Models;


namespace app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Tvatt>  Tvatts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
