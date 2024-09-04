using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using WinFormsApp1.Data;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var studentsData = StudentData.GetAllStudents();
                using (var workBook = new XLWorkbook())
                {
                    var workSheet = workBook.AddWorksheet("studentData");
                    workSheet = ExcelGenerator.GenerateExcelHeader(workSheet);
                    workSheet = ExcelGenerator.GenerateExcelBody(workSheet, studentsData);

                    // Use SaveFileDialog to let the user choose the save location
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Save an Excel File";
                        saveFileDialog.FileName = "StudentData.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Save the workbook to the selected file path
                            workBook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
