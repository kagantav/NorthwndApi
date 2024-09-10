using BaseLib.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWS.Model.Entities
{
    public class Category:BaseEntity<int>
    {
        public Category()
        {
            Products = new HashSet<Product>(); 
        }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }

        [NotMapped]
        public string Base64Picture
        {
            get
            {
                if ((int)Id <= 8)
                {
                    var base64Str = string.Empty;

                    using (var ms = new MemoryStream())
                    {
                        int offset = 78;
                        ms.Write(Picture, offset, Picture.Length - offset);
                        var bmp = new System.Drawing.Bitmap(ms);
                        using (var jpegms = new MemoryStream())
                        {
                            bmp.Save(jpegms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            base64Str = Convert.ToBase64String(jpegms.ToArray());
                        }
                    }

                    return base64Str;
                }

                return Convert.ToBase64String(Picture);

            }
        }

        public ICollection<Product>? Products { get; set; }
    }
}
