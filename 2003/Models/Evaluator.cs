using System;
using System.Collections.Generic;

namespace _2003.Models;

public partial class Evaluator
{
    public int EvaluatorId { get; set; }

    public string? EvaluatorName { get; set; }

    public virtual ICollection<Img> Imgs { get; } = new List<Img>();
}
