using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearAgeList.Models
{
    public class AgeList
    {
        private int year;
        private int ageMin;
        private int ageMax;
        public AgeList(int year,int ageMin,int ageMax)
        {
            this.year = year;
            this.ageMin = ageMin;
            this.ageMax = ageMax;
        }

        public IEnumerable<Age> GetList()
        {
            for (int age = this.ageMin; age <= this.ageMax; age++)
            {
                yield return new Age(this.year, age);
            }
        }
    }
}
