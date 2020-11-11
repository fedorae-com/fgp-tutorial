﻿using Microsoft.EntityFrameworkCore;

namespace Tutorion.Models
{
    public class TutorionApiContext : DbContext
    {
        public TutorionApiContext(DbContextOptions<TutorionApiContext> options) : base(options)
        {
        }
        
        public  DbSet<User> Users { get; set; }

    }

}