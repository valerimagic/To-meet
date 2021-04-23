using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert
{
    public class Donut
    {
        public object  series  { get; set; }
        public object chart { get; set; }
        public object plotOptions { get; set; }
        public object dataLabels { get; set; }
        public object xaxis { get; set; }
        public List<CAteryType> xaxis2 { get; set; }

        public Donut(int height , bool horizontal , bool enabled, List<string> categori, List<int> data_in)
        {
            chart = new { type = "bar", height = height };
            plotOptions = new { bar = new { horizontal = horizontal } };
            dataLabels = new { enabled = enabled };
            xaxis = new { categories = categori };
            series = new { name = "name", data = data_in };
            xaxis2 = new List<CAteryType>();
        }
    }
}


// 1. Играждане на стуктура в която всички обекти от JSON са конкретни обекти в C# (class)
// 2. Използване на анонимни обекти за някои части