﻿using ExcelDataReader;
using System.Data;
using System.Diagnostics;


namespace TestSuite.Utilities
{
    public class ExcelHelper
    {
        // How to use this method:
        // Let's assume we have an excel file named Data.xlsx
        // and it has a sheet named "SignIn"
        // and value of row 1 in column A is "Username"
        // and value of row 2 in column A is "anthony".
        // Row 1 serves as the column label and anything under it are its associated values.
        // To access row 2 in column A, use this syntax:
        // ExcelHelper.PopulateInCollection(EnvironmentHelper.excelDataPath, "SignIn");
        // ExcelHelper.ReadData(2,"Username");


        private static readonly List<Datacollection> DataCol = new List<Datacollection>();


        // The following code helps to quit the windows in which you only need to pass the name of excel.
        private static void QuitExcel(string processtitle)
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
                if (process.MainWindowTitle == "Microsoft Excel - " + processtitle + " - Excel")
                    process.Kill();
        }


        private static void ClearData()
        {
            DataCol.Clear();
        }


        private static DataTable ExcelToDataTable(string fileName, string sheetName)
        {
            //Register encoding provider to avoid "No data is available for encoding 1252" error
            //"System.Text.Encoding.CodePages" nuget package needs to be installed for this to work
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Open file and return as Stream
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //Get all the tables
                    var table = result.Tables;
                    // store it in data table
                    var resultTable = table[sheetName];
                    return resultTable;
                }
            }
        }


        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations

                rowNumber = rowNumber - 1;
                var data = (from colData in DataCol
                            where (colData.ColName == columnName) && (colData.RowNumber == rowNumber)
                            select colData.ColValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data;
            }
            catch (Exception e)
            {
                // ReSharper disable once LocalizableElement
                Console.WriteLine("Exception occurred in ExcelLibHelper Class ReadData Method!" + Environment.NewLine +
                                  e.Message);
                return null;
            }
        }


        public static void PopulateInCollection(string fileName, string sheetName)
        {
            ClearData();
            var table = ExcelToDataTable(fileName, sheetName);

            //Iterate through the rows and columns of the Table
            for (var row = 1; row <= table.Rows.Count; row++)
                for (var col = 0; col < table.Columns.Count; col++)
                {
                    var dtTable = new Datacollection
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    DataCol.Add(dtTable);
                }
        }


        private class Datacollection
        {
            public int RowNumber { get; set; } 
            public string ColName { get; set; } = null!;
            public string ColValue { get; set; } = null!;
        }
    }
}