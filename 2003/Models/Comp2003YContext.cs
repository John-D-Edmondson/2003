using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace _2003.Models;

public partial class Comp2003YContext : DbContext
{
    public Comp2003YContext()
    {
    }

    public Comp2003YContext(DbContextOptions<Comp2003YContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evaluator> Evaluators { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evaluator>(entity =>
        {
            entity.HasKey(e => e.EvaluatorId).HasName("PK__Evaluato__B05254E96C9656DA");

            entity.Property(e => e.EvaluatorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Image__3213E83F93566755");

            entity.Property(e => e.Breadth1).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Comments).HasDefaultValueSql("(N'')");
            entity.Property(e => e.ImgGraded).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Evaluator).WithMany(p => p.Images).HasConstraintName("FK_PersonOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
