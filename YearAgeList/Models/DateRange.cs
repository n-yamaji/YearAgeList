using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearAgeList.Models
{
    public class DateRange
    {
        private readonly string separate = "～";
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

        public string ToJapaneseCalendarString()
        {
            var start = this.Start.ToString("ggy年MM月dd日", culture);
            var end = this.End.ToString("ggy年MM月dd日", culture);
            return $"{start}{separate}{end}";
        }

        public string ToCommonEraString()
        {
            var start = this.Start.ToString("yyyy年MM月dd日");
            var end = this.End.ToString("yyyy年MM月dd日");
            return $"{start}{separate}{end}";
        }
    }
}
