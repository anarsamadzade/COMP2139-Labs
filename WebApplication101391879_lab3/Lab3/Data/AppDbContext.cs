﻿using Microsoft.EntityFrameworkCore;
using System;
using WebApplication2.Models;


namespace WebApplication2.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }

    }   
}
