using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSecurity.Models;

namespace WebSecurity.Data
{
    public class WebSecurityContext : DbContext
    {
        public WebSecurityContext (DbContextOptions<WebSecurityContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<AddFile> AddFile{ get; set; }
    }
}
