using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivio_CRE
{
    public static class DocxManager
    { 
        public static bool WriteDocx(Attività esporta, string filepath)
        {
            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainDocumentPart = doc.AddMainDocumentPart();
                    mainDocumentPart.Document = new Document();

                    Body body = mainDocumentPart.Document.AppendChild(new Body());

                    body.AppendChild(CreateParagraph(esporta.Nome.ToUpper(), 30, true));
                    body.AppendChild(CreateParagraph("", 4));
                    body.AppendChild(CreateParagraph($"CODICE: {esporta.Code}"));
                    body.AppendChild(CreateParagraph($"NOME: {esporta.Nome}"));
                    body.AppendChild(CreateParagraph("", 4));
                    body.AppendChild(CreateParagraph($"LUOGO: {esporta.Luogo}"));
                    body.AppendChild(CreateParagraph($"TIPO: {esporta.Tipo}"));
                    body.AppendChild(CreateParagraph("", 4));
                    body.AppendChild(CreateParagraph($"CLASSI:"));

                    NumberingDefinitionsPart numberingPart =
                    mainDocumentPart.AddNewPart<NumberingDefinitionsPart>("someUniqueIdHere");

                    Numbering element =
                      new Numbering(
                        new AbstractNum(
                          new Level(
                            new NumberingFormat() { Val = NumberFormatValues.Bullet },
                            new LevelText() { Val = "·" }
                          )
                          { LevelIndex = 0 }
                        )
                        { AbstractNumberId = 1 },
                        new NumberingInstance(
                          new AbstractNumId() { Val = 1 }
                        )
                        { NumberID = 1 });

                    foreach (var c in esporta.Età)
                    {
                        RunProperties rp = new RunProperties();
                        FontSize ft = rp.AppendChild(new FontSize());
                        ft.Val = "28";
                        body.AppendChild(new Paragraph(new ParagraphProperties(new NumberingProperties(
                                                       new NumberingLevelReference() { Val = 0 },
                                                       new NumberingId() { Val = 1 })),
                                                       new Run(rp,
                                                       new Text(c) { Space = SpaceProcessingModeValues.Preserve })));
                    }
                    body.AppendChild(CreateParagraph("", 4));

                    body.AppendChild(CreateParagraph($"MATERIALI:"));
                    foreach (var c in esporta.Materiale)
                    {
                        RunProperties rp = new RunProperties();
                        FontSize ft = rp.AppendChild(new FontSize());
                        ft.Val = "28";
                        body.AppendChild(new Paragraph(new ParagraphProperties(new NumberingProperties(
                                                       new NumberingLevelReference() { Val = 0 },
                                                       new NumberingId() { Val = 2 })),
                                                       new Run(rp,
                                                       new Text(c.Item2 + new string(' ', 60 - c.Item2.Length * 2 - c.Item1.ToString().Length) + "\t" + c.Item1) { Space = SpaceProcessingModeValues.Preserve })));
                    }
                    body.AppendChild(CreateParagraph("", 4));

                    body.AppendChild(CreateParagraph($"DESCRIZIONE:"));
                    body.AppendChild(CreateParagraph(esporta.Descrizione));

                    element.Save(numberingPart);
                    mainDocumentPart.Document.Save();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static Paragraph CreateParagraph(string text, int size = 14, bool bold = false)
        {
            Paragraph para = new Paragraph();

            Run run = para.AppendChild(new Run());


            RunProperties runProperties = run.AppendChild(new RunProperties());
            FontSize fontSize = new FontSize();
            fontSize.Val = (size * 2).ToString();
            runProperties.AppendChild(fontSize);
            if (bold)
                runProperties.AppendChild(new Bold());

            //ParagraphProperties paraProperties = para.AppendChild(new ParagraphProperties());

            run.AppendChild(new Text(text));

            return para;
        }

    }

}
