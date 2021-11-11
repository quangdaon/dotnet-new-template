using System.ComponentModel.DataAnnotations;

namespace QProject.Core.Entities.Base
{
  public class Taxonomy : Entity
  {
    [Required, MaxLength(80)]
    public string Name { get; set; }

    [MaxLength(80)]
    public string Slug { get; set; }

    public Taxonomy() { }
  }
}
