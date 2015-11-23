namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Класс считывания файла Excel.
    /// </summary>
    class Input
    {
        /// <summary>
        /// Считанное расписание из Excel.
        /// </summary>
        public List<List<string>> Tab = new List<List<string>>();

        /// <summary>
        /// Метод считывания файла Excel в tab.
        /// </summary>
        /// <param name="f">Главная форма программы</param>
        public void Inp(Form1 f)
        {
            string str, filename = string.Empty;
            int rowCount;
            int collumnCount;

            this.Tab.Clear();

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
            {
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook book;
            Microsoft.Office.Interop.Excel.Worksheet sheet;
            Microsoft.Office.Interop.Excel.Range range;

            book = excelApp.Workbooks.Open(filename, 0, true, 5, string.Empty, string.Empty, true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets.get_Item(1);
            range = sheet.UsedRange;

            for (rowCount = 1; rowCount <= range.Rows.Count; rowCount++)
            {
                this.Tab.Add(new List<string>());
                for (collumnCount = 1; collumnCount <= range.Columns.Count; collumnCount++)
                {
                    str = (string)(range.Cells[rowCount, collumnCount] as Microsoft.Office.Interop.Excel.Range).Text;
                    this.Tab[rowCount - 1].Add(str.Trim());
                }
            }

            book.Close(true, null, null);
            excelApp.Quit();

            this.ReleaseObject(sheet);
            this.ReleaseObject(book);
            this.ReleaseObject(excelApp);

            int x = 0, y = 0;
            f.Tabl.RowCount = this.Tab.Count;
            foreach (List<string> i in this.Tab)
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

        /// <summary>
        /// Метод обработки исключений и очистки мусора.
        /// </summary>
        /// <param name="obj">Получаемый объект</param>
        private void ReleaseObject(object obj)
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
