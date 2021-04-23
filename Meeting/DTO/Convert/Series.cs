using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Convert
{
    public class Series
    {
        private string type ;
        private List<datamodel> data;
        public Series(string type)
        {
            type = this.type;
            data = new List<datamodel>();
        }

        public List<datamodel> Data => this.data;
    }
}
