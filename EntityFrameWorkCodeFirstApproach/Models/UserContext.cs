﻿using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkCodeFirstApproach.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Users> Users { get; set; }
    }
}
