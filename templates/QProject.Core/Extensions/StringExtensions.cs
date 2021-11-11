using System.Text.RegularExpressions;

namespace QProject.Core.Extensions
{
  public static class StringExtensions
  {
    private static string Sluggify(this string phrase)
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