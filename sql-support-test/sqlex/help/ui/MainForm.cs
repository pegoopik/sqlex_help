using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_support_test.sqlex.help.ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UiUtils.processAccessForChildControlls(this.pLeft, 2);
            Console.WriteLine("b5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UiUtils.processAccessForChildControlls(this.pLeft, 1);
            Console.WriteLine("b6");
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
