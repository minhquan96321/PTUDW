using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Do_An_PTUDW.Models;

public partial class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    public DbSet<Blog> Blogs { get; set; }

    public DbSet<Tag> Tags { get; set; }
    public DbSet<View_singlePost> Views { get; set; }
}


