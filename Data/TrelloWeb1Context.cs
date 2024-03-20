using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrelloWeb1.Models;

namespace TrelloWeb1.Data
{
    public class TrelloWeb1Context : DbContext
    {
        public TrelloWeb1Context (DbContextOptions<TrelloWeb1Context> options)
            : base(options)
        {
        }

        public DbSet<TrelloWeb1.Models.Customer> Customer { get; set; } = default!;

        public DbSet<TrelloWeb1.Models.Projects>? Projects { get; set; }

        public DbSet<TrelloWeb1.Models.Employee>? Employee { get; set; }
    }
}
