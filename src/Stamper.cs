using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PdfFieldNameStamper
{
    public class Stamper
    {
        public void StampFields(string input, string output = null, string password = null)
        {
            PdfReader.unethicalreading = true;

            if (string.IsNullOrEmpty(output))
                output = GetAutomaticOutputFilePath(input);

            using (var reader = (password == null) ? new PdfReader(input) : new PdfReader(input, Encoding.Unicode.GetBytes(password)))
            {
                using (var newPdf = new FileStream(output, FileMode.OpenOrCreate))
                using (var stamper = new PdfStamper(reader, newPdf))
                {
                    var fields = stamper.AcroFields;
                    var fieldOutputList = new List<FieldOrder>();
                    IList<AcroFields.FieldPosition> fieldPosition;

                    foreach (var field in fields.Fields)
                    {
                        fields.SetField(field.Key, field.Key);
                        fieldPosition = fields.GetFieldPositions(field.Key);
                        if (fieldPosition != null && fieldPosition.Any())
                        {
                            fieldOutputList.Add(new FieldOrder { FieldName = field.Key, Page = fieldPosition.First().page, VerticalPosition = fieldPosition.First().position.Top });
                        }
                    }

                    stamper.FormFlattening = true;
                    fieldOutputList = fieldOutputList.OrderBy(order => order.Page).ThenByDescending(x => x.VerticalPosition).ToList();
                    File.WriteAllLines(output + ".fields.txt", fieldOutputList.Select(x => x.ToString()));
                }
            }
        }

        public string GetAutomaticOutputFilePath(string input)
        {
            return Path.GetDirectoryName(input) + @"\" + Path.GetFileNameWithoutExtension(input) + ".stamped" + Path.GetExtension(input);
        }

        private class FieldOrder
        {
            public float Page { get; set; }
            public float VerticalPosition { get; set; }
            public string FieldName { get; set; }

            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}", FieldName, Page, VerticalPosition);
            }
        }
    }
}
