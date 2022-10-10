using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryOfBookCollection.Models;

namespace InventoryOfBookCollection.Data
{
    public class InventoryOfBookCollectionContext : DbContext
    {
        public InventoryOfBookCollectionContext (DbContextOptions<InventoryOfBookCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryOfBookCollection.Models.Author> Author { get; set; } = default!;

        public DbSet<InventoryOfBookCollection.Models.Book> Book { get; set; }
    }
}
