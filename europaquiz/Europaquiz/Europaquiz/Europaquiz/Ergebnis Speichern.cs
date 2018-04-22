﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Svg;

namespace Europaquiz
{
    public partial class Ergebnis_Speichern : Form
    {
        private static Document pdfdoc;
        string pfad;
        string Nachname;
        string Vorname;

        public Ergebnis_Speichern()
        {
            InitializeComponent();

        }

        public partial class Footer : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document doc)
            {

                Paragraph footer = new Paragraph("Ausgestellt von AKBK inc.", FontFactory.GetFont(FontFactory.TIMES, 10, iTextSharp.text.Font.NORMAL));
                footer.Alignment = Element.ALIGN_RIGHT;
                PdfPTable footerTbl = new PdfPTable(1);
                footerTbl.TotalWidth = 300;
                footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
                PdfPCell cell = new PdfPCell(footer);
                cell.Border = 0;
                cell.PaddingLeft = 10;
                footerTbl.AddCell(cell);
                footerTbl.WriteSelectedRows(0, -1, 415, 30, writer.DirectContent);
            }
        }

        private static void CreatePDF(string Name, string Vorname)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Chunk\{0}.pdf", Guid.NewGuid()));

            PdfWriter writer = PdfWriter.GetInstance(pdfdoc, new FileStream(@"C:\Users\FELiX\Desktop\test2.pdf", FileMode.Create));
            writer.PageEvent = new Footer();
            pdfdoc.Open();

            Paragraph Kopfzeile = new Paragraph($"Horrem, den { DateTime.Now.ToShortDateString()}");
            Kopfzeile.Alignment = Element.ALIGN_RIGHT;
            pdfdoc.Add(Kopfzeile);

            PdfContentByte pdfcontent = writer.DirectContent;
            
            iTextSharp.text.Font big = FontFactory.GetFont("Arial", 18);
            iTextSharp.text.Font standard = FontFactory.GetFont("Arial", 14);
            iTextSharp.text.Font standardbold = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font Titleunderline = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.UNDERLINE);
            
            pdfdoc.Add(new Paragraph(""));
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\Logo.jpeg");
            logo.ScalePercent(7);
            logo.SetAbsolutePosition(0, 765);

            pdfdoc.Add(logo);

            Paragraph headline = CreateParagraph("URKUNDE", Titleunderline);
            headline.Alignment = Element.ALIGN_CENTER;
            pdfdoc.Add(headline);

            pdfdoc.Add(AddEmptyParagraph(10));
            pdfdoc.Add(CreateParagraph("für die Teilanhme am Europa - Quiz des", big));
            pdfdoc.Add(CreateParagraph("des Adolfkolping-Berufskoleg", big));

            
            pdfdoc.Add(AddEmptyParagraph(30));
            pdfdoc.Add(CreateParagraph($"Ausgestellt für:{Vorname}{Name} ", standard));
            pdfdoc.Add(CreateParagraph($"Das Quiz wurde am {DateTime.Now.ToLongDateString()} absolviert.", standard));
            pdfdoc.Add(AddEmptyParagraph(10));
            pdfdoc.Add(CreateParagraph($"{""} hat Punkte {""} erieicht.", standard));

            pdfdoc.Add(AddEmptyParagraph(20));
           
            pdfdoc.Add(new Paragraph("Ihr Ergebnis als Bild:", standardbold));

            //read svg document from file system
            var svgDocument = SvgDocument.Open(Application.StartupPath + @"\Europa.svg");
            var bitmap = svgDocument.Draw();
            
            bitmap.Save(Application.StartupPath + @"\Europa.png", ImageFormat.Png);
            iTextSharp.text.Image Karte = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\Europa.png");
            Karte.ScaleToFit(pdfdoc.PageSize);
            Karte.SetAbsolutePosition(0, 90);
            pdfdoc.Add(Karte);
            pdfdoc.Add(AddEmptyParagraph(20));
            

            pdfdoc.Close();
        }
        public static Paragraph CreateParagraph(string text, iTextSharp.text.Font font)
        {

            return new iTextSharp.text.Paragraph(new iTextSharp.text.Chunk(text, font));
        }

        public static Paragraph AddEmptyParagraph(int höhe)
        {

            iTextSharp.text.Font standard = FontFactory.GetFont("Tahoma", höhe);
            return CreateParagraph(Environment.NewLine, standard);

        }

        private void erstellen_Click(object sender, EventArgs e)
        {
            pdfdoc = new Document(iTextSharp.text.PageSize.A4);
            pdfdoc.SetMargins(50, 50, 50, 50);
            Name = NameTB.Text;
            Vorname = VornameTB.Text;
            CreatePDF(Name,Vorname);
            Application.Restart();

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (this.Text != "" && VornameTB.Text != "")
            {
                erstellen.Show();
            }
            else
            {
                erstellen.Hide();
            }
        }

        private void VornameTB_TextChanged(object sender, EventArgs e)
        {
            if(this.Text!=""&& NameTB.Text!="")
            {
                erstellen.Show();
            }
            else
            {
                erstellen.Hide();
            }
        }
    }
}