using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneRadomize
{
    class DialogState
    {
        public DialogResult result;
        public FileDialog dialog;

        public void ThreadProcShowDialog()
        {
            result = dialog.ShowDialog();
        }
    }
}
