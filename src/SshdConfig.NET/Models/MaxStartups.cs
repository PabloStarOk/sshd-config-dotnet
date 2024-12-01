namespace SshdConfig.NET.Models;

public class MaxStartups
{
    public int Start { get; set; } = 10;
    public int Rate { get; set; } = 30;
    public int Full { get; set; } = 100;

    public override string ToString() => $"{Start}:{Rate}:{Full}";

    /// <summary>
    /// Returns a MaxStartups object from a string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>A MaxStartups object.</returns>
    /// <exception cref="FormatException">Thrown when the string is not in the correct format.</exception>
    public static MaxStartups Parse(string value)
    {
        var parts = value.Split(':');
        if (parts.Length != 3 || !int.TryParse(parts[0], out var start) ||
            !int.TryParse(parts[1], out var rate) || !int.TryParse(parts[2], out var full))
        {
            throw new FormatException("MaxStartups must be in the format 'start:rate:full'.");
        }

        return new MaxStartups
        {
            Start = start,
            Rate = rate,
            Full = full
        };
    }
}
