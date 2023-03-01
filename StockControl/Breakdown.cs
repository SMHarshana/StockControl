using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class Breakdown : Form
    {
        public Breakdown()
        {
            InitializeComponent();
        }

        private void btn_addbreakdown_Click(object sender, EventArgs e)
        {
            AddBreakdown addBreakdown = new AddBreakdown();
            addBreakdown.Visible = true;
        }
    }
}
