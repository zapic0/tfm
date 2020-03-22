using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class TextArgs : EventArgs
    {
        public string Text { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextArgs"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public TextArgs(string text)
        {
            this.Text = text;
        }
    }
}
