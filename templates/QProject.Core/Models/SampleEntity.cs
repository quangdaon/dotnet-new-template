using System.ComponentModel.DataAnnotations;
using QProject.Core.Models.Base;

namespace QProject.Core.Models
{
  public class SampleEntity : Entity
  {
    [MaxLength(120)]
    public string Description { get; set; }
  }
}
