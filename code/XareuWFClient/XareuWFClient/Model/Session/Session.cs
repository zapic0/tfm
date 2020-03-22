using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XareuWFClient.Controller;

namespace XareuWFClient.Model.Session
{
    public class Session
    {
        public bool Logged { get; set; }
        public User.User User { get; set; }
        public Guid CurrentToken { get; set; }
        public FormController FormController { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        /// <param name="tabs">The tabs.</param>
        public Session(Forms.Main main, Controls.Tabs.ButtonTabs tabs)
        {
            FormController = new FormController(main, tabs);
        }
    }
}
