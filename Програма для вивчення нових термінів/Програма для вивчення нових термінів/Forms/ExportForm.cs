using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class ExportForm : Form
    {
        private readonly StudySet _setForExport;

        public ExportForm(StudySet exportSet)
        {
            InitializeComponent();
            _setForExport = exportSet;
        }

        private void ExportToExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*",
                Title = "Save StudySet",
                DefaultExt = "xlsx",
                FileName = $"{_setForExport.Title}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add($"StudySet {_setForExport.Title}");
                        FillWorksheetWithStudySetData(worksheet);
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }
                    //MessageBox.Show($"StudySet '{_setForExport.Title}' successfully exported to Excel file.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppContext.ShowMessage($"StudySet '{_setForExport.Title}' successfully exported to Excel file.", "Export Successful", MessageType.Success);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error exporting StudySet to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AppContext.ShowMessage($"Error exporting StudySet to Excel: {ex.Message}", "Export Error", MessageType.Error);
                }
            }
        }
        private void FillWorksheetWithStudySetData(ExcelWorksheet worksheet) 
        { 
            _setForExport.WriteToExcel(worksheet);
        }

        //private void FillWorksheetWithStudySetData(ExcelWorksheet worksheet)
        //{
        //    worksheet.Cells["A1"].Value = "Title:";
        //    worksheet.Cells["B1"].Value = _setForExport.Title;
        //    worksheet.Cells["A2"].Value = "Description:";
        //    worksheet.Cells["B2"].Value = _setForExport.Description;
        //    worksheet.Cells["A3"].Value = "Creation Date:";
        //    worksheet.Cells["B3"].Value = _setForExport.CreationDate.ToString();

        //    if (_setForExport is LanguageStudySet languageSet)
        //    {
        //        worksheet.Cells["A4"].Value = "Language:";
        //        worksheet.Cells["B4"].Value = $"{languageSet.Language1} -> {languageSet.Language2}";
        //    }

        //    worksheet.Cells["A6"].Value = "Term";
        //    worksheet.Cells["B6"].Value = "Definition";

        //    int row = 7;
        //    foreach (Card card in _setForExport.Cards)
        //    {
        //        worksheet.Cells[row, 1].Value = card.Term;
        //        worksheet.Cells[row, 2].Value = card.Definition;
        //        row++;
        //    }
        //}

        private void ExportToTextFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save StudySet",
                DefaultExt = "txt",
                FileName = $"{_setForExport.Title}.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        WriteStudySetToTextWriter(writer);
                    }
                    //MessageBox.Show($"StudySet '{_setForExport.Title}' successfully exported to text file.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppContext.ShowMessage($"StudySet '{_setForExport.Title}' successfully exported to text file.", "Export Successful", MessageType.Success);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error exporting StudySet: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AppContext.ShowMessage($"Error exporting StudySet: {ex.Message}", "Export Error", MessageType.Error);
                }
            }
        }

        private void WriteStudySetToTextWriter(StreamWriter writer)
        {
            _setForExport.WriteToText(writer);
        }

        //private void WriteStudySetToTextWriter(StreamWriter writer)
        //{
        //    writer.WriteLine($"Title: {_setForExport.Title}");
        //    writer.WriteLine($"Description: {_setForExport.Description}");
        //    writer.WriteLine($"Creation Date: {_setForExport.CreationDate}");

        //    if (_setForExport is LanguageStudySet languageSet)
        //    {
        //        writer.WriteLine($"Language: {languageSet.Language1} -> {languageSet.Language2}");
        //    }

        //    int maxTermWidth = _setForExport.Cards.Max(card => card.Term.Length);
        //    int maxDefinitionWidth = _setForExport.Cards.Max(card => card.Definition.Length);

        //    writer.WriteLine("Term".PadRight(maxTermWidth) + "  " + "Definition".PadRight(maxDefinitionWidth));
        //    writer.WriteLine(new string('-', maxTermWidth + maxDefinitionWidth));

        //    foreach (Card card in _setForExport.Cards)
        //    {
        //        writer.WriteLine(card.Term.PadRight(maxTermWidth) + "  " + card.Definition.PadRight(maxDefinitionWidth));
        //    }
        //}

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (radioButtonExcel.Checked)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExportToExcel();
            }
            else
            {
                ExportToTextFile();
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
