using System.Text.RegularExpressions;

namespace METLIFE
{
    public static class FrequencyCleaner
    {
        public static string Clean(string freqInfo)
        {
            string f = freqInfo?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(f))
                return "NO FREQ";

            if (Regex.IsMatch(f, "not covered", RegexOptions.IgnoreCase))
                return "Not covered";

            if (Regex.IsMatch(f, "no limitations|not available|cannot currently provide coverage", RegexOptions.IgnoreCase))
                return "NO FREQ";

            if (Regex.IsMatch(f, "once per lifetime|1\\s+in\\s+99\\s+calendar", RegexOptions.IgnoreCase))
                return "1/Lifetime";

            if (Regex.IsMatch(f, "(children|age 19).*adults", RegexOptions.IgnoreCase))
                return "2/CY FOR CHILDREN AND 1/CY FOR ADULTS";

            var yearMatch = Regex.Match(
                f,
                @"(\d+)\s+(?:times?|per|every)?\s*(?:in\s+)?(\d+)\s+(fiscal|calendar)\s+year",
                RegexOptions.IgnoreCase);

            if (yearMatch.Success)
            {
                string count = yearMatch.Groups[1].Value;
                string period = yearMatch.Groups[2].Value;
                string unit = yearMatch.Groups[3].Value.ToUpper().StartsWith("F") ? "FY" : "CY";
                return period == "1" ? count + "/" + unit : count + "/" + period;
            }

            var monthMatch = Regex.Match(
                f,
                @"(\d+)\s+(?:times?|per|every)?\s*(?:in\s+)?(\d+)\s+months",
                RegexOptions.IgnoreCase);

            if (monthMatch.Success)
            {
                string count = monthMatch.Groups[1].Value;
                string period = monthMatch.Groups[2].Value;
                return period == "1" ? count + "/MTS" : count + "/" + period;
            }

            // Fallback: return the original extracted text unchanged
            return f;
        }
    }
}
