using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace MapConverter
{
    public class MapPalette
    {
        // fields

        public List<Color> colors;
        public List<string> names;
        private List<OKLab> labColors;

        // constructor

        /// <summary>
        /// creates a new MapPalette
        /// </summary>
        /// <param name="colors">colors in the palette</param>
        public MapPalette(List<Color> colors, List<string> names)
        {
            this.colors = colors;
            this.names = names;

            labColors = new List<OKLab>(colors.Count);
            foreach (Color c in this.colors)
            {
                labColors.Add(OKLab.FromRGB(c));
            }
        }

        // methods

        /// <summary>
        /// gets the distance between two colors
        /// </summary>
        /// <param name="c1">first color</param>
        /// <param name="c2">second color</param>
        /// <returns>distance between c1 and c2 in RGB color space</returns>
        private float GetSquaredRGBDistance(Color c1, Color c2)
        {
            return MathF.Pow(c2.R - c1.R, 2)
                + MathF.Pow(c2.G - c1.G, 2)
                + MathF.Pow(c2.B - c1.B, 2);
        }

        /// <summary>
        /// Converts an image to this palette
        /// </summary>
        /// <param name="img">Image to convert</param>
        /// <param name="usingColors">Colors in this palette to use</param>
        /// <returns>converted image</returns>
        public Bitmap ConvertRGB(Bitmap bmp, List<bool> usingColors)
        {
            if(usingColors.Count != colors.Count)
            {
                throw new Exception("Count of usingColors must match palette size");
            }

            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    float closestDist = float.MaxValue;
                    Color closestColor = pixel;

                    for (int i = 0; i < colors.Count; i++)
                    {
                        if (usingColors[i])
                        {
                            float currDist = GetSquaredRGBDistance(colors[i], pixel);
                            if (currDist < closestDist)
                            {
                                closestColor = colors[i];
                                closestDist = currDist;
                            }
                        }
                    }

                    newBmp.SetPixel(x, y, closestColor);
                }
            }
            return newBmp;
        }

        /// <summary>
        /// converts the image to this palette using OKLab UNFINISHED
        /// </summary>
        /// <param name="bmp">image to convert</param>
        /// <param name="usingColors">colors in use</param>
        /// <returns>converted image</returns>
        public Bitmap ConvertOKLab(Bitmap bmp, List<bool> usingColors)
        {
            if (usingColors.Count != colors.Count)
            {
                throw new Exception("Count of usingColors must match palette size");
            }

            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    float closestDist = float.MaxValue;
                    Color closestColor = pixel;

                    for (int i = 0; i < colors.Count; i++)
                    {
                        if (usingColors[i])
                        {
                            float currDist = labColors[i].SquaredDistanceTo(pixel);
                            if (currDist < closestDist)
                            {
                                closestColor = colors[i];
                                closestDist = currDist;
                            }
                        }
                    }

                    newBmp.SetPixel(x, y, closestColor);
                }
            }
            return newBmp;
        }

        /// <summary>
        /// creates color panel buttons from color names
        /// </summary>
        /// <returns>list of color panel buttons</returns>
        public List<Control> GetUsingButtons()
        {
            List<Control> usingButtons = new List<Control>();
            for(int i = 0; i < names.Count; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Location = new Point(3, 25 * i + 3);
                cb.Size = new Size(175, 19);
                cb.Text = names[i];
                cb.Checked = true;

                usingButtons.Add(cb);
            }
            return usingButtons;
        }
    }
}
