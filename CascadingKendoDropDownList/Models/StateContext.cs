﻿using Microsoft.EntityFrameworkCore;

namespace CascadingKendoDropDownList.Models
{

    public class StateContext : DbContext
    {
        public StateContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<state> states { get; set; }
        public DbSet<city> cities { get; set; }
      
    }
}
