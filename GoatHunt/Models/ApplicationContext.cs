﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoatHunt.Models
{
 
    public class ApplicationContext : DbContext
    {
        public DbSet<Harvest> Harvests { get; set; }
    }
}
