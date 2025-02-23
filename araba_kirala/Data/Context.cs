﻿using araba_kirala.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace araba_kirala.Data
{
    public class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        //classı üzerine gel ctrl . noktaya baş
        public Context(DbContextOptions<Context>options):base(options)
        {
        }
        public DbSet<Brands> ?Brands { get; set; }
        public DbSet<Cars>? Cars { get; set; } 
        public DbSet<Colors>? Colors { get; set; }  
        public DbSet<Rentals>?Rentals { get; set;}
        public DbSet<Users>? Users { get; set; }    

    }
}
