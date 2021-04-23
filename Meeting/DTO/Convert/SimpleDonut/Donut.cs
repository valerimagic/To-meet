using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert.SimpleDonut
{
    class Donut
    {
        public List<int> series { get; set; }
        public object chart { get; set; }
        public List<string> labels { get; set; }
        public List<Responsive> responsive { get; set; }

        public Donut(List<int> number, List<string> label)
        {
            series = new List<int>();
            chart = new { type = "donut" };
            responsive = new List<Responsive>();
            labels = new List<string>();
            //responsive =  new { breakpoint = 480  = new { colors = new { chart =  } } };
        }
    }
}

