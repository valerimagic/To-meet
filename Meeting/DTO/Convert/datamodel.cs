using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert
{
    public class datamodel
    {
        public string x { get; set; }
        public  List<int>  y{ get; set; }
        public datamodel()
        {
            y = new List<int>();
        }
    }
}
