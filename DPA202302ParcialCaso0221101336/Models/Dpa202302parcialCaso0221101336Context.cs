using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0221101336.Models;

public partial class Dpa202302parcialCaso0221101336Context : DbContext
{
    public Dpa202302parcialCaso0221101336Context()
    {
    }

    public Dpa202302parcialCaso0221101336Context(DbContextOptions<Dpa202302parcialCaso0221101336Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }
    public virtual DbSet<Territory> Territory { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_“Country”");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
