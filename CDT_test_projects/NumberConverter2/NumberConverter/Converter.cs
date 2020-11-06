using System;
using System.Collections.Generic;

namespace NumberConverter
{
    public class Converter
    {
        private string[] ones = {
            " one", " two", " three", " four", " five",
            " six", " seven", " eight", " nine", " ten",
            " eleven", " twelve", " thirteen", " fourteen",
            " fifteen", " sixteen", " seventeen",
            " eighteen", " nineteen"
        };

        private string[] tens = {
            " twenty", " thirty", " forty", " fifty",
            " sixty", " seventy", " eighty", " ninety"
        };

        private struct ThousandGroup
        {
            public int Cutoff;
            public string Name;
        }

        private List<ThousandGroup> thousandGroups = new List<ThousandGroup>{
            new ThousandGroup { Name = "billion", Cutoff = 1000000000 },
            new ThousandGroup { Name = "million", Cutoff = 1000000 },
            new ThousandGroup { Name = "thousand", Cutoff = 1000 },
            new ThousandGroup { Name = "", Cutoff = 1 },
        };

        public string Convert(long number)
        {
            string result = "";

            foreach(var group in thousandGroups)
            {
                if (number >= group.Cutoff)
                {
                    int thisPart = (int)(number / group.Cutoff);

                    if (thisPart >= 100)
                    {
                        result += ones[thisPart / 100] + " hundred";
                        thisPart = thisPart % 100;
                    }

                    if (thisPart >= 20)
                    {
                        result += tens[(thisPart / 10) - 1];
                        thisPart = thisPart % 10;
                    }

                    if (thisPart >= 1)
                    {
                        result += ones[thisPart];
                    }

                    result += " " + group.Name;

                    number = number % group.Cutoff;
                }
            }

            if (result.Length == 0)
            {
                result = "zero";
            }
            
            return result;
        }
    }
}


