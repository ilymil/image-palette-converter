using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapConverter
{
    public partial class FormPalette : Form
    {
        public FormPalette(MapPalette mp)
        {
            InitializeComponent();

            // initialize dialog components
            AcceptButton = buttonUse;
            CancelButton = buttonCancel;

            buttonUse.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            LoadFromPalette(mp);
        }

        /// <summary>
        /// removes color from palette
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int senderIndex = panelRemove.Controls.IndexOf((Control)sender);

            // remove color entry
            panelRemove.Controls.RemoveAt(senderIndex);
            panelNames.Controls.RemoveAt(senderIndex);
            panelColors.Controls.RemoveAt(senderIndex);

            // move controls up
            moveControlsUp(panelRemove, senderIndex, 23 + 6);
            moveControlsUp(panelNames, senderIndex, 23 + 6);
            moveControlsUp(panelColors, senderIndex, 23 + 6);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button cb = (Button)sender;
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog() == DialogResult.OK)
            {
                cb.BackColor = cd.Color;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // increase panel size
            panelRemove.Height += 23 + 6;
            panelNames.Height += 23 + 6;
            panelColors.Height += 23 + 6;

            int y = panelRemove.Controls.Count * (23 + 6);

            // add remove button
            Button rb = new Button();
            rb.Location = new Point(0, y);
            rb.Size = new Size(panelRemove.Width, 23);
            rb.Text = "-";
            rb.Click += buttonRemove_Click;
            panelRemove.Controls.Add(rb);

            // add name field
            TextBox nt = new TextBox();
            nt.Location = new Point(0, y);
            nt.Size = new Size(panelNames.Width, 23);
            nt.Text = "New Color";
            panelNames.Controls.Add(nt);

            // add color button
            Button cb = new Button();
            cb.Location = new Point(0, y);
            cb.Size = new Size(panelColors.Width, 23);
            cb.BackColor = Color.Black;
            cb.Click += buttonColor_Click;
            panelColors.Controls.Add(cb);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // get file path from user
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "palette files (*.plt)|*.plt";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                // create file
                Stream outStream = File.OpenWrite(sd.FileName);
                BinaryWriter output = new BinaryWriter(outStream);

                // write palette size
                output.Write(panelRemove.Controls.Count);

                // write colors
                foreach(Button cb in panelColors.Controls)
                {
                    output.Write(cb.BackColor.ToArgb());
                }

                // write names
                foreach(TextBox tb in panelNames.Controls)
                {
                    output.Write(tb.Text);
                }

                output.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // get file path from user
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "palette files (*.plt)|*.plt";

            if(od.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(od.FileName))
                {
                    FileStream inStream = File.OpenRead(od.FileName);
                    BinaryReader input = new BinaryReader(inStream);

                    try
                    {
                        // get palette size
                        int size = input.ReadInt32();
                        List<Color> colors = new List<Color>(size);
                        List<string> names = new List<string>(size);

                        // get colors
                        for(int i = 0; i < size; i++)
                        {
                            int argb = input.ReadInt32();
                            colors.Add(Color.FromArgb(argb));
                        }

                        // get color names
                        for(int i = 0; i < size; i++)
                        {
                            string name = input.ReadString();
                            names.Add(name);
                        }

                        // create and load palette
                        MapPalette mp = new MapPalette(colors, names);
                        LoadFromPalette(mp);
                    }
                    catch
                    {
                        MessageBox.Show("Error reading file, it may be corrupted",
                           "Error loading palette", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        input.Close();
                    }
                }
                else
                {
                    MessageBox.Show("That file does not exist", "Error loading palette",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void moveControlsUp(Panel panel, int index, int px)
        {
            for(int i = index; i < panel.Controls.Count; i++)
            {
                panel.Controls[i].Location = new Point(
                    panel.Controls[i].Location.X,
                    panel.Controls[i].Location.Y - px);
            }

            panel.Height -= px;
        }

        public MapPalette GetMapPalette()
        {
            // retrieve colors
            List<Color> colors = new List<Color>();
            foreach(Button b in panelColors.Controls)
            {
                colors.Add(b.BackColor);
            }

            // retrieve names
            List<string> names = new List<string>();
            foreach(TextBox tb in panelNames.Controls)
            {
                names.Add(tb.Text);
            }

            // construct palette
            MapPalette mp = new MapPalette(colors, names);
            return mp;
        }

        /// <summary>
        /// creates all necessary buttons from a given palette
        /// </summary>
        /// <param name="mp">palette to load from</param>
        private void LoadFromPalette(MapPalette mp)
        {
            // initialize panels
            panelRemove.Controls.Clear();
            panelNames.Controls.Clear();
            panelColors.Controls.Clear();

            int panelHeight = mp.colors.Count * (23 + 6);
            panelRemove.Height = panelHeight;
            panelNames.Height = panelHeight;
            panelColors.Height = panelHeight;

            for (int i = 0; i < mp.colors.Count; i++)
            {
                int y = (23 + 6) * i;

                // add remove button
                Button rb = new Button();
                rb.Location = new Point(0, y);
                rb.Size = new Size(panelRemove.Width, 23);
                rb.Text = "-";
                rb.Click += buttonRemove_Click;

                panelRemove.Controls.Add(rb);

                // add name field
                TextBox nt = new TextBox();
                nt.Location = new Point(0, y);
                nt.Size = new Size(panelNames.Width, 23);
                nt.Text = mp.names[i];

                panelNames.Controls.Add(nt);

                // add color button
                Button cb = new Button();
                cb.Location = new Point(0, y);
                cb.Size = new Size(panelColors.Width, 23);
                cb.BackColor = mp.colors[i];
                cb.Click += buttonColor_Click;

                panelColors.Controls.Add(cb);
            }
        }
    }
}
