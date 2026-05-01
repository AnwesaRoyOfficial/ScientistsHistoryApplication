using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
<<<<<<< HEAD
    public DbSet<Member> Members { get; set; }
    public DbSet<Photo> Photos { get; set; }
=======
>>>>>>> fb7632f2213c77f519721db927098cea7144822b
}
