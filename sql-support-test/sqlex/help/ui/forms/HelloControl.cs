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
    public partial class HelloControl : UserControl
    {
        public HelloControl()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new LoginControl());
        }

        private void BGoAWay_Click(object sender, EventArgs e)
        {
            Program.changeCurrentControl(new NotImplControl());
        }

        private void HelloControl_Load(object sender, EventArgs e)
        {
            //TODO при необходимости загрузить объекты
            //TODO отобразить статистику объектов на компоненте
        }
    }
}
