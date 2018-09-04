using Assertion;
using OpenQA.Selenium;
using ReportingUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTest
{
    class TableDataUtility
    {

        static List<TableDataCollection> _TableDataCollection = new List<TableDataCollection>();
        public static void PopulateCollectionByRow(IWebElement table)
        {
            //Iterate through the rows and columns of the table
            if (InitialAssertion.IfElementIsVisible(table) == true)
            {
                var columns = table.FindElements(By.TagName("th"));
                var rows = table.FindElements(By.TagName("tr"));
                int rowIndex = 0;
                foreach (var row in rows)
                {
                    int colIndex = 0;
                    var colData = row.FindElements(By.TagName("td"));
                    foreach (var colValue in colData)
                    {
                        _TableDataCollection.Add(new TableDataCollection
                        {
                            RowNumber = rowIndex,
                            ColName = columns[colIndex].Text,
                            ColValue = colValue.Text

                        });
                        colIndex++;

                    }
                    rowIndex++;
                }

            }
            else
            {
                SeleniumReporting.WriteResults(false, "Table is not available to fetch and compare the given search text");
            }


        }

        public static string ReadCellData(int rowNumber, string colName)
        {
            try
            {
                string data = (from colData in _TableDataCollection
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


        public class TableDataCollection
        {
            public int RowNumber { get; set; }
            public string ColName { get; set; }
            public string ColValue { get; set; }
            public string RowName { get; set; }
            public string RowValue { get; set; }
        }
    }
}
