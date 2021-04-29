using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO; 
using System.Drawing;


namespace BankDate
{
    class DocCreator
    {
        public void CreateDoc(string path, string fullname, string moneydep, string id, string proc, string datelong,string currdate)
        {
            object filename = @"E:\Users\Alex\Desktop\1.doc";
            object tempname = @"TEMPLATE.doc";
            File.Copy((string)tempname, (string)filename, true);
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(filename, ReadOnly: false, Visible: true);
            FindAndReplace(wordApp, "{id}", "12345");
            aDoc.Activate();
            
        }

        public void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1; 
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);

            



        }


    }
}
