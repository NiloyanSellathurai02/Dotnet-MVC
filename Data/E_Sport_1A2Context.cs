using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Sport_1A2.Models;

namespace E_Sport_1A2.Data
{
    public class E_Sport_1A2Context : DbContext
    {
        public E_Sport_1A2Context (DbContextOptions<E_Sport_1A2Context> options)
            : base(options)
        {
        }

        public DbSet<E_Sport_1A2.Models.Team> Team { get; set; } = default!;
    }
}
