using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CriminalSearchService.Reporting
{
   public class ReportingEngine
    {
        public List<string> CreateReports(List<BusinessObjects.Criminal> criminals)
       {
            List<string> reports=new List<string>();
           foreach (var criminal in criminals)
           {
                reports.Add(GeneratePdf(criminal));
           }
            return reports;
       }

       private string GeneratePdf(BusinessObjects.Criminal criminal)
       {
            var directoryPath = CreateDirectory();

            var document = new Document(PageSize.LETTER, 10, 10, 42, 35);
            string path = directoryPath + "/" + criminal.FirstName+"_"+criminal.LastName+"_"+DateTime.Now.Ticks + ".pdf";
            var fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(document, fs);

            var pdfTable = new PdfPTable(2);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.DefaultCell.FixedHeight = 25f;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            var cell = CreatePdfTableCell("First Name:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.FirstName, true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Last Name:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.LastName, true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Age:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.Age + " years", true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Sex:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.Sex.ToString(), true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Weight:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.Weight + " kgs", true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Height:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.Height + " feet", true, 12);
            pdfTable.AddCell(cell);

            cell = CreatePdfTableCell("Nationality:", true, 12);
            pdfTable.AddCell(cell);
            cell = CreatePdfTableCell(criminal.Nationality.ToUpper(CultureInfo.InvariantCulture),
                true,
                12);
            pdfTable.AddCell(cell);

            document.Open();
            document.Add(pdfTable);
            document.Close();
           return path;
       }
        private PdfPCell CreatePdfTableCell(string value, bool isBold, int fontSize)
        {
            var bf = BaseFont.CreateFont(isBold ? BaseFont.HELVETICA_BOLD : BaseFont.HELVETICA, BaseFont.CP1252, false);

            var fontH1 = new Font(bf, fontSize);
            fontH1.SetColor(0, 0, 0);
            var cell = new PdfPCell(new Phrase(value, fontH1))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                BorderColor = new BaseColor(0, 0, 0),
                BorderWidth = 2f,
                FixedHeight = 35f
            };
            return cell;
        }
        private string CreateDirectory()
        {
                var path = HostingEnvironment.MapPath("~/Reports");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
        }
    }
}
