using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323.Util
{
    class MessageBoxUtil
    {
        private static MessageBoxUtil inst;

        public MessageBoxUtil getInst()
        {
            if (inst == null)
            {
                inst = new MessageBoxUtil();
            }
            return inst;
        }

        public string myInputBox(string body, string title, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(body, title, prompt, -1, -1);
            return input;
        }

        public static DialogResult getDialogResult(string body, string title)
        {
            DialogResult dr = MessageBox.Show(body, title, MessageBoxButtons.YesNo);
            return dr;
        }
    }
}
