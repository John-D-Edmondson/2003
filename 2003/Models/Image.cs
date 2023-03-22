using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _2003.Models;

[Table("Image")]
public partial class Image
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("picture", TypeName = "image")]
    public string Picture { get; set; }

    [ForeignKey("EvaluatorId")]
    [Column("evaluatorID")]
    public int? EvaluatorId { get; set; }

    [Column("child_age")]
    public int? ChildAge { get; set; }

    [Column("img_date", TypeName = "date")]
    public DateTime? ImgDate { get; set; }

    [Column("img_event")]
    [StringLength(50)]
    [Unicode(false)]
    public string ImgEvent { get; set; } = null!;

    [Column("depth1")]
    public int? Depth1 { get; set; }

    [Column("breadth1")]
    public bool? Breadth1 { get; set; }

    [Column("extent1")]
    public int? Extent1 { get; set; }

    [Column("depth2")]
    public int? Depth2 { get; set; }

    [Column("breadth2")]
    public bool? Breadth2 { get; set; }

    [Column("extent2")]
    public int? Extent2 { get; set; }

    [Column("depth3")]
    public int? Depth3 { get; set; }

    [Column("breadth3")]
    public bool? Breadth3 { get; set; }

    [Column("extent3")]
    public int? Extent3 { get; set; }

    [Column("depth4")]
    public int? Depth4 { get; set; }

    [Column("breadth4")]
    public bool? Breadth4 { get; set; }

    [Column("extent4")]
    public int? Extent4 { get; set; }

    [Column("depth5")]
    public int? Depth5 { get; set; }

    [Column("breadth5")]
    public bool? Breadth5 { get; set; }

    [Column("extent5")]
    public int? Extent5 { get; set; }

    [Column("depth6")]
    public int? Depth6 { get; set; }

    [Column("breadth6")]
    public bool? Breadth6 { get; set; }

    [Column("extent6")]
    public int? Extent6 { get; set; }

    [Column("depth7")]
    public int? Depth7 { get; set; }

    [Column("breadth7")]
    public bool? Breadth7 { get; set; }

    [Column("extent7")]
    public int? Extent7 { get; set; }

    [StringLength(500)]
    public string Comments { get; set; } = null!;

    [Required]
    public bool? ImgGraded { get; set; }

    [JsonIgnore]
    [InverseProperty("Images")]
    public virtual Evaluator? Evaluator { get; set; }
}
