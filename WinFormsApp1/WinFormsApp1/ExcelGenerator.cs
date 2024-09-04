using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models;

namespace WinFormsApp1
{
     class ExcelGenerator
    {
        private static Dictionary<string, string> GetExcelHeader()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                {
                    "A1",
                    "StudentId"
                },
                {
                    "B1",
                    "First Name"
                },
                {
                    "C1",
                    "LastName"
                },
                {
                    "D1",
                    "Address"
                }
            };

            return headers;
        }
        internal static IXLWorksheet GenerateExcelHeader(IXLWorksheet xLWorksheet) 
        {
                Dictionary<string,string> excelHeaders = GetExcelHeader();
            foreach(KeyValuePair<string,string> dec in excelHeaders)
            {
                xLWorksheet.Cell(dec.Key).Value = dec.Value;
            }
            return xLWorksheet;
        }
        internal static IXLWorksheet GenerateExcelBody(IXLWorksheet xLWorksheet,List<Student> students) 
        {
            int i = 2;
            foreach (Student student in students) 
            { 
                    xLWorksheet.Cell($"A{i}").Value = student.Id;
                    xLWorksheet.Cell($"B{i}").Value = student.FirstName;
                    xLWorksheet.Cell($"C{i}").Value = student.LastName;
                    xLWorksheet.Cell($"D{i}").Value = student.Address;
                i++;
            }
            return xLWorksheet;
        }
    }
}
