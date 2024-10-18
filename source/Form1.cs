using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MapConverter
{
    public partial class Form1 : Form
    {
        // fields

        private MapPalette palette;

        Bitmap sourceBmp;
        Bitmap displayBmp;
        int scale;

        // constructor

        public Form1()
        {
            InitializeComponent();

            List<Color> colors = new List<Color>
            {
                Color.Red,
                Color.Orange,
                Color.Yellow,
                Color.Green,
                Color.Blue,
                Color.Purple
            };

            List<string> names = new List<string>
            {
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue",
                "Purple"
            };

            palette = new MapPalette(colors, names);
            AddUsingButtons();

            sourceBmp = new Bitmap(1, 1);
            displayBmp = sourceBmp;

            scale = 1;
        }

        // methods

        /// <summary>
        /// load image from computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // open dialog box
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.png;*.tif;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(dialog.FileName);
                    sourceBmp = new Bitmap(img);
                    displayBmp = sourceBmp;
                    UpdateMap();
                }
                catch
                {
                    MessageBox.Show("Problem loading image. Try a different file.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|gif files (*.gif)|*.gif";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;
                switch(dialog.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Png;
                        break;
                    case 2:
                        format = ImageFormat.Jpeg;
                        break;
                    case 3:
                        format = ImageFormat.Gif;
                        break;
                    default:
                        format = null;
                        break;
                }

                try
                {
                    displayBmp.Save(dialog.FileName, format);
                }
                catch
                {
                    MessageBox.Show("Problem saving image. Try a different filename.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// updates map tile
        /// </summary>
        private void UpdateMap()
        {
            pictureBoxMap.Width = displayBmp.Width * scale;
            pictureBoxMap.Height = displayBmp.Height * scale;
            Bitmap scaledBmp = SimpleScale(displayBmp, scale);
            pictureBoxMap.BackgroundImage = scaledBmp;
        }

        /// <summary>
        /// adds toggle buttons to color panel
        /// </summary>
        private void AddUsingButtons()
        {
            panelColors.Controls.Clear();

            List<Control> usingButtons = palette.GetUsingButtons();
            foreach(Control b in usingButtons)
            {
                panelColors.Controls.Add(b);
            }
        }

        private List<bool> GetUsingColors()
        {
            List<bool> usingColors = new List<bool>();

            for (int i = 0; i < panelColors.Controls.Count; i++)
            {
                CheckBox cb = (CheckBox)panelColors.Controls[i];
                usingColors.Add(cb.Checked);
            }

            return usingColors;
        }

        private void buttonConvertRGB_Click(object sender, EventArgs e)
        {
            List<bool> usingColors = GetUsingColors();
            displayBmp = palette.ConvertRGB(sourceBmp, usingColors);
            UpdateMap();
        }

        private void buttonConvertOKLab_Click(object sender, EventArgs e)
        {
            List<bool> usingColors = GetUsingColors();
            displayBmp = palette.ConvertOKLab(sourceBmp, usingColors);
            UpdateMap();
        }

        // below method from mpen at stack exchange
        // https://stackoverflow.com/a/24199315
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            scale = Math.Max(1, scale + 1);
            UpdateMap();
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            scale = Math.Max(1, scale - 1);
            UpdateMap();
        }

        private Bitmap SimpleScale(Bitmap bmp, int scale)
        {
            return new Bitmap(bmp, bmp.Width * scale, bmp.Height * scale);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormPalette fp = new FormPalette(palette);
            if(fp.ShowDialog() == DialogResult.OK)
            {
                palette = fp.GetMapPalette();
                AddUsingButtons();
            }
        }
    }
}
