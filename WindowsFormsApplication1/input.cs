using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class input
    {
        public List<List<string>> tab = new List<List<string>>();

        public void inp(Form1 f)
        {
            string str, filename="";
            int rCnt;
            int cCnt;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel (*.XLS;*.XLSX)|*.XLS;*.XLSX";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                filename = openFileDialog1.FileName;
                sr.Close();
                f.Toggle();
            }
            else
                return;
           // System.Data.DataTable tb = new System.Data.DataTable();
           // string filename = openFileDialog1.FileName;

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook Book;
            Microsoft.Office.Interop.Excel.Worksheet Sheet;
            Microsoft.Office.Interop.Excel.Range Range;

            Book = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Sheet = (Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(1);
            Range = Sheet.UsedRange;

            for (rCnt = 1; rCnt <= Range.Rows.Count; rCnt++)
            {
                tab.Add(new List<string>());
                //f.Tabl.Rows.Add(1);
                for (cCnt = 1; cCnt <= Range.Columns.Count; cCnt++)
                {
                    str = (string)(Range.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                    //f.Tabl.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                    tab[rCnt-1].Add(str.Trim());
                }
            }
            Book.Close(true, null, null);
            ExcelApp.Quit();

            releaseObject(Sheet);
            releaseObject(Book);
            releaseObject(ExcelApp);

            int x = 0, y = 0;
            f.Tabl.RowCount = tab.Count;
            foreach (List<string> i in tab)
            {
                f.Tabl.ColumnCount = i.Count;
                foreach (string u in i)
                {
                    f.Tabl.Rows[x].Cells[y].Value = u;
                    y++;
                }
                y = 0;
                x++;
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
