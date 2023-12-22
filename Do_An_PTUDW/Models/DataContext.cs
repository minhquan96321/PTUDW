using Do_An_PTUDW.Areas.Admin.Models;
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
    public DbSet<About> Abouts { get; set; }
    public DbSet<View_singlePost> Views { get; set; }
    public DbSet<AdminMenu> AdminMenus { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<AdminUser> Admins { get; set; }
    public DbSet<Comment> Comments { get; set; }
}


