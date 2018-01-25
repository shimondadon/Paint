namespace mspaint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bringUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToBackwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bringBackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxNumberPage = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonCleer = new System.Windows.Forms.Button();
            this.panelAdvance = new System.Windows.Forms.Panel();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.radioButtonSelector = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.panelFilledOrNonFilled = new System.Windows.Forms.Panel();
            this.panelFilled = new System.Windows.Forms.Panel();
            this.panelNonFilled = new System.Windows.Forms.Panel();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonFreeHand = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.panelWidths = new System.Windows.Forms.Panel();
            this.panelWidth4 = new System.Windows.Forms.Panel();
            this.panelWidth3 = new System.Windows.Forms.Panel();
            this.panelWidth2 = new System.Windows.Forms.Panel();
            this.panelWidth1 = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelCurrentColor = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelDrawing.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelAdvance.SuspendLayout();
            this.panelFilledOrNonFilled.SuspendLayout();
            this.panelWidths.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Location = new System.Drawing.Point(126, 463);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "&Delete Page";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeleted_Click);
            // 
            // panelDrawing
            // 
            this.panelDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDrawing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDrawing.ContextMenuStrip = this.contextMenuStrip1;
            this.panelDrawing.Controls.Add(this.textBoxContent);
            this.panelDrawing.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDrawing.Location = new System.Drawing.Point(71, 71);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(664, 376);
            this.panelDrawing.TabIndex = 4;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseMove);
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseDown);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bringToFrontToolStripMenuItem1,
            this.bringUpToolStripMenuItem1,
            this.bringToBackwardToolStripMenuItem1,
            this.bringBackToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // bringToFrontToolStripMenuItem1
            // 
            this.bringToFrontToolStripMenuItem1.Name = "bringToFrontToolStripMenuItem1";
            this.bringToFrontToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.bringToFrontToolStripMenuItem1.Text = "&Bring to front";
            this.bringToFrontToolStripMenuItem1.Click += new System.EventHandler(this.bringToFrontToolStripMenuItem_Click);
            // 
            // bringUpToolStripMenuItem1
            // 
            this.bringUpToolStripMenuItem1.Name = "bringUpToolStripMenuItem1";
            this.bringUpToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.bringUpToolStripMenuItem1.Text = "Bring up";
            this.bringUpToolStripMenuItem1.Click += new System.EventHandler(this.bringForwardToolStripMenuItem_Click);
            // 
            // bringToBackwardToolStripMenuItem1
            // 
            this.bringToBackwardToolStripMenuItem1.Name = "bringToBackwardToolStripMenuItem1";
            this.bringToBackwardToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.bringToBackwardToolStripMenuItem1.Text = "Bring to backward";
            this.bringToBackwardToolStripMenuItem1.Click += new System.EventHandler(this.bringToBackwardToolStripMenuItem_Click);
            // 
            // bringBackToolStripMenuItem1
            // 
            this.bringBackToolStripMenuItem1.Name = "bringBackToolStripMenuItem1";
            this.bringBackToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.bringBackToolStripMenuItem1.Text = "Bring Back";
            this.bringBackToolStripMenuItem1.Click += new System.EventHandler(this.bringBackToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(554, 3);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(103, 24);
            this.textBoxContent.TabIndex = 11;
            this.textBoxContent.Visible = false;
            this.textBoxContent.VisibleChanged += new System.EventHandler(this.textBoxFont_VisibleChanged);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLast.Location = new System.Drawing.Point(522, 463);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 5;
            this.buttonLast.Text = ">>|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFirst.Location = new System.Drawing.Point(210, 463);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 6;
            this.buttonFirst.Text = "|<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.Location = new System.Drawing.Point(291, 463);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.Location = new System.Drawing.Point(441, 463);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxNumberPage
            // 
            this.textBoxNumberPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNumberPage.Location = new System.Drawing.Point(372, 466);
            this.textBoxNumberPage.Name = "textBoxNumberPage";
            this.textBoxNumberPage.ReadOnly = true;
            this.textBoxNumberPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNumberPage.Size = new System.Drawing.Size(63, 20);
            this.textBoxNumberPage.TabIndex = 9;
            this.textBoxNumberPage.Text = "1";
            this.textBoxNumberPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(603, 464);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(366, 450);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(69, 13);
            this.labelCurrentPage.TabIndex = 11;
            this.labelCurrentPage.Text = "Current Page";
            // 
            // buttonCleer
            // 
            this.buttonCleer.Location = new System.Drawing.Point(277, 27);
            this.buttonCleer.Name = "buttonCleer";
            this.buttonCleer.Size = new System.Drawing.Size(75, 23);
            this.buttonCleer.TabIndex = 0;
            this.buttonCleer.Text = "&Cleer";
            this.buttonCleer.UseVisualStyleBackColor = true;
            this.buttonCleer.Click += new System.EventHandler(this.buttonCleer_Click);
            // 
            // panelAdvance
            // 
            this.panelAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAdvance.Controls.Add(this.radioButtonEraser);
            this.panelAdvance.Controls.Add(this.radioButtonSelector);
            this.panelAdvance.Controls.Add(this.radioButtonText);
            this.panelAdvance.Controls.Add(this.radioButtonEllipse);
            this.panelAdvance.Controls.Add(this.panelFilledOrNonFilled);
            this.panelAdvance.Controls.Add(this.radioButtonRectangle);
            this.panelAdvance.Controls.Add(this.radioButtonFreeHand);
            this.panelAdvance.Controls.Add(this.radioButtonLine);
            this.panelAdvance.Controls.Add(this.panelWidths);
            this.panelAdvance.Location = new System.Drawing.Point(2, 71);
            this.panelAdvance.Margin = new System.Windows.Forms.Padding(1);
            this.panelAdvance.Name = "panelAdvance";
            this.panelAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.panelAdvance.Size = new System.Drawing.Size(63, 376);
            this.panelAdvance.TabIndex = 12;
            // 
            // radioButtonEraser
            // 
            this.radioButtonEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonEraser.Location = new System.Drawing.Point(34, 35);
            this.radioButtonEraser.Name = "radioButtonEraser";
            this.radioButtonEraser.Size = new System.Drawing.Size(26, 26);
            this.radioButtonEraser.TabIndex = 12;
            this.radioButtonEraser.Text = "E";
            this.toolTip1.SetToolTip(this.radioButtonEraser, "Eraser");
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelector
            // 
            this.radioButtonSelector.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonSelector.Location = new System.Drawing.Point(34, 3);
            this.radioButtonSelector.Name = "radioButtonSelector";
            this.radioButtonSelector.Size = new System.Drawing.Size(26, 26);
            this.radioButtonSelector.TabIndex = 11;
            this.radioButtonSelector.Text = "S";
            this.toolTip1.SetToolTip(this.radioButtonSelector, "Selector");
            this.radioButtonSelector.UseVisualStyleBackColor = true;
            this.radioButtonSelector.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // radioButtonText
            // 
            this.radioButtonText.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonText.BackgroundImage = global::mspaint.Properties.Resources.text;
            this.radioButtonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonText.Location = new System.Drawing.Point(6, 99);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(26, 26);
            this.radioButtonText.TabIndex = 10;
            this.toolTip1.SetToolTip(this.radioButtonText, "Text");
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEllipse.BackgroundImage = global::mspaint.Properties.Resources.ellipse;
            this.radioButtonEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonEllipse.Location = new System.Drawing.Point(34, 67);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(26, 26);
            this.radioButtonEllipse.TabIndex = 9;
            this.toolTip1.SetToolTip(this.radioButtonEllipse, "Ellipse");
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // panelFilledOrNonFilled
            // 
            this.panelFilledOrNonFilled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilledOrNonFilled.Controls.Add(this.panelFilled);
            this.panelFilledOrNonFilled.Controls.Add(this.panelNonFilled);
            this.panelFilledOrNonFilled.Location = new System.Drawing.Point(5, 171);
            this.panelFilledOrNonFilled.Name = "panelFilledOrNonFilled";
            this.panelFilledOrNonFilled.Size = new System.Drawing.Size(52, 56);
            this.panelFilledOrNonFilled.TabIndex = 8;
            this.panelFilledOrNonFilled.Visible = false;
            // 
            // panelFilled
            // 
            this.panelFilled.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFilled.Location = new System.Drawing.Point(0, 26);
            this.panelFilled.Name = "panelFilled";
            this.panelFilled.Size = new System.Drawing.Size(50, 28);
            this.panelFilled.TabIndex = 10;
            this.panelFilled.Tag = "Filled";
            this.panelFilled.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFilled_Paint);
            this.panelFilled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFilled_MouseDown);
            // 
            // panelNonFilled
            // 
            this.panelNonFilled.BackColor = System.Drawing.Color.Blue;
            this.panelNonFilled.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNonFilled.Location = new System.Drawing.Point(0, 0);
            this.panelNonFilled.Name = "panelNonFilled";
            this.panelNonFilled.Size = new System.Drawing.Size(50, 25);
            this.panelNonFilled.TabIndex = 9;
            this.panelNonFilled.Tag = "NonFilled";
            this.panelNonFilled.Paint += new System.Windows.Forms.PaintEventHandler(this.paneNonFilled_Paint);
            this.panelNonFilled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNonFilled_MouseDown);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRectangle.BackgroundImage = global::mspaint.Properties.Resources.Rectangle;
            this.radioButtonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonRectangle.Location = new System.Drawing.Point(6, 67);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(26, 26);
            this.radioButtonRectangle.TabIndex = 7;
            this.toolTip1.SetToolTip(this.radioButtonRectangle, "Rectangle");
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // radioButtonFreeHand
            // 
            this.radioButtonFreeHand.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFreeHand.BackgroundImage = global::mspaint.Properties.Resources.pen;
            this.radioButtonFreeHand.Checked = true;
            this.radioButtonFreeHand.Location = new System.Drawing.Point(6, 3);
            this.radioButtonFreeHand.Name = "radioButtonFreeHand";
            this.radioButtonFreeHand.Size = new System.Drawing.Size(26, 26);
            this.radioButtonFreeHand.TabIndex = 6;
            this.radioButtonFreeHand.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonFreeHand, "Free Hand");
            this.radioButtonFreeHand.UseVisualStyleBackColor = true;
            this.radioButtonFreeHand.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLine.BackgroundImage = global::mspaint.Properties.Resources.line;
            this.radioButtonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonLine.Location = new System.Drawing.Point(6, 35);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(26, 26);
            this.radioButtonLine.TabIndex = 4;
            this.toolTip1.SetToolTip(this.radioButtonLine, "Line");
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonToolBox_CheckedChanged);
            // 
            // panelWidths
            // 
            this.panelWidths.AutoSize = true;
            this.panelWidths.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWidths.Controls.Add(this.panelWidth4);
            this.panelWidths.Controls.Add(this.panelWidth3);
            this.panelWidths.Controls.Add(this.panelWidth2);
            this.panelWidths.Controls.Add(this.panelWidth1);
            this.panelWidths.Location = new System.Drawing.Point(5, 291);
            this.panelWidths.Name = "panelWidths";
            this.panelWidths.Size = new System.Drawing.Size(53, 72);
            this.panelWidths.TabIndex = 0;
            // 
            // panelWidth4
            // 
            this.panelWidth4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth4.Location = new System.Drawing.Point(0, 51);
            this.panelWidth4.Name = "panelWidth4";
            this.panelWidth4.Size = new System.Drawing.Size(49, 17);
            this.panelWidth4.TabIndex = 3;
            this.panelWidth4.Tag = "7";
            this.panelWidth4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth4_Paint);
            this.panelWidth4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelWidth4_MouseClick);
            // 
            // panelWidth3
            // 
            this.panelWidth3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth3.Location = new System.Drawing.Point(0, 34);
            this.panelWidth3.Name = "panelWidth3";
            this.panelWidth3.Size = new System.Drawing.Size(49, 17);
            this.panelWidth3.TabIndex = 2;
            this.panelWidth3.Tag = "5";
            this.panelWidth3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth3_Paint);
            this.panelWidth3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelWidth3_MouseClick);
            // 
            // panelWidth2
            // 
            this.panelWidth2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth2.Location = new System.Drawing.Point(0, 17);
            this.panelWidth2.Name = "panelWidth2";
            this.panelWidth2.Size = new System.Drawing.Size(49, 17);
            this.panelWidth2.TabIndex = 1;
            this.panelWidth2.Tag = "3";
            this.panelWidth2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth2_Paint);
            this.panelWidth2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelWidth2_MouseClick);
            // 
            // panelWidth1
            // 
            this.panelWidth1.BackColor = System.Drawing.SystemColors.Control;
            this.panelWidth1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth1.Location = new System.Drawing.Point(0, 0);
            this.panelWidth1.Name = "panelWidth1";
            this.panelWidth1.Size = new System.Drawing.Size(49, 17);
            this.panelWidth1.TabIndex = 0;
            this.panelWidth1.Tag = "1";
            this.panelWidth1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth1_Paint);
            this.panelWidth1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelWidth1_MouseClick);
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Location = new System.Drawing.Point(71, 27);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(200, 34);
            this.panelColor.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelYellow.Location = new System.Drawing.Point(72, 3);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(17, 16);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelYellow_MouseClick);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBlue.Location = new System.Drawing.Point(26, 3);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(17, 16);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBlue_MouseClick);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBlack.Location = new System.Drawing.Point(3, 3);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(17, 16);
            this.panelBlack.TabIndex = 1;
            this.panelBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBlack_MouseClick);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRed.Location = new System.Drawing.Point(49, 3);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(17, 16);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseClick);
            // 
            // panelCurrentColor
            // 
            this.panelCurrentColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCurrentColor.Location = new System.Drawing.Point(34, 27);
            this.panelCurrentColor.Name = "panelCurrentColor";
            this.panelCurrentColor.Size = new System.Drawing.Size(31, 34);
            this.panelCurrentColor.TabIndex = 0;
            this.panelCurrentColor.BackColorChanged += new System.EventHandler(this.panelCurrentColor_BackColorChanged);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(358, 27);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 13;
            this.buttonFont.Text = "&Font";
            this.toolTip1.SetToolTip(this.buttonFont, "Checked Font..");
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Visible = false;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fillToolStripMenuItem.Text = "&File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bringToFrontToolStripMenuItem,
            this.bringForwardToolStripMenuItem,
            this.bringToBackwardToolStripMenuItem,
            this.bringBackToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // bringToFrontToolStripMenuItem
            // 
            this.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem";
            this.bringToFrontToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bringToFrontToolStripMenuItem.Text = "&Bring to front";
            this.bringToFrontToolStripMenuItem.Click += new System.EventHandler(this.bringToFrontToolStripMenuItem_Click);
            // 
            // bringForwardToolStripMenuItem
            // 
            this.bringForwardToolStripMenuItem.Name = "bringForwardToolStripMenuItem";
            this.bringForwardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bringForwardToolStripMenuItem.Text = "Bring forward";
            this.bringForwardToolStripMenuItem.Click += new System.EventHandler(this.bringForwardToolStripMenuItem_Click);
            // 
            // bringToBackwardToolStripMenuItem
            // 
            this.bringToBackwardToolStripMenuItem.Name = "bringToBackwardToolStripMenuItem";
            this.bringToBackwardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bringToBackwardToolStripMenuItem.Text = "Bring to backward";
            this.bringToBackwardToolStripMenuItem.Click += new System.EventHandler(this.bringToBackwardToolStripMenuItem_Click);
            // 
            // bringBackToolStripMenuItem
            // 
            this.bringBackToolStripMenuItem.Name = "bringBackToolStripMenuItem";
            this.bringBackToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bringBackToolStripMenuItem.Text = "Bring back";
            this.bringBackToolStripMenuItem.Click += new System.EventHandler(this.bringBackToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.panelCurrentColor);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelAdvance);
            this.Controls.Add(this.buttonCleer);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNumberPage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 478);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDrawing.ResumeLayout(false);
            this.panelDrawing.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelAdvance.ResumeLayout(false);
            this.panelAdvance.PerformLayout();
            this.panelFilledOrNonFilled.ResumeLayout(false);
            this.panelWidths.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxNumberPage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Button buttonCleer;
        private System.Windows.Forms.Panel panelAdvance;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelCurrentColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelWidths;
        private System.Windows.Forms.Panel panelWidth4;
        private System.Windows.Forms.Panel panelWidth3;
        private System.Windows.Forms.Panel panelWidth2;
        private System.Windows.Forms.Panel panelWidth1;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonFreeHand;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.Panel panelFilledOrNonFilled;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.Panel panelFilled;
        private System.Windows.Forms.Panel panelNonFilled;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.RadioButton radioButtonSelector;
        private System.Windows.Forms.RadioButton radioButtonEraser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToBackwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringBackToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bringUpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bringToBackwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bringBackToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
    }
}

