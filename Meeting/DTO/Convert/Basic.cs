using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert
{
    public class Basic
    {
        public List<Series> series { get; set; }
        public object chart { get; set; }
        public object title { get; set; }
        public object plotOptions { get; set; }

        public Basic()
        {
            chart = new { height = "350", type = "candlestick" };

            title = new { text = "Basic BoxPlot Chart", align = "left" };

            plotOptions = new { boxPlot = new { colors = new { upper = "#5C4742", lower = "#A5978B" } } };

            series = new List<Series>();

        }
    }
}
