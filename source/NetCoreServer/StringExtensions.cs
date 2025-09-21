using System;
using System.Linq;

namespace NetCoreServer;

/// <summary>
/// String extensions utility class.
/// </summary>
public static class StringExtensions
{
    public static string RemoveSuffix(this string self, char toRemove) => string.IsNullOrEmpty(self) ? self : (self.EndsWith(toRemove) ? self[..^1] : self);
    public static string RemoveSuffix(this string self, string toRemove) => string.IsNullOrEmpty(self) ? self : (self.EndsWith(toRemove) ? self[..^toRemove.Length] : self);
    public static string RemoveWhiteSpace(this string self) => string.IsNullOrEmpty(self) ? self : new string([.. self.Where(c => !char.IsWhiteSpace(c))]);
}
