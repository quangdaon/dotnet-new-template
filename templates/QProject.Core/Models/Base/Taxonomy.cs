using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace QProject.Core.Models.Base
{
  public class Taxonomy : Entity
  {
    [Required, MaxLength(80)]
    public string Name { get; set; }

    [MaxLength(80)]
    public string Slug { get; set; }

    public Taxonomy() { }

    private static string Sluggify(string phrase)
    {
      if(string.IsNullOrEmpty(phrase)) return null;

      string str = phrase.ToLower();
      str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
      str = Regex.Replace(str, @"\s+", " ").Trim();
      str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
      str = Regex.Replace(str, @"\s", "-"); // hyphens
      return str;
    }
  }
}
