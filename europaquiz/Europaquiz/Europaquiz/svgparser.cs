using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Europaquiz
{
    /// <summary>
    /// Class containg code for manipulating SVG graphics.
    /// </summary>
    public class SVGParser
    {
        /// <summary>
        /// The maximum image size supported.
        /// </summary>
        public static Size MaximumSize { get; set; }

        /// <summary>
        /// Converts an SVG file to a Bitmap image.
        /// </summary>
        /// <param name="@"D:\Europa09.04\EUROPAQuiz\europaquiz\Europaquiz\Europa.svg"">The full path of the SVG image.</param>
        /// <returns>Returns the converted Bitmap image.</returns>
        public static Bitmap GetBitmapFromSVG(string file)
        {
            SvgDocument document = GetSvgDocument(file);

            Bitmap bmp = document.Draw();
            return bmp;
        }


        /// <summary>
        /// Gets a SvgDocument for manipulation using the path provided.
        /// </summary>
        /// <param name="@"D:\Europa09.04\EUROPAQuiz\europaquiz\Europaquiz\Europa.svg"">The path of the Bitmap image.</param>
        /// <returns>Returns the SVG Document.</returns>
        public static SvgDocument GetSvgDocument(string file)
        {
            SvgDocument document = SvgDocument.Open(file);
            return AdjustSize(document);
        }

        /// <summary>
        /// Makes sure that the image does not exceed the maximum size, while preserving aspect ratio.
        /// </summary>
        /// <param name="document">The SVG document to resize.</param>
        /// <returns>Returns a resized or the original document depending on the document.</returns>
        private static SvgDocument AdjustSize(SvgDocument document)
        {
            if (document.Height > MaximumSize.Height)
            {
                document.Width = (int)((document.Width / (double)document.Height) * MaximumSize.Height);
                document.Height = MaximumSize.Height;
            }
            return document;
        }

    }

}