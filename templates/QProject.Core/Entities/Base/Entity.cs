using System.ComponentModel.DataAnnotations;

namespace QProject.Core.Entities.Base
{
  public class Entity
  {
    [Key]
    public int Id { get; set; }
  }
}
