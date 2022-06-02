using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.Menagers
{
    public static class MessageManager
    {
        public static void ValidationMessage(string message)
        {
            XtraMessageBox.Show(message, "Lista zadań", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void InfoMessage(string message)
        {
            XtraMessageBox.Show(message, "Lista zadań", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult QuestionMessage(string message)
        {
            return XtraMessageBox.Show(message, "Lista zadań", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

       
    }
}
