using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearAgeList.Models
{
    public class Age
    {
        private int number;
        public DateRange BirthRange { get; private set; }

        public Age(int year, int age)
        {
            this.number = age;

            DateTime start = new DateTime(year - age,4,1);
            DateTime end = new DateTime(year - age + 1, 3, 31);
            this.BirthRange = new DateRange(start, end);
        }

        public override string ToString()
        {
            return this.number.ToString();
        }

        public string ToJapaneseCalendarString(string separate = "～")
        {
            return this.BirthRange.ToJapaneseCalendarString(separate);
        }

        public string ToCommonEraString(string separate = "～")
        {
            return this.BirthRange.ToCommonEraString(separate);
        }
    }
}
