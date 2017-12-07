using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_support_test.sqlex.help.ui
{
    class UiUtils
    {
        /**
         * tag == 0 выставляем доступ для пользователей
         * tag == 1 выставляем доступ для модераторов
         * tag == 2 выставляем доступ для админов
         * tag >= 3 для каких-нибудь супер прав, типа владельца сайта и пр.
         */
        public static void processAccessForChildControlls(Control owner, int tag)
        {
            Console.WriteLine(owner.Name);
            foreach (Control control in owner.Controls)
            {
                Console.WriteLine(control.Name);
                if (control.Tag == null)
                {
                    continue;
                }
                try
                {
                    Boolean access = false;
                    int controlTag = 0;// (int)control.Tag;
                    int.TryParse((String)control.Tag, out controlTag);
                    if (controlTag <= 0)
                    {
                        access = true;
                    }
                    else if (controlTag <= tag)
                    {
                        access = true;
                    }
                    control.Visible = access;
                    processAccessForChildControlls(control, tag);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }


    }

}
