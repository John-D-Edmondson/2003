using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _2003.Models;

public partial class Comp2003Context : DbContext
{
    public Comp2003Context()
    {
    }

    public Comp2003Context(DbContextOptions<Comp2003Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Evaluator> Evaluators { get; set; }

    public virtual DbSet<Img> Imgs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evaluator>(entity =>
        {
            entity.HasKey(e => e.EvaluatorId).HasName("PK__Evaluato__B05254E9143CD590");

            entity.ToTable("Evaluator");

            entity.Property(e => e.EvaluatorId)
                .ValueGeneratedNever()
                .HasColumnName("evaluatorID");
            entity.Property(e => e.EvaluatorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("evaluator_name");
        });

        modelBuilder.Entity<Img>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__img__3213E83FA8C7B3CA");

            entity.ToTable("img");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Breadth).HasColumnName("breadth");
            entity.Property(e => e.ChildAge).HasColumnName("child_age");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.EvaluatorId).HasColumnName("evaluatorID");
            entity.Property(e => e.Extent).HasColumnName("extent");
            entity.Property(e => e.ImgDate)
                .HasColumnType("date")
                .HasColumnName("img_date");
            entity.Property(e => e.ImgEvent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("img_event");
            entity.Property(e => e.Picture)
                .HasColumnType("image")
                .HasColumnName("picture");

            entity.HasOne(d => d.Evaluator).WithMany(p => p.Imgs)
                .HasForeignKey(d => d.EvaluatorId)
                .HasConstraintName("FK_PersonOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
