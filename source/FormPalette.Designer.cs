namespace MapConverter
{
    partial class FormPalette
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            buttonLoad = new Button();
            buttonUse = new Button();
            buttonSave = new Button();
            groupPalette = new GroupBox();
            panelPalette = new Panel();
            panelNames = new Panel();
            panelColors = new Panel();
            panelRemove = new Panel();
            buttonCancel = new Button();
            groupPalette.SuspendLayout();
            panelPalette.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 386);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(52, 52);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add Color";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(70, 415);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(145, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load Palette";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonUse
            // 
            buttonUse.Location = new Point(70, 386);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(146, 23);
            buttonUse.TabIndex = 2;
            buttonUse.Text = "Use Palette";
            buttonUse.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(221, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(146, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save Palette";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupPalette
            // 
            groupPalette.Controls.Add(panelPalette);
            groupPalette.Location = new Point(12, 12);
            groupPalette.Name = "groupPalette";
            groupPalette.Size = new Size(355, 368);
            groupPalette.TabIndex = 4;
            groupPalette.TabStop = false;
            groupPalette.Text = "Palette";
            // 
            // panelPalette
            // 
            panelPalette.AutoScroll = true;
            panelPalette.Controls.Add(panelNames);
            panelPalette.Controls.Add(panelColors);
            panelPalette.Controls.Add(panelRemove);
            panelPalette.Location = new Point(6, 22);
            panelPalette.Name = "panelPalette";
            panelPalette.Size = new Size(343, 340);
            panelPalette.TabIndex = 1;
            // 
            // panelNames
            // 
            panelNames.Location = new Point(32, 3);
            panelNames.Name = "panelNames";
            panelNames.Size = new Size(202, 0);
            panelNames.TabIndex = 0;
            // 
            // panelColors
            // 
            panelColors.Location = new Point(240, 3);
            panelColors.Name = "panelColors";
            panelColors.Size = new Size(75, 0);
            panelColors.TabIndex = 2;
            // 
            // panelRemove
            // 
            panelRemove.Location = new Point(3, 3);
            panelRemove.Name = "panelRemove";
            panelRemove.Size = new Size(23, 0);
            panelRemove.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(221, 386);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(146, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPalette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(buttonCancel);
            Controls.Add(groupPalette);
            Controls.Add(buttonSave);
            Controls.Add(buttonUse);
            Controls.Add(buttonLoad);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPalette";
            Text = "Palette Editor";
            groupPalette.ResumeLayout(false);
            panelPalette.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPalette;
        private Button buttonAdd;
        private Button buttonLoad;
        private Button buttonUse;
        private Button buttonSave;
        private GroupBox groupPalette;
        private Panel panelRemove;
        private Panel panelNames;
        private Panel panelColors;
        private Button buttonCancel;
    }
}