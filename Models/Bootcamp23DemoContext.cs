using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp_23_todo_list_api.Models;

public partial class Bootcamp23DemoContext : DbContext
{
    public Bootcamp23DemoContext()
    {
    }

    public Bootcamp23DemoContext(DbContextOptions<Bootcamp23DemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ToDoList> ToDoLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoList>(entity =>
        {
            entity.ToTable("ToDoList");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Task)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
