﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utilities
{
    public class ImageManagement
    {
        public static byte[] ImageToByte(string url)
        {
            Image img = Image.FromFile(url);
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static byte[] ImageToByte(Image image)
        {
            Bitmap bitmap = (Bitmap)image;
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ByteToImage(byte[] image)
        {
            using (var ms = new MemoryStream(image, false))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
