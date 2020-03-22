using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Commands
{
    public class Command
    {
        public string Tab { get; set; }
        public EventArgs Args { get; set; }
    }
}
