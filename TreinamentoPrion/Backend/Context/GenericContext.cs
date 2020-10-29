﻿using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Context
{
    public class GenericContext : DbContext
    {
        public GenericContext() : base("a")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
