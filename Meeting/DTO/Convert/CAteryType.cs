using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert
{
    public class CAteryType
    {
        public List<string> categories { get; set; }
        public CAteryType()
        {
            categories = new List<string>();
        }
    }
}
