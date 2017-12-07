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
    public partial class DefaultUserControl : UserControl
    {
        public DefaultUserControl()
        {
            InitializeComponent();
        }

        private void DefaultUserControl_Load(object sender, EventArgs e)
        {
        }

        private void BGoAWay_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new NotImplControl());
        }
    }
}
