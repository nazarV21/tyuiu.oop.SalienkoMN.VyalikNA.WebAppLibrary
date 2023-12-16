using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tyuiu.oop.SalienkoMN.VyalikNA.WebAppLibrary.DataModels;

    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<tyuiu.oop.SalienkoMN.VyalikNA.WebAppLibrary.DataModels.User> User { get; set; } = default!;

public DbSet<tyuiu.oop.SalienkoMN.VyalikNA.WebAppLibrary.DataModels.Book> Book { get; set; } = default!;
    }
