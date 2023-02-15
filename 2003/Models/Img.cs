using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2003.Models;

public partial class Img
{
    public int Id { get; set; }

    public byte[]? Picture { get; set; }

    public int? EvaluatorId { get; set; }

    public int? ChildAge { get; set; }

    public DateTime? ImgDate { get; set; }

    public string ImgEvent { get; set; } = null!;

    public int? Depth { get; set; }

    public int? Breadth { get; set; }

    public int? Extent { get; set; }

    public string Comments { get; set; }

    public bool ImgGraded { get; set; }

    [NotMapped]
    public virtual Evaluator? Evaluator { get; set; }
}
