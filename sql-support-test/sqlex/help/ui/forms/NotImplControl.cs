using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_support_test.sqlex.help.ui.forms
{
    public partial class NotImplControl : UserControl
    {
        public NotImplControl()
        {
            InitializeComponent();
        }

        private void BGoAWay_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new NotImplControl());
        }

        private void BHello_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new HelloControl());
        }
    }
}
