using System;
using System.Globalization;

namespace YearAgeList.Models
{
    public class DateRange
    {
        private readonly CultureInfo culture = new CultureInfo("ja-JP", false);
        private readonly JapaneseCalendar japaneseCalendar = new JapaneseCalendar();

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public DateRange(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
            this.culture.DateTimeFormat.Calendar = this.japaneseCalendar;
        }

        public DateRange(string start, string end)
        {
            this.Start = DateTime.Parse(start);
            this.End = DateTime.Parse(end);
            this.culture.DateTimeFormat.Calendar = this.japaneseCalendar;
        }

        public string ToJapaneseCalendarString(string separate = "～")
        {
            var start = this.Start.ToString("ggyy年MM月dd日", culture);
            var end = this.End.ToString("ggyy年MM月dd日", culture);
            return $"{start}{separate}{end}";
        }

        public string ToCommonEraString(string separate = "～")
        {
            var start = this.Start.ToString("yyyy年MM月dd日");
            var end = this.End.ToString("yyyy年MM月dd日");
            return $"{start}{separate}{end}";
        }
    }
}
