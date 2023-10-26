using DMZ.BL.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DMZ.UI.Classes
{
    public class Footer : PdfPageEventHelper

    {

        public override void OnEndPage(PdfWriter writer, Document doc)
        {
            //Adding a line  
            var p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));  
            doc.Add(p);
            var footer= new Paragraph($"Documento Processado pelo Computador: {Pbl.Info}", FontFactory.GetFont(FontFactory.HELVETICA, 7, Font.NORMAL));
            footer.Alignment = Element.ALIGN_RIGHT;
            var footerTbl = new PdfPTable(1) {TotalWidth = 800, HorizontalAlignment = Element.ALIGN_CENTER};
            var cellp = new PdfPCell(p) {Border = 0, PaddingLeft = 0};
            footerTbl.AddCell(cellp);
            var cell = new PdfPCell(footer) {Border = 0, PaddingLeft = 0};
            footerTbl.AddCell(cell);
            footerTbl.WriteSelectedRows(0, -1, 415, 30, writer.DirectContent);

        }

    }
}
