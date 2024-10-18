namespace MapConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLoad = new Button();
            panelMap = new Panel();
            pictureBoxMap = new PictureBox();
            groupBoxColors = new GroupBox();
            panelColors = new Panel();
            checkBoxVerdantFroglight = new CheckBox();
            checkBoxRawIron = new CheckBox();
            checkBoxDeepslate = new CheckBox();
            checkBoxWarpedWartBlock = new CheckBox();
            checkBoxWarpedHyphae = new CheckBox();
            checkBoxWarpedPlanks = new CheckBox();
            checkBoxWarpedNylium = new CheckBox();
            checkBoxCrimsonHyphae = new CheckBox();
            checkBoxCrimsonStem = new CheckBox();
            checkBoxCrimsonNylium = new CheckBox();
            checkBoxTerracottaBlack = new CheckBox();
            checkBoxTerracottaRed = new CheckBox();
            checkBoxTerracottaGreen = new CheckBox();
            checkBoxTerracottaBrown = new CheckBox();
            checkBoxTerracottaBlue = new CheckBox();
            checkBoxTerracottaPurple = new CheckBox();
            checkBoxTerracottaCyan = new CheckBox();
            checkBoxTerracottaLightGray = new CheckBox();
            checkBoxTerracottaGray = new CheckBox();
            checkBoxTerracottaPink = new CheckBox();
            checkBoxTerracottaLightGreen = new CheckBox();
            checkBoxTerracottaYellow = new CheckBox();
            checkBoxTerracottaLightBlue = new CheckBox();
            checkBoxTerracottaMagenta = new CheckBox();
            checkBoxTerracottaOrange = new CheckBox();
            checkBoxTerracottaWhite = new CheckBox();
            checkBoxNether = new CheckBox();
            checkBoxPodzol = new CheckBox();
            checkBoxEmerald = new CheckBox();
            checkBoxLapis = new CheckBox();
            checkBoxDiamond = new CheckBox();
            checkBoxGold = new CheckBox();
            checkBoxColorBlack = new CheckBox();
            checkBoxColorRed = new CheckBox();
            checkBoxColorGreen = new CheckBox();
            checkBoxColorBrown = new CheckBox();
            checkBoxColorBlue = new CheckBox();
            checkBoxColorPurple = new CheckBox();
            checkBoxColorCyan = new CheckBox();
            checkBoxColorLightGray = new CheckBox();
            checkBoxColorGray = new CheckBox();
            checkBoxColorPink = new CheckBox();
            checkBoxColorLightGreen = new CheckBox();
            checkBoxColorYellow = new CheckBox();
            checkBoxColorLightBlue = new CheckBox();
            checkBoxColorMagenta = new CheckBox();
            checkBoxColorOrange = new CheckBox();
            checkBoxQuartz = new CheckBox();
            checkBoxWood = new CheckBox();
            checkBoxWater = new CheckBox();
            checkBoxStone = new CheckBox();
            checkBoxDirt = new CheckBox();
            checkBoxClay = new CheckBox();
            checkBoxSnow = new CheckBox();
            checkBoxPlant = new CheckBox();
            checkBoxMetal = new CheckBox();
            checkBoxIce = new CheckBox();
            checkBoxFire = new CheckBox();
            checkBoxWool = new CheckBox();
            checkBoxSand = new CheckBox();
            checkBoxGrass = new CheckBox();
            buttonConvertRGB = new Button();
            buttonZoomIn = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            buttonEdit = new Button();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            groupBoxColors.SuspendLayout();
            panelColors.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLoad.Location = new Point(12, 415);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(99, 23);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load Image";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // panelMap
            // 
            panelMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMap.AutoScroll = true;
            panelMap.Controls.Add(pictureBoxMap);
            panelMap.Location = new Point(222, 0);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(575, 450);
            panelMap.TabIndex = 2;
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.BackgroundImageLayout = ImageLayout.None;
            pictureBoxMap.Location = new Point(0, 0);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(575, 450);
            pictureBoxMap.TabIndex = 0;
            pictureBoxMap.TabStop = false;
            // 
            // groupBoxColors
            // 
            groupBoxColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxColors.BackColor = SystemColors.Control;
            groupBoxColors.Controls.Add(panelColors);
            groupBoxColors.Location = new Point(12, 12);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(204, 312);
            groupBoxColors.TabIndex = 3;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Colors";
            // 
            // panelColors
            // 
            panelColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelColors.AutoScroll = true;
            panelColors.Controls.Add(checkBoxVerdantFroglight);
            panelColors.Controls.Add(checkBoxRawIron);
            panelColors.Controls.Add(checkBoxDeepslate);
            panelColors.Controls.Add(checkBoxWarpedWartBlock);
            panelColors.Controls.Add(checkBoxWarpedHyphae);
            panelColors.Controls.Add(checkBoxWarpedPlanks);
            panelColors.Controls.Add(checkBoxWarpedNylium);
            panelColors.Controls.Add(checkBoxCrimsonHyphae);
            panelColors.Controls.Add(checkBoxCrimsonStem);
            panelColors.Controls.Add(checkBoxCrimsonNylium);
            panelColors.Controls.Add(checkBoxTerracottaBlack);
            panelColors.Controls.Add(checkBoxTerracottaRed);
            panelColors.Controls.Add(checkBoxTerracottaGreen);
            panelColors.Controls.Add(checkBoxTerracottaBrown);
            panelColors.Controls.Add(checkBoxTerracottaBlue);
            panelColors.Controls.Add(checkBoxTerracottaPurple);
            panelColors.Controls.Add(checkBoxTerracottaCyan);
            panelColors.Controls.Add(checkBoxTerracottaLightGray);
            panelColors.Controls.Add(checkBoxTerracottaGray);
            panelColors.Controls.Add(checkBoxTerracottaPink);
            panelColors.Controls.Add(checkBoxTerracottaLightGreen);
            panelColors.Controls.Add(checkBoxTerracottaYellow);
            panelColors.Controls.Add(checkBoxTerracottaLightBlue);
            panelColors.Controls.Add(checkBoxTerracottaMagenta);
            panelColors.Controls.Add(checkBoxTerracottaOrange);
            panelColors.Controls.Add(checkBoxTerracottaWhite);
            panelColors.Controls.Add(checkBoxNether);
            panelColors.Controls.Add(checkBoxPodzol);
            panelColors.Controls.Add(checkBoxEmerald);
            panelColors.Controls.Add(checkBoxLapis);
            panelColors.Controls.Add(checkBoxDiamond);
            panelColors.Controls.Add(checkBoxGold);
            panelColors.Controls.Add(checkBoxColorBlack);
            panelColors.Controls.Add(checkBoxColorRed);
            panelColors.Controls.Add(checkBoxColorGreen);
            panelColors.Controls.Add(checkBoxColorBrown);
            panelColors.Controls.Add(checkBoxColorBlue);
            panelColors.Controls.Add(checkBoxColorPurple);
            panelColors.Controls.Add(checkBoxColorCyan);
            panelColors.Controls.Add(checkBoxColorLightGray);
            panelColors.Controls.Add(checkBoxColorGray);
            panelColors.Controls.Add(checkBoxColorPink);
            panelColors.Controls.Add(checkBoxColorLightGreen);
            panelColors.Controls.Add(checkBoxColorYellow);
            panelColors.Controls.Add(checkBoxColorLightBlue);
            panelColors.Controls.Add(checkBoxColorMagenta);
            panelColors.Controls.Add(checkBoxColorOrange);
            panelColors.Controls.Add(checkBoxQuartz);
            panelColors.Controls.Add(checkBoxWood);
            panelColors.Controls.Add(checkBoxWater);
            panelColors.Controls.Add(checkBoxStone);
            panelColors.Controls.Add(checkBoxDirt);
            panelColors.Controls.Add(checkBoxClay);
            panelColors.Controls.Add(checkBoxSnow);
            panelColors.Controls.Add(checkBoxPlant);
            panelColors.Controls.Add(checkBoxMetal);
            panelColors.Controls.Add(checkBoxIce);
            panelColors.Controls.Add(checkBoxFire);
            panelColors.Controls.Add(checkBoxWool);
            panelColors.Controls.Add(checkBoxSand);
            panelColors.Controls.Add(checkBoxGrass);
            panelColors.Location = new Point(6, 22);
            panelColors.Name = "panelColors";
            panelColors.Size = new Size(198, 284);
            panelColors.TabIndex = 4;
            // 
            // checkBoxVerdantFroglight
            // 
            checkBoxVerdantFroglight.AutoSize = true;
            checkBoxVerdantFroglight.BackColor = SystemColors.Control;
            checkBoxVerdantFroglight.Checked = true;
            checkBoxVerdantFroglight.CheckState = CheckState.Checked;
            checkBoxVerdantFroglight.Location = new Point(3, 1503);
            checkBoxVerdantFroglight.Name = "checkBoxVerdantFroglight";
            checkBoxVerdantFroglight.Size = new Size(117, 19);
            checkBoxVerdantFroglight.TabIndex = 59;
            checkBoxVerdantFroglight.Text = "Verdant Froglight";
            checkBoxVerdantFroglight.UseVisualStyleBackColor = false;
            // 
            // checkBoxRawIron
            // 
            checkBoxRawIron.AutoSize = true;
            checkBoxRawIron.BackColor = SystemColors.Control;
            checkBoxRawIron.Checked = true;
            checkBoxRawIron.CheckState = CheckState.Checked;
            checkBoxRawIron.Location = new Point(3, 1478);
            checkBoxRawIron.Name = "checkBoxRawIron";
            checkBoxRawIron.Size = new Size(118, 19);
            checkBoxRawIron.TabIndex = 58;
            checkBoxRawIron.Text = "Block of Raw Iron";
            checkBoxRawIron.UseVisualStyleBackColor = false;
            // 
            // checkBoxDeepslate
            // 
            checkBoxDeepslate.AutoSize = true;
            checkBoxDeepslate.BackColor = SystemColors.Control;
            checkBoxDeepslate.Checked = true;
            checkBoxDeepslate.CheckState = CheckState.Checked;
            checkBoxDeepslate.Location = new Point(3, 1453);
            checkBoxDeepslate.Name = "checkBoxDeepslate";
            checkBoxDeepslate.Size = new Size(77, 19);
            checkBoxDeepslate.TabIndex = 57;
            checkBoxDeepslate.Text = "Deepslate";
            checkBoxDeepslate.UseVisualStyleBackColor = false;
            // 
            // checkBoxWarpedWartBlock
            // 
            checkBoxWarpedWartBlock.AutoSize = true;
            checkBoxWarpedWartBlock.BackColor = SystemColors.Control;
            checkBoxWarpedWartBlock.Checked = true;
            checkBoxWarpedWartBlock.CheckState = CheckState.Checked;
            checkBoxWarpedWartBlock.Location = new Point(3, 1428);
            checkBoxWarpedWartBlock.Name = "checkBoxWarpedWartBlock";
            checkBoxWarpedWartBlock.Size = new Size(127, 19);
            checkBoxWarpedWartBlock.TabIndex = 56;
            checkBoxWarpedWartBlock.Text = "Warped Wart Block";
            checkBoxWarpedWartBlock.UseVisualStyleBackColor = false;
            // 
            // checkBoxWarpedHyphae
            // 
            checkBoxWarpedHyphae.AutoSize = true;
            checkBoxWarpedHyphae.BackColor = SystemColors.Control;
            checkBoxWarpedHyphae.Checked = true;
            checkBoxWarpedHyphae.CheckState = CheckState.Checked;
            checkBoxWarpedHyphae.Location = new Point(3, 1403);
            checkBoxWarpedHyphae.Name = "checkBoxWarpedHyphae";
            checkBoxWarpedHyphae.Size = new Size(111, 19);
            checkBoxWarpedHyphae.TabIndex = 55;
            checkBoxWarpedHyphae.Text = "Warped Hyphae";
            checkBoxWarpedHyphae.UseVisualStyleBackColor = false;
            // 
            // checkBoxWarpedPlanks
            // 
            checkBoxWarpedPlanks.AutoSize = true;
            checkBoxWarpedPlanks.BackColor = SystemColors.Control;
            checkBoxWarpedPlanks.Checked = true;
            checkBoxWarpedPlanks.CheckState = CheckState.Checked;
            checkBoxWarpedPlanks.Location = new Point(3, 1378);
            checkBoxWarpedPlanks.Name = "checkBoxWarpedPlanks";
            checkBoxWarpedPlanks.Size = new Size(104, 19);
            checkBoxWarpedPlanks.TabIndex = 54;
            checkBoxWarpedPlanks.Text = "Warped Planks";
            checkBoxWarpedPlanks.UseVisualStyleBackColor = false;
            // 
            // checkBoxWarpedNylium
            // 
            checkBoxWarpedNylium.AutoSize = true;
            checkBoxWarpedNylium.BackColor = SystemColors.Control;
            checkBoxWarpedNylium.Checked = true;
            checkBoxWarpedNylium.CheckState = CheckState.Checked;
            checkBoxWarpedNylium.Location = new Point(3, 1353);
            checkBoxWarpedNylium.Name = "checkBoxWarpedNylium";
            checkBoxWarpedNylium.Size = new Size(109, 19);
            checkBoxWarpedNylium.TabIndex = 53;
            checkBoxWarpedNylium.Text = "Warped Nylium";
            checkBoxWarpedNylium.UseVisualStyleBackColor = false;
            // 
            // checkBoxCrimsonHyphae
            // 
            checkBoxCrimsonHyphae.AutoSize = true;
            checkBoxCrimsonHyphae.BackColor = SystemColors.Control;
            checkBoxCrimsonHyphae.Checked = true;
            checkBoxCrimsonHyphae.CheckState = CheckState.Checked;
            checkBoxCrimsonHyphae.Location = new Point(3, 1328);
            checkBoxCrimsonHyphae.Name = "checkBoxCrimsonHyphae";
            checkBoxCrimsonHyphae.Size = new Size(115, 19);
            checkBoxCrimsonHyphae.TabIndex = 52;
            checkBoxCrimsonHyphae.Text = "Crimson Hyphae";
            checkBoxCrimsonHyphae.UseVisualStyleBackColor = false;
            // 
            // checkBoxCrimsonStem
            // 
            checkBoxCrimsonStem.AutoSize = true;
            checkBoxCrimsonStem.BackColor = SystemColors.Control;
            checkBoxCrimsonStem.Checked = true;
            checkBoxCrimsonStem.CheckState = CheckState.Checked;
            checkBoxCrimsonStem.Location = new Point(3, 1303);
            checkBoxCrimsonStem.Name = "checkBoxCrimsonStem";
            checkBoxCrimsonStem.Size = new Size(108, 19);
            checkBoxCrimsonStem.TabIndex = 51;
            checkBoxCrimsonStem.Text = "Crimson Planks";
            checkBoxCrimsonStem.UseVisualStyleBackColor = false;
            // 
            // checkBoxCrimsonNylium
            // 
            checkBoxCrimsonNylium.AutoSize = true;
            checkBoxCrimsonNylium.BackColor = SystemColors.Control;
            checkBoxCrimsonNylium.Checked = true;
            checkBoxCrimsonNylium.CheckState = CheckState.Checked;
            checkBoxCrimsonNylium.Location = new Point(3, 1278);
            checkBoxCrimsonNylium.Name = "checkBoxCrimsonNylium";
            checkBoxCrimsonNylium.Size = new Size(113, 19);
            checkBoxCrimsonNylium.TabIndex = 50;
            checkBoxCrimsonNylium.Text = "Crimson Nylium";
            checkBoxCrimsonNylium.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaBlack
            // 
            checkBoxTerracottaBlack.AutoSize = true;
            checkBoxTerracottaBlack.BackColor = SystemColors.Control;
            checkBoxTerracottaBlack.Checked = true;
            checkBoxTerracottaBlack.CheckState = CheckState.Checked;
            checkBoxTerracottaBlack.Location = new Point(3, 1253);
            checkBoxTerracottaBlack.Name = "checkBoxTerracottaBlack";
            checkBoxTerracottaBlack.Size = new Size(109, 19);
            checkBoxTerracottaBlack.TabIndex = 49;
            checkBoxTerracottaBlack.Text = "Black Terracotta";
            checkBoxTerracottaBlack.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaRed
            // 
            checkBoxTerracottaRed.AutoSize = true;
            checkBoxTerracottaRed.BackColor = SystemColors.Control;
            checkBoxTerracottaRed.Checked = true;
            checkBoxTerracottaRed.CheckState = CheckState.Checked;
            checkBoxTerracottaRed.Location = new Point(3, 1228);
            checkBoxTerracottaRed.Name = "checkBoxTerracottaRed";
            checkBoxTerracottaRed.Size = new Size(101, 19);
            checkBoxTerracottaRed.TabIndex = 48;
            checkBoxTerracottaRed.Text = "Red Terracotta";
            checkBoxTerracottaRed.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaGreen
            // 
            checkBoxTerracottaGreen.AutoSize = true;
            checkBoxTerracottaGreen.BackColor = SystemColors.Control;
            checkBoxTerracottaGreen.Checked = true;
            checkBoxTerracottaGreen.CheckState = CheckState.Checked;
            checkBoxTerracottaGreen.Location = new Point(3, 1203);
            checkBoxTerracottaGreen.Name = "checkBoxTerracottaGreen";
            checkBoxTerracottaGreen.Size = new Size(112, 19);
            checkBoxTerracottaGreen.TabIndex = 47;
            checkBoxTerracottaGreen.Text = "Green Terracotta";
            checkBoxTerracottaGreen.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaBrown
            // 
            checkBoxTerracottaBrown.AutoSize = true;
            checkBoxTerracottaBrown.BackColor = SystemColors.Control;
            checkBoxTerracottaBrown.Checked = true;
            checkBoxTerracottaBrown.CheckState = CheckState.Checked;
            checkBoxTerracottaBrown.Location = new Point(3, 1178);
            checkBoxTerracottaBrown.Name = "checkBoxTerracottaBrown";
            checkBoxTerracottaBrown.Size = new Size(115, 19);
            checkBoxTerracottaBrown.TabIndex = 46;
            checkBoxTerracottaBrown.Text = "Brown Terracotta";
            checkBoxTerracottaBrown.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaBlue
            // 
            checkBoxTerracottaBlue.AutoSize = true;
            checkBoxTerracottaBlue.BackColor = SystemColors.Control;
            checkBoxTerracottaBlue.Checked = true;
            checkBoxTerracottaBlue.CheckState = CheckState.Checked;
            checkBoxTerracottaBlue.Location = new Point(3, 1153);
            checkBoxTerracottaBlue.Name = "checkBoxTerracottaBlue";
            checkBoxTerracottaBlue.Size = new Size(104, 19);
            checkBoxTerracottaBlue.TabIndex = 45;
            checkBoxTerracottaBlue.Text = "Blue Terracotta";
            checkBoxTerracottaBlue.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaPurple
            // 
            checkBoxTerracottaPurple.AutoSize = true;
            checkBoxTerracottaPurple.BackColor = SystemColors.Control;
            checkBoxTerracottaPurple.Checked = true;
            checkBoxTerracottaPurple.CheckState = CheckState.Checked;
            checkBoxTerracottaPurple.Location = new Point(3, 1128);
            checkBoxTerracottaPurple.Name = "checkBoxTerracottaPurple";
            checkBoxTerracottaPurple.Size = new Size(115, 19);
            checkBoxTerracottaPurple.TabIndex = 44;
            checkBoxTerracottaPurple.Text = "Purple Terracotta";
            checkBoxTerracottaPurple.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaCyan
            // 
            checkBoxTerracottaCyan.AutoSize = true;
            checkBoxTerracottaCyan.BackColor = SystemColors.Control;
            checkBoxTerracottaCyan.Checked = true;
            checkBoxTerracottaCyan.CheckState = CheckState.Checked;
            checkBoxTerracottaCyan.Location = new Point(3, 1103);
            checkBoxTerracottaCyan.Name = "checkBoxTerracottaCyan";
            checkBoxTerracottaCyan.Size = new Size(108, 19);
            checkBoxTerracottaCyan.TabIndex = 43;
            checkBoxTerracottaCyan.Text = "Cyan Terracotta";
            checkBoxTerracottaCyan.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaLightGray
            // 
            checkBoxTerracottaLightGray.AutoSize = true;
            checkBoxTerracottaLightGray.BackColor = SystemColors.Control;
            checkBoxTerracottaLightGray.Checked = true;
            checkBoxTerracottaLightGray.CheckState = CheckState.Checked;
            checkBoxTerracottaLightGray.Location = new Point(3, 1078);
            checkBoxTerracottaLightGray.Name = "checkBoxTerracottaLightGray";
            checkBoxTerracottaLightGray.Size = new Size(135, 19);
            checkBoxTerracottaLightGray.TabIndex = 42;
            checkBoxTerracottaLightGray.Text = "Light Gray Terracotta";
            checkBoxTerracottaLightGray.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaGray
            // 
            checkBoxTerracottaGray.AutoSize = true;
            checkBoxTerracottaGray.BackColor = SystemColors.Control;
            checkBoxTerracottaGray.Checked = true;
            checkBoxTerracottaGray.CheckState = CheckState.Checked;
            checkBoxTerracottaGray.Location = new Point(3, 1053);
            checkBoxTerracottaGray.Name = "checkBoxTerracottaGray";
            checkBoxTerracottaGray.Size = new Size(105, 19);
            checkBoxTerracottaGray.TabIndex = 41;
            checkBoxTerracottaGray.Text = "Gray Terracotta";
            checkBoxTerracottaGray.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaPink
            // 
            checkBoxTerracottaPink.AutoSize = true;
            checkBoxTerracottaPink.BackColor = SystemColors.Control;
            checkBoxTerracottaPink.Checked = true;
            checkBoxTerracottaPink.CheckState = CheckState.Checked;
            checkBoxTerracottaPink.Location = new Point(3, 1028);
            checkBoxTerracottaPink.Name = "checkBoxTerracottaPink";
            checkBoxTerracottaPink.Size = new Size(104, 19);
            checkBoxTerracottaPink.TabIndex = 40;
            checkBoxTerracottaPink.Text = "Pink Terracotta";
            checkBoxTerracottaPink.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaLightGreen
            // 
            checkBoxTerracottaLightGreen.AutoSize = true;
            checkBoxTerracottaLightGreen.BackColor = SystemColors.Control;
            checkBoxTerracottaLightGreen.Checked = true;
            checkBoxTerracottaLightGreen.CheckState = CheckState.Checked;
            checkBoxTerracottaLightGreen.Location = new Point(3, 1003);
            checkBoxTerracottaLightGreen.Name = "checkBoxTerracottaLightGreen";
            checkBoxTerracottaLightGreen.Size = new Size(107, 19);
            checkBoxTerracottaLightGreen.TabIndex = 39;
            checkBoxTerracottaLightGreen.Text = "Lime Terracotta";
            checkBoxTerracottaLightGreen.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaYellow
            // 
            checkBoxTerracottaYellow.AutoSize = true;
            checkBoxTerracottaYellow.BackColor = SystemColors.Control;
            checkBoxTerracottaYellow.Checked = true;
            checkBoxTerracottaYellow.CheckState = CheckState.Checked;
            checkBoxTerracottaYellow.Location = new Point(3, 978);
            checkBoxTerracottaYellow.Name = "checkBoxTerracottaYellow";
            checkBoxTerracottaYellow.Size = new Size(115, 19);
            checkBoxTerracottaYellow.TabIndex = 38;
            checkBoxTerracottaYellow.Text = "Yellow Terracotta";
            checkBoxTerracottaYellow.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaLightBlue
            // 
            checkBoxTerracottaLightBlue.AutoSize = true;
            checkBoxTerracottaLightBlue.BackColor = SystemColors.Control;
            checkBoxTerracottaLightBlue.Checked = true;
            checkBoxTerracottaLightBlue.CheckState = CheckState.Checked;
            checkBoxTerracottaLightBlue.Location = new Point(3, 953);
            checkBoxTerracottaLightBlue.Name = "checkBoxTerracottaLightBlue";
            checkBoxTerracottaLightBlue.Size = new Size(134, 19);
            checkBoxTerracottaLightBlue.TabIndex = 37;
            checkBoxTerracottaLightBlue.Text = "Light blue Terracotta";
            checkBoxTerracottaLightBlue.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaMagenta
            // 
            checkBoxTerracottaMagenta.AutoSize = true;
            checkBoxTerracottaMagenta.BackColor = SystemColors.Control;
            checkBoxTerracottaMagenta.Checked = true;
            checkBoxTerracottaMagenta.CheckState = CheckState.Checked;
            checkBoxTerracottaMagenta.Location = new Point(3, 928);
            checkBoxTerracottaMagenta.Name = "checkBoxTerracottaMagenta";
            checkBoxTerracottaMagenta.Size = new Size(128, 19);
            checkBoxTerracottaMagenta.TabIndex = 36;
            checkBoxTerracottaMagenta.Text = "Magenta Terracotta";
            checkBoxTerracottaMagenta.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaOrange
            // 
            checkBoxTerracottaOrange.AutoSize = true;
            checkBoxTerracottaOrange.BackColor = SystemColors.Control;
            checkBoxTerracottaOrange.Checked = true;
            checkBoxTerracottaOrange.CheckState = CheckState.Checked;
            checkBoxTerracottaOrange.Location = new Point(3, 903);
            checkBoxTerracottaOrange.Name = "checkBoxTerracottaOrange";
            checkBoxTerracottaOrange.Size = new Size(120, 19);
            checkBoxTerracottaOrange.TabIndex = 35;
            checkBoxTerracottaOrange.Text = "Orange Terracotta";
            checkBoxTerracottaOrange.UseVisualStyleBackColor = false;
            // 
            // checkBoxTerracottaWhite
            // 
            checkBoxTerracottaWhite.AutoSize = true;
            checkBoxTerracottaWhite.BackColor = SystemColors.Control;
            checkBoxTerracottaWhite.Checked = true;
            checkBoxTerracottaWhite.CheckState = CheckState.Checked;
            checkBoxTerracottaWhite.Location = new Point(3, 878);
            checkBoxTerracottaWhite.Name = "checkBoxTerracottaWhite";
            checkBoxTerracottaWhite.Size = new Size(112, 19);
            checkBoxTerracottaWhite.TabIndex = 34;
            checkBoxTerracottaWhite.Text = "White Terracotta";
            checkBoxTerracottaWhite.UseVisualStyleBackColor = false;
            // 
            // checkBoxNether
            // 
            checkBoxNether.AutoSize = true;
            checkBoxNether.BackColor = SystemColors.Control;
            checkBoxNether.Checked = true;
            checkBoxNether.CheckState = CheckState.Checked;
            checkBoxNether.Location = new Point(3, 853);
            checkBoxNether.Name = "checkBoxNether";
            checkBoxNether.Size = new Size(84, 19);
            checkBoxNether.TabIndex = 33;
            checkBoxNether.Text = "Netherrack";
            checkBoxNether.UseVisualStyleBackColor = false;
            // 
            // checkBoxPodzol
            // 
            checkBoxPodzol.AutoSize = true;
            checkBoxPodzol.BackColor = SystemColors.Control;
            checkBoxPodzol.Checked = true;
            checkBoxPodzol.CheckState = CheckState.Checked;
            checkBoxPodzol.Location = new Point(3, 828);
            checkBoxPodzol.Name = "checkBoxPodzol";
            checkBoxPodzol.Size = new Size(62, 19);
            checkBoxPodzol.TabIndex = 32;
            checkBoxPodzol.Text = "Podzol";
            checkBoxPodzol.UseVisualStyleBackColor = false;
            // 
            // checkBoxEmerald
            // 
            checkBoxEmerald.AutoSize = true;
            checkBoxEmerald.BackColor = SystemColors.Control;
            checkBoxEmerald.Checked = true;
            checkBoxEmerald.CheckState = CheckState.Checked;
            checkBoxEmerald.Location = new Point(3, 803);
            checkBoxEmerald.Name = "checkBoxEmerald";
            checkBoxEmerald.Size = new Size(115, 19);
            checkBoxEmerald.TabIndex = 31;
            checkBoxEmerald.Text = "Block of Emerald";
            checkBoxEmerald.UseVisualStyleBackColor = false;
            // 
            // checkBoxLapis
            // 
            checkBoxLapis.AutoSize = true;
            checkBoxLapis.BackColor = SystemColors.Control;
            checkBoxLapis.Checked = true;
            checkBoxLapis.CheckState = CheckState.Checked;
            checkBoxLapis.Location = new Point(3, 778);
            checkBoxLapis.Name = "checkBoxLapis";
            checkBoxLapis.Size = new Size(132, 19);
            checkBoxLapis.TabIndex = 30;
            checkBoxLapis.Text = "Block of Lapis Lazuli";
            checkBoxLapis.UseVisualStyleBackColor = false;
            // 
            // checkBoxDiamond
            // 
            checkBoxDiamond.AutoSize = true;
            checkBoxDiamond.BackColor = SystemColors.Control;
            checkBoxDiamond.Checked = true;
            checkBoxDiamond.CheckState = CheckState.Checked;
            checkBoxDiamond.Location = new Point(3, 753);
            checkBoxDiamond.Name = "checkBoxDiamond";
            checkBoxDiamond.Size = new Size(116, 19);
            checkBoxDiamond.TabIndex = 29;
            checkBoxDiamond.Text = "Prismarine Bricks";
            checkBoxDiamond.UseVisualStyleBackColor = false;
            // 
            // checkBoxGold
            // 
            checkBoxGold.AutoSize = true;
            checkBoxGold.BackColor = SystemColors.Control;
            checkBoxGold.Checked = true;
            checkBoxGold.CheckState = CheckState.Checked;
            checkBoxGold.Location = new Point(3, 728);
            checkBoxGold.Name = "checkBoxGold";
            checkBoxGold.Size = new Size(97, 19);
            checkBoxGold.TabIndex = 28;
            checkBoxGold.Text = "Block of Gold";
            checkBoxGold.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorBlack
            // 
            checkBoxColorBlack.AutoSize = true;
            checkBoxColorBlack.BackColor = SystemColors.Control;
            checkBoxColorBlack.Checked = true;
            checkBoxColorBlack.CheckState = CheckState.Checked;
            checkBoxColorBlack.Location = new Point(3, 703);
            checkBoxColorBlack.Name = "checkBoxColorBlack";
            checkBoxColorBlack.Size = new Size(105, 19);
            checkBoxColorBlack.TabIndex = 27;
            checkBoxColorBlack.Text = "Black Concrete";
            checkBoxColorBlack.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorRed
            // 
            checkBoxColorRed.AutoSize = true;
            checkBoxColorRed.BackColor = SystemColors.Control;
            checkBoxColorRed.Checked = true;
            checkBoxColorRed.CheckState = CheckState.Checked;
            checkBoxColorRed.Location = new Point(3, 678);
            checkBoxColorRed.Name = "checkBoxColorRed";
            checkBoxColorRed.Size = new Size(97, 19);
            checkBoxColorRed.TabIndex = 26;
            checkBoxColorRed.Text = "Red Concrete";
            checkBoxColorRed.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorGreen
            // 
            checkBoxColorGreen.AutoSize = true;
            checkBoxColorGreen.BackColor = SystemColors.Control;
            checkBoxColorGreen.Checked = true;
            checkBoxColorGreen.CheckState = CheckState.Checked;
            checkBoxColorGreen.Location = new Point(3, 653);
            checkBoxColorGreen.Name = "checkBoxColorGreen";
            checkBoxColorGreen.Size = new Size(108, 19);
            checkBoxColorGreen.TabIndex = 25;
            checkBoxColorGreen.Text = "Green Concrete";
            checkBoxColorGreen.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorBrown
            // 
            checkBoxColorBrown.AutoSize = true;
            checkBoxColorBrown.BackColor = SystemColors.Control;
            checkBoxColorBrown.Checked = true;
            checkBoxColorBrown.CheckState = CheckState.Checked;
            checkBoxColorBrown.Location = new Point(3, 628);
            checkBoxColorBrown.Name = "checkBoxColorBrown";
            checkBoxColorBrown.Size = new Size(111, 19);
            checkBoxColorBrown.TabIndex = 24;
            checkBoxColorBrown.Text = "Brown Concrete";
            checkBoxColorBrown.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorBlue
            // 
            checkBoxColorBlue.AutoSize = true;
            checkBoxColorBlue.BackColor = SystemColors.Control;
            checkBoxColorBlue.Checked = true;
            checkBoxColorBlue.CheckState = CheckState.Checked;
            checkBoxColorBlue.Location = new Point(3, 603);
            checkBoxColorBlue.Name = "checkBoxColorBlue";
            checkBoxColorBlue.Size = new Size(100, 19);
            checkBoxColorBlue.TabIndex = 23;
            checkBoxColorBlue.Text = "Blue Concrete";
            checkBoxColorBlue.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorPurple
            // 
            checkBoxColorPurple.AutoSize = true;
            checkBoxColorPurple.BackColor = SystemColors.Control;
            checkBoxColorPurple.Checked = true;
            checkBoxColorPurple.CheckState = CheckState.Checked;
            checkBoxColorPurple.Location = new Point(3, 578);
            checkBoxColorPurple.Name = "checkBoxColorPurple";
            checkBoxColorPurple.Size = new Size(111, 19);
            checkBoxColorPurple.TabIndex = 22;
            checkBoxColorPurple.Text = "Purple Concrete";
            checkBoxColorPurple.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorCyan
            // 
            checkBoxColorCyan.AutoSize = true;
            checkBoxColorCyan.BackColor = SystemColors.Control;
            checkBoxColorCyan.Checked = true;
            checkBoxColorCyan.CheckState = CheckState.Checked;
            checkBoxColorCyan.Location = new Point(3, 553);
            checkBoxColorCyan.Name = "checkBoxColorCyan";
            checkBoxColorCyan.Size = new Size(104, 19);
            checkBoxColorCyan.TabIndex = 21;
            checkBoxColorCyan.Text = "Cyan Concrete";
            checkBoxColorCyan.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorLightGray
            // 
            checkBoxColorLightGray.AutoSize = true;
            checkBoxColorLightGray.BackColor = SystemColors.Control;
            checkBoxColorLightGray.Checked = true;
            checkBoxColorLightGray.CheckState = CheckState.Checked;
            checkBoxColorLightGray.Location = new Point(3, 528);
            checkBoxColorLightGray.Name = "checkBoxColorLightGray";
            checkBoxColorLightGray.Size = new Size(131, 19);
            checkBoxColorLightGray.TabIndex = 20;
            checkBoxColorLightGray.Text = "Light Gray Concrete";
            checkBoxColorLightGray.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorGray
            // 
            checkBoxColorGray.AutoSize = true;
            checkBoxColorGray.BackColor = SystemColors.Control;
            checkBoxColorGray.Checked = true;
            checkBoxColorGray.CheckState = CheckState.Checked;
            checkBoxColorGray.Location = new Point(3, 503);
            checkBoxColorGray.Name = "checkBoxColorGray";
            checkBoxColorGray.Size = new Size(101, 19);
            checkBoxColorGray.TabIndex = 19;
            checkBoxColorGray.Text = "Gray Concrete";
            checkBoxColorGray.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorPink
            // 
            checkBoxColorPink.AutoSize = true;
            checkBoxColorPink.BackColor = SystemColors.Control;
            checkBoxColorPink.Checked = true;
            checkBoxColorPink.CheckState = CheckState.Checked;
            checkBoxColorPink.Location = new Point(3, 478);
            checkBoxColorPink.Name = "checkBoxColorPink";
            checkBoxColorPink.Size = new Size(100, 19);
            checkBoxColorPink.TabIndex = 18;
            checkBoxColorPink.Text = "Pink Concrete";
            checkBoxColorPink.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorLightGreen
            // 
            checkBoxColorLightGreen.AutoSize = true;
            checkBoxColorLightGreen.BackColor = SystemColors.Control;
            checkBoxColorLightGreen.Checked = true;
            checkBoxColorLightGreen.CheckState = CheckState.Checked;
            checkBoxColorLightGreen.Location = new Point(3, 453);
            checkBoxColorLightGreen.Name = "checkBoxColorLightGreen";
            checkBoxColorLightGreen.Size = new Size(103, 19);
            checkBoxColorLightGreen.TabIndex = 17;
            checkBoxColorLightGreen.Text = "Lime Concrete";
            checkBoxColorLightGreen.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorYellow
            // 
            checkBoxColorYellow.AutoSize = true;
            checkBoxColorYellow.BackColor = SystemColors.Control;
            checkBoxColorYellow.Checked = true;
            checkBoxColorYellow.CheckState = CheckState.Checked;
            checkBoxColorYellow.Location = new Point(3, 428);
            checkBoxColorYellow.Name = "checkBoxColorYellow";
            checkBoxColorYellow.Size = new Size(111, 19);
            checkBoxColorYellow.TabIndex = 16;
            checkBoxColorYellow.Text = "Yellow Concrete";
            checkBoxColorYellow.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorLightBlue
            // 
            checkBoxColorLightBlue.AutoSize = true;
            checkBoxColorLightBlue.BackColor = SystemColors.Control;
            checkBoxColorLightBlue.Checked = true;
            checkBoxColorLightBlue.CheckState = CheckState.Checked;
            checkBoxColorLightBlue.Location = new Point(3, 403);
            checkBoxColorLightBlue.Name = "checkBoxColorLightBlue";
            checkBoxColorLightBlue.Size = new Size(130, 19);
            checkBoxColorLightBlue.TabIndex = 15;
            checkBoxColorLightBlue.Text = "Light Blue Concrete";
            checkBoxColorLightBlue.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorMagenta
            // 
            checkBoxColorMagenta.AutoSize = true;
            checkBoxColorMagenta.BackColor = SystemColors.Control;
            checkBoxColorMagenta.Checked = true;
            checkBoxColorMagenta.CheckState = CheckState.Checked;
            checkBoxColorMagenta.Location = new Point(3, 378);
            checkBoxColorMagenta.Name = "checkBoxColorMagenta";
            checkBoxColorMagenta.Size = new Size(124, 19);
            checkBoxColorMagenta.TabIndex = 14;
            checkBoxColorMagenta.Text = "Magenta Concrete";
            checkBoxColorMagenta.UseVisualStyleBackColor = false;
            // 
            // checkBoxColorOrange
            // 
            checkBoxColorOrange.AutoSize = true;
            checkBoxColorOrange.BackColor = SystemColors.Control;
            checkBoxColorOrange.Checked = true;
            checkBoxColorOrange.CheckState = CheckState.Checked;
            checkBoxColorOrange.Location = new Point(3, 353);
            checkBoxColorOrange.Name = "checkBoxColorOrange";
            checkBoxColorOrange.Size = new Size(116, 19);
            checkBoxColorOrange.TabIndex = 13;
            checkBoxColorOrange.Text = "Orange Concrete";
            checkBoxColorOrange.UseVisualStyleBackColor = false;
            // 
            // checkBoxQuartz
            // 
            checkBoxQuartz.AutoSize = true;
            checkBoxQuartz.BackColor = SystemColors.Control;
            checkBoxQuartz.Checked = true;
            checkBoxQuartz.CheckState = CheckState.Checked;
            checkBoxQuartz.Location = new Point(3, 328);
            checkBoxQuartz.Name = "checkBoxQuartz";
            checkBoxQuartz.Size = new Size(107, 19);
            checkBoxQuartz.TabIndex = 12;
            checkBoxQuartz.Text = "Block of Quartz";
            checkBoxQuartz.UseVisualStyleBackColor = false;
            // 
            // checkBoxWood
            // 
            checkBoxWood.AutoSize = true;
            checkBoxWood.BackColor = SystemColors.Control;
            checkBoxWood.Checked = true;
            checkBoxWood.CheckState = CheckState.Checked;
            checkBoxWood.Location = new Point(3, 303);
            checkBoxWood.Name = "checkBoxWood";
            checkBoxWood.Size = new Size(84, 19);
            checkBoxWood.TabIndex = 11;
            checkBoxWood.Text = "Oak Planks";
            checkBoxWood.UseVisualStyleBackColor = false;
            // 
            // checkBoxWater
            // 
            checkBoxWater.AutoSize = true;
            checkBoxWater.BackColor = SystemColors.Control;
            checkBoxWater.Checked = true;
            checkBoxWater.CheckState = CheckState.Checked;
            checkBoxWater.Location = new Point(3, 278);
            checkBoxWater.Name = "checkBoxWater";
            checkBoxWater.Size = new Size(57, 19);
            checkBoxWater.TabIndex = 10;
            checkBoxWater.Text = "Water";
            checkBoxWater.UseVisualStyleBackColor = false;
            // 
            // checkBoxStone
            // 
            checkBoxStone.AutoSize = true;
            checkBoxStone.BackColor = SystemColors.Control;
            checkBoxStone.Checked = true;
            checkBoxStone.CheckState = CheckState.Checked;
            checkBoxStone.Location = new Point(3, 253);
            checkBoxStone.Name = "checkBoxStone";
            checkBoxStone.Size = new Size(93, 19);
            checkBoxStone.TabIndex = 9;
            checkBoxStone.Text = "Cobblestone";
            checkBoxStone.UseVisualStyleBackColor = false;
            // 
            // checkBoxDirt
            // 
            checkBoxDirt.AutoSize = true;
            checkBoxDirt.BackColor = SystemColors.Control;
            checkBoxDirt.Checked = true;
            checkBoxDirt.CheckState = CheckState.Checked;
            checkBoxDirt.Location = new Point(3, 228);
            checkBoxDirt.Name = "checkBoxDirt";
            checkBoxDirt.Size = new Size(45, 19);
            checkBoxDirt.TabIndex = 8;
            checkBoxDirt.Text = "Dirt";
            checkBoxDirt.UseVisualStyleBackColor = false;
            // 
            // checkBoxClay
            // 
            checkBoxClay.AutoSize = true;
            checkBoxClay.BackColor = SystemColors.Control;
            checkBoxClay.Checked = true;
            checkBoxClay.CheckState = CheckState.Checked;
            checkBoxClay.Location = new Point(3, 203);
            checkBoxClay.Name = "checkBoxClay";
            checkBoxClay.Size = new Size(49, 19);
            checkBoxClay.TabIndex = 7;
            checkBoxClay.Text = "Clay";
            checkBoxClay.UseVisualStyleBackColor = false;
            // 
            // checkBoxSnow
            // 
            checkBoxSnow.AutoSize = true;
            checkBoxSnow.BackColor = SystemColors.Control;
            checkBoxSnow.Checked = true;
            checkBoxSnow.CheckState = CheckState.Checked;
            checkBoxSnow.Location = new Point(3, 178);
            checkBoxSnow.Name = "checkBoxSnow";
            checkBoxSnow.Size = new Size(108, 19);
            checkBoxSnow.TabIndex = 6;
            checkBoxSnow.Text = "White Concrete";
            checkBoxSnow.UseVisualStyleBackColor = false;
            // 
            // checkBoxPlant
            // 
            checkBoxPlant.AutoSize = true;
            checkBoxPlant.BackColor = SystemColors.Control;
            checkBoxPlant.Checked = true;
            checkBoxPlant.CheckState = CheckState.Checked;
            checkBoxPlant.Location = new Point(3, 153);
            checkBoxPlant.Name = "checkBoxPlant";
            checkBoxPlant.Size = new Size(61, 19);
            checkBoxPlant.TabIndex = 5;
            checkBoxPlant.Text = "Leaves";
            checkBoxPlant.UseVisualStyleBackColor = false;
            // 
            // checkBoxMetal
            // 
            checkBoxMetal.AutoSize = true;
            checkBoxMetal.BackColor = SystemColors.Control;
            checkBoxMetal.Checked = true;
            checkBoxMetal.CheckState = CheckState.Checked;
            checkBoxMetal.Location = new Point(3, 128);
            checkBoxMetal.Name = "checkBoxMetal";
            checkBoxMetal.Size = new Size(93, 19);
            checkBoxMetal.TabIndex = 4;
            checkBoxMetal.Text = "Block of Iron";
            checkBoxMetal.UseVisualStyleBackColor = false;
            // 
            // checkBoxIce
            // 
            checkBoxIce.AutoSize = true;
            checkBoxIce.BackColor = SystemColors.Control;
            checkBoxIce.Checked = true;
            checkBoxIce.CheckState = CheckState.Checked;
            checkBoxIce.Location = new Point(3, 103);
            checkBoxIce.Name = "checkBoxIce";
            checkBoxIce.Size = new Size(82, 19);
            checkBoxIce.TabIndex = 60;
            checkBoxIce.Text = "Packed Ice";
            checkBoxIce.UseVisualStyleBackColor = false;
            // 
            // checkBoxFire
            // 
            checkBoxFire.AutoSize = true;
            checkBoxFire.BackColor = SystemColors.Control;
            checkBoxFire.Checked = true;
            checkBoxFire.CheckState = CheckState.Checked;
            checkBoxFire.Location = new Point(3, 78);
            checkBoxFire.Name = "checkBoxFire";
            checkBoxFire.Size = new Size(107, 19);
            checkBoxFire.TabIndex = 3;
            checkBoxFire.Text = "Redstone Block";
            checkBoxFire.UseVisualStyleBackColor = false;
            // 
            // checkBoxWool
            // 
            checkBoxWool.AutoSize = true;
            checkBoxWool.BackColor = SystemColors.Control;
            checkBoxWool.Checked = true;
            checkBoxWool.CheckState = CheckState.Checked;
            checkBoxWool.Location = new Point(3, 53);
            checkBoxWool.Name = "checkBoxWool";
            checkBoxWool.Size = new Size(115, 19);
            checkBoxWool.TabIndex = 2;
            checkBoxWool.Text = "Mushroom Stem";
            checkBoxWool.UseVisualStyleBackColor = false;
            // 
            // checkBoxSand
            // 
            checkBoxSand.AutoSize = true;
            checkBoxSand.BackColor = SystemColors.Control;
            checkBoxSand.Checked = true;
            checkBoxSand.CheckState = CheckState.Checked;
            checkBoxSand.Location = new Point(3, 28);
            checkBoxSand.Name = "checkBoxSand";
            checkBoxSand.Size = new Size(81, 19);
            checkBoxSand.TabIndex = 1;
            checkBoxSand.Text = "Sandstone";
            checkBoxSand.UseVisualStyleBackColor = false;
            // 
            // checkBoxGrass
            // 
            checkBoxGrass.AutoSize = true;
            checkBoxGrass.BackColor = SystemColors.Control;
            checkBoxGrass.Checked = true;
            checkBoxGrass.CheckState = CheckState.Checked;
            checkBoxGrass.Location = new Point(3, 3);
            checkBoxGrass.Name = "checkBoxGrass";
            checkBoxGrass.Size = new Size(87, 19);
            checkBoxGrass.TabIndex = 0;
            checkBoxGrass.Text = "Slime Block";
            checkBoxGrass.UseVisualStyleBackColor = false;
            // 
            // buttonConvertRGB
            // 
            buttonConvertRGB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonConvertRGB.Location = new Point(12, 359);
            buttonConvertRGB.Name = "buttonConvertRGB";
            buttonConvertRGB.Size = new Size(99, 23);
            buttonConvertRGB.TabIndex = 4;
            buttonConvertRGB.Text = "Convert RGB";
            buttonConvertRGB.UseVisualStyleBackColor = true;
            buttonConvertRGB.Click += buttonConvertRGB_Click;
            // 
            // buttonZoomIn
            // 
            buttonZoomIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonZoomIn.Location = new Point(12, 387);
            buttonZoomIn.Name = "buttonZoomIn";
            buttonZoomIn.Size = new Size(99, 23);
            buttonZoomIn.TabIndex = 5;
            buttonZoomIn.Text = "Zoom In";
            buttonZoomIn.UseVisualStyleBackColor = true;
            buttonZoomIn.Click += buttonZoomIn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(117, 387);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 6;
            button2.Text = "Zoom Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonZoomOut_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(117, 358);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 7;
            button1.Text = "Convert OKlab";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonConvertOKLab_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(117, 415);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 8;
            button3.Text = "Save Image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSave_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdit.Location = new Point(12, 330);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(204, 23);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit Palette";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(buttonZoomIn);
            Controls.Add(buttonConvertRGB);
            Controls.Add(groupBoxColors);
            Controls.Add(panelMap);
            Controls.Add(buttonLoad);
            Name = "Form1";
            Text = "Image Palette Converter";
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            groupBoxColors.ResumeLayout(false);
            panelColors.ResumeLayout(false);
            panelColors.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoad;
        private Panel panelMap;
        private PictureBox pictureBoxMap;
        private GroupBox groupBoxColors;
        private Panel panelColors;
        private CheckBox checkBoxGrass;
        private CheckBox checkBoxFire;
        private CheckBox checkBoxWool;
        private CheckBox checkBoxSand;
        private CheckBox checkBoxStone;
        private CheckBox checkBoxDirt;
        private CheckBox checkBoxClay;
        private CheckBox checkBoxSnow;
        private CheckBox checkBoxPlant;
        private CheckBox checkBoxMetal;
        private CheckBox checkBoxColorOrange;
        private CheckBox checkBoxQuartz;
        private CheckBox checkBoxWood;
        private CheckBox checkBoxWater;
        private CheckBox checkBoxColorLightBlue;
        private CheckBox checkBoxColorMagenta;
        private CheckBox checkBoxColorRed;
        private CheckBox checkBoxColorGreen;
        private CheckBox checkBoxColorBrown;
        private CheckBox checkBoxColorBlue;
        private CheckBox checkBoxColorPurple;
        private CheckBox checkBoxColorCyan;
        private CheckBox checkBoxColorLightGray;
        private CheckBox checkBoxColorGray;
        private CheckBox checkBoxColorPink;
        private CheckBox checkBoxColorLightGreen;
        private CheckBox checkBoxColorYellow;
        private CheckBox checkBoxTerracottaMagenta;
        private CheckBox checkBoxTerracottaOrange;
        private CheckBox checkBoxTerracottaWhite;
        private CheckBox checkBoxNether;
        private CheckBox checkBoxPodzol;
        private CheckBox checkBoxEmerald;
        private CheckBox checkBoxLapis;
        private CheckBox checkBoxDiamond;
        private CheckBox checkBoxGold;
        private CheckBox checkBoxColorBlack;
        private CheckBox checkBoxTerracottaLightBlue;
        private CheckBox checkBoxTerracottaPink;
        private CheckBox checkBoxTerracottaLightGreen;
        private CheckBox checkBoxTerracottaYellow;
        private CheckBox checkBoxTerracottaBlue;
        private CheckBox checkBoxTerracottaPurple;
        private CheckBox checkBoxTerracottaCyan;
        private CheckBox checkBoxTerracottaLightGray;
        private CheckBox checkBoxTerracottaGray;
        private CheckBox checkBoxCrimsonNylium;
        private CheckBox checkBoxTerracottaBlack;
        private CheckBox checkBoxTerracottaRed;
        private CheckBox checkBoxTerracottaGreen;
        private CheckBox checkBoxTerracottaBrown;
        private CheckBox checkBoxVerdantFroglight;
        private CheckBox checkBoxRawIron;
        private CheckBox checkBoxDeepslate;
        private CheckBox checkBoxWarpedWartBlock;
        private CheckBox checkBoxWarpedHyphae;
        private CheckBox checkBoxWarpedPlanks;
        private CheckBox checkBoxWarpedNylium;
        private CheckBox checkBoxCrimsonHyphae;
        private CheckBox checkBoxCrimsonStem;
        private Button buttonConvertRGB;
        private CheckBox checkBoxIce;
        private Button buttonZoomIn;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button buttonEdit;
    }
}
