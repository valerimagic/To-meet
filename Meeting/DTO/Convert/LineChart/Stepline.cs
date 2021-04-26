using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert.LineChart
{
    public class Stepline
    {
        public object Series { get; set; }

        public object Chart { get; set; }

        public object Stroke { get; set; }

        public object DataLabels { get; set; }

        public object Title { get; set; }

        public Hover Markers { get; set; }


        public Stepline(int height, List<int> number)
        {
            Series = new { name = "stepline-series", data = number };
            Chart = new { type = "line", height = height };
            Stroke = new { curve = "stepline" };
            DataLabels = new { enabled = false };
            Title = new { text = "Stepline Chart", align = "left" };
            Markers = new Hover();
        }

    }
}
