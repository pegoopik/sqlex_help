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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            //TODO организовать выход 
        }

        private void BGoAWay_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new NotImplControl());
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            //TODO организовать вход 
            Program.changeCurrentControl(new TicketListControl());
        }
    }
}
