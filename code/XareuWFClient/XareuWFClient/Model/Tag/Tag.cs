using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Tag
{
    public class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Tag()
        {
            this.Id = 0;
            this.Name = "";
        }
    }
}
