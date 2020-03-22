using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Controls.Util
{
    public partial class VoteBox : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteBox"/> class.
        /// </summary>
        public VoteBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the karma.
        /// </summary>
        /// <value>The karma.</value>
        public float Karma {set { this.lKarma.Text = value.ToString(); } }
        /// <summary>
        /// Sets the positive votes.
        /// </summary>
        /// <value>The positive votes.</value>
        public int PositiveVotes { set { this.lPositives.Text = value.ToString(); } }
        /// <summary>
        /// Sets the negative votes.
        /// </summary>
        /// <value>The negative votes.</value>
        public int NegativeVotes { set { this.lNegatives.Text = value.ToString(); } }

        /// <summary>
        /// Handles the Click event of the pBVotePositive control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void pBVotePositive_Click(object sender, EventArgs e)
        {

        }


    }
}
