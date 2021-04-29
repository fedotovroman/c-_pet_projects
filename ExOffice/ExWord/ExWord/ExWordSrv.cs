using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExWord
{
    public class WordSrv
    {
        // create MS-Word application 
        Microsoft.Office.Interop.Word.Application msWord = new Microsoft.Office.Interop.Word.Application();
        // create Word document reference
        public Microsoft.Office.Interop.Word.Document doc;
        // Create misssing value object
        object objMiss = System.Reflection.Missing.Value;
        // Create end of document object
        object endofdoc = "\\endofdoc";
        ///This method creates ms-word document and adding some paragraph, table and much more.
        public void CreateMsWord()
        {
            try
            {
                // show ms-word application
                msWord.Visible = true;
                // add blank documnet in word application
                doc = msWord.Documents.Add(ref objMiss, ref objMiss, ref objMiss, ref objMiss);
                // create first para
                FirstPara();
                // create Second para
                SecondPara();
                // create table
                CreateTable(3, 3);

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void FirstPara()
        {
            // create first paragraph with reference name
            Microsoft.Office.Interop.Word.Paragraph para1;
            // add paragraph with document
            para1 = doc.Content.Paragraphs.Add(ref objMiss);
            // create object of heading style
            object styleHeading1 = "Заголовок 1";
            // add heading style with paragraph
            para1.Range.set_Style(ref styleHeading1);
            // Write text of paragraph
            para1.Range.Text = "Текст параграфа 1";
            //set font style of paragraph
            para1.Range.Font.Bold = 1;
            // set space after write format of paragraph
            para1.Format.SpaceAfter = 24;
            // selection range of after insert paragraph
            para1.Range.InsertParagraphAfter();
        }
         /// This Method Create Second Paragraph
        public void SecondPara()
        {
            // create second paragaraph  with paragraph reference name para2
            Microsoft.Office.Interop.Word.Paragraph para2;

            // add second paragraph with documnet
            para2 = doc.Content.Paragraphs.Add(ref objMiss);
            // set paragraph heading style
            object styleHeading2 = "Заголовок 2";
            // add heading style with paragraph
            para2.Range.set_Style(ref styleHeading2);
            // second paragraph text 
            para2.Range.Text = "Текст параграфа 2";
            // set second paragraph font style
            para2.Range.Font.Bold = 1;
            para2.Range.Font.Italic = 1; //Selection.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdRed
            para2.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
           // space or font size style like 24pt, 25pt etc.
            para2.Format.SpaceAfter = 24;
            // set selection range of paragraph
            para2.Range.InsertParagraphAfter();
        }
        /// This Method create table in ms-word document
        public void CreateTable(int Row, int column)
        {

            // create table in word documnet in word application with table reference name tbl1
            Microsoft.Office.Interop.Word.Table tbl1;
            // calculate the range of endofdocu
            Microsoft.Office.Interop.Word.Range wordRange = doc.Bookmarks.get_Item(ref endofdoc).Range;
            // add table with document with number of row and column
            tbl1 = doc.Content.Tables.Add(wordRange, 3, 3, ref objMiss, ref objMiss);
            // set border visibility true by input 1 and false by input 0
            tbl1.Borders.Enable = 1;
            // set text in each cell of table
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    tbl1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGreen;
                    tbl1.Cell(r, c).Range.Text = "r" + r + "c" + c;
                }
            }
        }
    }

}
