using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sql_support_test.sqlex.help.ui;
using sql_support_test.sqlex.help.ui.forms;
namespace sql_support_test
{
    static class Program
    {
        private static UserControl currentUserControl;
        private static sqlex.help.ui.MainForm mainForm;
        private static int currentUserRights = 0;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            currentUserControl = new HelloControl();
            changeCurrentControl(currentUserControl);
            Application.Run(mainForm);
        }


        public static void changeCurrentControl(UserControl userControl)
        {
            if (mainForm.pBody.Controls.Contains(currentUserControl))
            {
                mainForm.pBody.Controls.Remove(currentUserControl);
            }
            //userControl.Anchor = AnchorStyles.None;
            userControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            userControl.Dock = DockStyle.Fill;
            currentUserControl = null;
            currentUserControl = userControl;
            mainForm.Text = "Sql-Ex Helper - " + userControl.AccessibleName;
            UiUtils.processAccessForChildControlls(userControl, currentUserRights);
            mainForm.pBody.Controls.Add(currentUserControl);
        }

    }
}
