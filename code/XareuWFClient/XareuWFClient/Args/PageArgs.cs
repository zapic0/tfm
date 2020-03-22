using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class PageArgs : EventArgs
    {
        public int Page { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PageArgs"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        public PageArgs(int column)
        {
            this.Page = column;
        }
    }
}
