﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Context
{
    public class MovieRentalContext:DbContext

    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}