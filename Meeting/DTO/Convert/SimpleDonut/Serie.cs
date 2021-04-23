using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert.SimpleDonut
{
    public class Series
    {
        private List<int> number;

        public Series()
        {
            number = new List<int>();
        }

        public List<int> Number => this.number;
    }
}
