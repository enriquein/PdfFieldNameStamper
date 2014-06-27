﻿using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PdfFieldNameStamper
{
    public class Stamper
    {
        private readonly string _path;

        public Stamper(string path)
        {
            _path = path;
        }

        public void StampFields(string output)
        {
            using (var reader = new PdfReader(_path))
            {
                if (!reader.IsOpenedWithFullPermissions)
                    return;

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

        public class FieldOrder
        {
            public float Page { get; set; }
            public float VerticalPosition { get; set; }
            public string FieldName { get; set; }

            public override string ToString()
            {
                return string.Format("Field: {0} | Page: {1} | Position: {2}", FieldName, Page, VerticalPosition);
            }
        }
    }
}
