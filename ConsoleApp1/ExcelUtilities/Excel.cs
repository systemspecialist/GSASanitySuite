using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;


namespace ExcelUtilities
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, string Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }

        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void Close()
        {
            wb.Close();
        }

        public string ReadDatabyColumnName(string project, string control)
        {
            if (project == "GACShip")
            {
                if (control == "GACShipURL")
                    return ws.Cells[2, 1].Value2;
                if (control == "UserName")
                    return ws.Cells[2, 2].Value2;
                if (control == "Password")
                    return ws.Cells[2, 3].Value2;
                if (control == "AcknowledgementRequiredJob")
                    return ws.Cells[2, 1].Value2;
                if (control == "PDAJob")
                    return ws.Cells[2, 2].Value2;
                if (control == "SOFJob")
                    return ws.Cells[2, 3].Value2;
                if (control == "FDAJob")
                    return ws.Cells[2, 4].Value2;
                if (control == "EndToEndJob")
                    return ws.Cells[2, 5].Value2;
                else
                    return "";
            }
            else
                return "";
        }
    }

}