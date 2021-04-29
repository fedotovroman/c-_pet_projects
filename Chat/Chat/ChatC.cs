using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Chat
{
    class ChatC
    {
        byte[] bSem = new byte[1];
        
        public void Load(RichTextBox _rtbChat, Timer _tmrSem)
        {
            FileStream fSemR = File.OpenRead("Semaphore.txt");
            fSemR.Read(bSem, 0, 1);
            if (bSem[0] == Convert.ToByte('0'))
            {
                _tmrSem.Enabled = true;
                fSemR.Close();
            }
            else
            {
                fSemR.Close();
                bSem[0] = Convert.ToByte('0');
                FileStream fSemW = File.OpenWrite("Semaphore.txt");
                fSemW.Write(bSem, 0, 1);
                fSemW.Close();
                _rtbChat.LoadFile("Grasshopper.rtf");
                _tmrSem.Enabled = false;
            }           
        }
        public void Save(RichTextBox _rtbChat)
        {
            _rtbChat.SaveFile("Grasshopper.rtf");
            bSem[0] = Convert.ToByte('1');
            FileStream fSemW = File.OpenWrite("Semaphore.txt");
            fSemW.Write(bSem, 0, 1);
            fSemW.Close();
        }
    }
}
