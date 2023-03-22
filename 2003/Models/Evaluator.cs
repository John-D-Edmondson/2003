using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _2003.Models;

[Table("Evaluator")]
public partial class Evaluator
{
    [Key]
    [Column("evaluatorID")]
    public int EvaluatorId { get; set; }

    [Column("evaluator_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EvaluatorName { get; set; }

    [InverseProperty("Evaluator")]
    public virtual ICollection<Image> Images { get; } = new List<Image>();
}
