using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelUtilities
{
    class ExcelLibrary
    {
        private static DataTable ExcelToDataTable(string strFileName, string strSheetName)
        {
            //Open excel file and return a stream
            FileStream stream = File.Open(strFileName, FileMode.Open, FileAccess.Read);
            //Create oepnxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //Set the first row as column name
            //excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            //Get All the tables 
            DataTableCollection tables = result.Tables;
            //store it in Datatable
            DataTable resultTable = tables[strSheetName];

            //return Table
            stream.Close();
            return resultTable;
           
        }

        //Poppulating Data into collections
        static List<DataCollection> dataCol = new List<DataCollection>();
        public static void PopulateCollection (string strFileName, string strSheetName)
        {
            DataTable table = ExcelToDataTable(strFileName, strSheetName);
            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col<=(table.Columns.Count)-1; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row-1][col].ToString()
                    };
                    //Add all details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        //Poppulating Data into collections
        static List<DataCollection> dataColtrial = new List<DataCollection>();
        public static void PopulateCollectionTrial(string strFileName, string strSheetName)
        {
            DataTable table = ExcelToDataTable(strFileName, strSheetName);
            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col <= (table.Columns.Count) - 1; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        RowNumber = row,
                        RowName = table.Rows[row - 1][3].ToString(),
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all details for each row
                    dataColtrial.Add(dtTable);
                }
            }
        }

        //Poppulating Data into collections
        //Created by Majeeth for testing purpose
        static List<DataCollection> dataCollection = new List<DataCollection>();
        public static void PopulateCollectionByRow(string strFileName, string strSheetName)
        {
            DataTable table = ExcelToDataTable(strFileName, strSheetName);
            //Iterate through the rows and columns of the table

            for (int col = 0; col <= (table.Columns.Count)-2; col++)
            {
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString(),
                        RowName = table.Rows[row - 1][0].ToString(),
                        RowValue = table.Rows[row - 1][col+1].ToString()
                    };
                    //Add all details for each row
                    dataCollection.Add(dtTable);
                }
            }
        }
        public static string ReadData(int rowNumber, string colName)
        {
            try
            {
                string data = (from colData in dataCol
                               where colData.ColName == colName && colData.RowNumber == rowNumber
                               select colData.ColValue).SingleOrDefault();
                //return data
                return data.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();           
            }
        }

        public static string ReadDataTest(string RowName, string colName)
        {
            try
            {
                string data = (from colData in dataColtrial
                               where colData.RowName == RowName && colData.ColName == colName
                               select colData.ColValue).SingleOrDefault();
                //return data
                return data.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        //To Read data from the dataset.
        public static string ReadDatabyRow(string RowName)
        {
            try
            {
                string data = (from colData in dataCollection
                               where colData.RowName == RowName
                               select colData.RowValue).SingleOrDefault();
                //return data
                return data.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
    public class DataCollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
        public string RowName { get; set; }
        public string RowValue { get; set; }
    }
}
