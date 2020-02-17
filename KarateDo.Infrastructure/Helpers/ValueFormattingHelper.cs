using System;
using System.Collections.Generic;
using System.Linq;

namespace KarateDo.Infrastructure.Helpers
{
    /*
    * The Value formatting helper class
    * Contains methods for formatting values
    */
    /// <summary>
    /// The <c>ValueFormatting</c> helper class.
    /// Contains methods for formatting values
    /// </summary>
    public static class ValueFormattingHelper
    {
        public static string NotApplicable { get; private set; } = "N/A";

        public static string FormatIdValue(int value)
        {
            return value.ToString("D");
        }
        public static string FormatValue(string value, string sufix = "")
        {
            return string.IsNullOrEmpty(value) ? NotApplicable : (value + (string.IsNullOrEmpty(sufix) ? string.Empty : " " + sufix));
        }
        public static string FormatValue(int? value, string format = "#,0", string sufix = "")
        {
            return value.HasValue ? (value.Value.ToString(format) + (string.IsNullOrEmpty(sufix) ? string.Empty : " " + sufix)) : NotApplicable;
        }
        public static string FormatValue(decimal? value, string format = "#,0.00", string sufix = "")
        {
            return value.HasValue ? (value.Value.ToString(format) + (string.IsNullOrEmpty(sufix) ? string.Empty : " " + sufix)) : NotApplicable;
        }

        public static string FormatNonZeroValue(decimal? value, string format = "#,0.0")
        {
            return value.HasValue && value.Value != decimal.Zero ? value.Value.ToString(format) : NotApplicable;
        }
        
        public static string FormatValue(DateTime? value, string format = "d")
        {
            return value.HasValue
                ? value.Value != DateTime.MinValue
                    ? value.Value.ToString(format)
                    : NotApplicable
                : NotApplicable;
        }
        public static string FormatDate(DateTime? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("dd/MM/yyyy");
            }
            return NotApplicable;
        }
        public static string FormatDateToLongDate(DateTime? value)
        {
            if (value.HasValue)
            {
                return string.Format("{0:dd}{1} {0:MMMM yyyy}", value.Value, getDaySufix(value.Value));
            }
            return NotApplicable;
        }
        private static string getDaySufix(DateTime date)
        {
            return
            (date.Day % 10 == 1 && date.Day != 11) ? "st"
            : (date.Day % 10 == 2 && date.Day != 12) ? "nd"
            : (date.Day % 10 == 3 && date.Day != 13) ? "rd"
            : "th";
        }
        public static string FormatDateToYear(DateTime? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("yyyy");
            }
            return NotApplicable;
        }
        public static string FormatPercentageValue(int? value, int? total)
        {
            return
                value.HasValue && total.HasValue
                    ? total.Value != 0
                        ? $"{value.Value:#,0} ({(1.0 * value.Value) / total.Value:P2})"
                        : "0 (0.00 %)"
                    : NotApplicable;
        }
        public static string FormatPercentageValue(decimal? value, decimal? total)
        {
            return
                value.HasValue && total.HasValue
                    ? total.Value != 0
                        ? $"{value.Value:#,0.00} ({value.Value / total.Value:P2})"
                        : "0.00 (0.00 %)"
                    : NotApplicable;
        }
        public static string FormatPercentageValue(decimal? value)
        {
            if (value.HasValue)
            {
                return $"{value:N5}%";
            }
            return NotApplicable;
        }

        public static string FormatPercentageValueWithoutDecimalPlaces(decimal? value)
        {
            if (value.HasValue)
            {
                return $"{value:N0}%";
            }
            return NotApplicable;
        }

        public static string FormatValueWithPercentage(int? value, int? total, string infix = "")
        {
            return
                value.HasValue && total.HasValue
                    ? total.Value != 0
                        ? ($"{value.Value:#,0} " + (infix != string.Empty ? infix : string.Empty) + $" ({(1.0 * value.Value) / total.Value:P2})")
                        : "0 " + (infix != string.Empty ? infix : string.Empty) + " (0.00 %)"
                    : NotApplicable;
        }

        public static string FormatValueWithPercentage(decimal? value, decimal? total, string infix = "")
        {
            return
                value.HasValue && total.HasValue
                    ? total.Value != 0
                        ? ($"{value.Value:#,0.00} " + (infix != "" ? infix : string.Empty) + $" ({value.Value / total.Value:P2})")
                        : "0.00 " + (infix != string.Empty ? infix : string.Empty) + " (0.00 %)"
                    : NotApplicable;
        }

        public static string FormatValue(IEnumerable<string> value)
        {
            return value != null && value.Any() ? string.Join(", ", value) : NotApplicable;
        }

        public static string FormatValueFromCommaSeparatedString(string input)
        {
            string resultString = "N/A";

            if (!string.IsNullOrEmpty(input))
            {
                resultString = string.Empty;
                var values = input.Split(';');

                foreach (var val in values)
                {
                    resultString += string.Format("{0}; ", val.Substring(val.IndexOf('-') + 1));
                }

                resultString = resultString.Substring(0, resultString.Length - 2);
            }

            return resultString;
        }
    }
}