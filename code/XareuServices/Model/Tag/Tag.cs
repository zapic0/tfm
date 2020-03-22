using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.Tag
{
    public class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag"/> class.
        /// </summary>
        public Tag()
        {
            this.Id = 0;
            this.Name = "";
        }
    }
}
