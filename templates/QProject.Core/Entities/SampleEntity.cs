using System.ComponentModel.DataAnnotations;
using QProject.Core.Entities.Base;

namespace QProject.Core.Entities
{
  public class SampleEntity : Entity
  {
    [MaxLength(120)]
    public string Description { get; set; }
  }
}
