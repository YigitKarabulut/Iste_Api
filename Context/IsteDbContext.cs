using Iste_Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Iste_Api.Context
{
    public class IsteDbContext:DbContext
    {
        public IsteDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
