using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using mspaint.advance;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace mspaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList _undo = new ArrayList();
        private ArrayList _redo = new ArrayList();
        private ArrayList pages = new ArrayList();
        private Point _currentPoint;
        private Pen _pen = new Pen(Brushes.Black);
        private shape SelectorShape;

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList page = new ArrayList();
            pages.Add(page);
            HandleButtonsEnabled();
            panelDrawing.Cursor = new Cursor(GetType(), "Cursor1.cur");
        }

        #region Tool Box Widths Visible

        private void radioButtonToolBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFreeHand.Checked)
            {
                panelDrawing.Cursor = new Cursor(GetType(), "Cursor1.cur");
            }

            if (radioButtonLine.Checked)
            {
                panelDrawing.Cursor = Cursors.Cross;
            }

            if (radioButtonEraser.Checked || radioButtonSelector.Checked)
            {
                panelDrawing.Cursor = Cursors.Arrow;
            }

            SelectorShape = null;
            panelWidths.Visible = true;
            if (radioButtonText.Checked)
            {
                panelDrawing.Cursor = Cursors.IBeam;
                buttonFont.Visible = true;
                panelWidths.Visible = false;
            }
            else { buttonFont.Visible = false; }

            checkedWidthsVisible();

            if (textBoxContent.Visible)
            {
                shape s = handleText();
                addShape(s);
            }

            panelFilledOrNonFilled.Visible = false;
            if (radioButtonRectangle.Checked == true || radioButtonEllipse.Checked == true)
            {
                panelDrawing.Cursor = Cursors.Cross;
                HandleBackColorAndShape(panelFilled);
                HandleBackColorAndShape(panelNonFilled);
                panelNonFilled.Invalidate();
                panelFilled.Invalidate();
                panelFilledOrNonFilled.Visible = true;
            }
        }

        private void checkedWidthsVisible()
        {
            panelWidths.Visible = true;
            if (radioButtonSelector.Checked ||
                radioButtonEraser.Checked ||
                (radioButtonEllipse.Checked && panelFilled.BackColor == Color.Blue) ||
                (radioButtonRectangle.Checked && panelFilled.BackColor == Color.Blue))
            {
                panelWidths.Visible = false;
            }
        }

        #endregion Tool Box Widths Visible

        #region panel Drawing

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }

            if (radioButtonFreeHand.Checked)
            {
                return;
            }

            if (radioButtonText.Checked)
            {
                return;
            }

            if (radioButtonEraser.Checked)
            {
                return;
            }

            if (radioButtonSelector.Checked)
            {
                return;
            }

            ArrayList shapes = getPage();
            Graphics g = panelDrawing.CreateGraphics();
            Point p = new Point(e.X, e.Y);
            shape s = (shape)shapes[shapes.Count - 1];

            s.Update(g, p);
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }

            ArrayList shapes = getPage();
            Graphics g = panelDrawing.CreateGraphics();
            shape s = null;

            if (radioButtonSelector.Checked)
            {
                if (SelectorShape == null)
                {
                    return;
                }
                if (e.Button == MouseButtons.Left)
                {
                    Point delta = new Point();
                    delta.X = e.X - _currentPoint.X;
                    delta.Y = e.Y - _currentPoint.Y;
                    SelectorShape.Move(delta);
                    _currentPoint = new Point(e.X, e.Y);
                    panelDrawing.Invalidate();
                }
            }

            if (radioButtonFreeHand.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    s = (freeHand)shapes[shapes.Count - 1];
                    Point p = new Point(e.X, e.Y);
                    s.Update(g, p);
                }
            }

            //if (radioButtonLine.Checked)
            //{
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        s = (line)shapes[shapes.Count - 1];
            //        panelDrawing.Invalidate();
            //    }
            //}
        }

        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            #region handle _redo

            int CurrentPage = int.Parse(textBoxNumberPage.Text);
            for (int i = 0; i < _redo.Count; i++)
            {
                ArrayList al = (ArrayList)_redo[i];
                int page = (int)al[0];
                if (page == CurrentPage)
                {
                    _redo.RemoveAt(i);
                    i--;
                }
            }

            #endregion handle _redo

            if (e.Button == MouseButtons.Right)
            {
                return;
            }

            Point p = new Point(e.X, e.Y);
            shape s = null;

            #region Selector Eraser

            if (radioButtonSelector.Checked || radioButtonEraser.Checked)
            {
                ArrayList shapes = getPage();
                bool b;

                foreach (shape shp in shapes)
                {
                    b = shp.selector(p);
                    if (b)
                    {
                        #region

                        if (radioButtonEraser.Checked)
                        {
                            shapes.Remove(shp);
                            panelDrawing.Invalidate();
                        }

                        #endregion

                        #region selector

                        if (radioButtonSelector.Checked)
                        {
                            _currentPoint = new Point(e.X, e.Y);

                            SelectorShape = shp;
                            panelCurrentColor.BackColor = SelectorShape._Color;
                            _pen.Width = SelectorShape.Width;
                            panelWidth1.Invalidate();
                            panelWidth2.Invalidate();
                            panelWidth3.Invalidate();
                            panelWidth4.Invalidate();
                        }

                        #endregion selector

                        return;
                    }
                }

                b = false;
                SelectorShape = null;
            }

            #endregion Selector Eraser

            #region text

            if (radioButtonText.Checked)
            {
                if (textBoxContent.Visible)
                {
                    s = handleText();
                }

                textBoxContent.Visible = true;
                textBoxContent.Text = "";
                textBoxContent.Location = p;

                if (s == null)
                {
                    return;
                }
            }
            
            #endregion text

            #region FreeHand and Line

            if (radioButtonFreeHand.Checked)
            {
                s = new freeHand(_pen.Width, _pen.Color, p);
            }

            if (radioButtonLine.Checked)
            {
                s = new line(_pen.Width, _pen.Color, p);
            }

            #endregion FreeHand and Line

            #region Rectangle and Ellipse

            if (radioButtonRectangle.Checked)
            {
                bool isFill = panelFilled.BackColor == Color.Blue;
                s = new figure(figure.types.Rectangle, isFill, _pen.Width, _pen.Color, p);
            }

            if (radioButtonEllipse.Checked)
            {
                bool isFill = panelFilled.BackColor == Color.Blue;
                s = new figure(figure.types.Ellipse, isFill, _pen.Width, _pen.Color, p);
            }

            #endregion Rectangle and Ellipse

            if (s == null)
            {
                return;
            }
            addShape(s);
        }

        private ArrayList getPage()
        {
            int page = int.Parse(textBoxNumberPage.Text);
            ArrayList shapes = (ArrayList)pages[page - 1];
            return shapes;
        }

        private void addShape(shape s)
        {
            ArrayList shapes = getPage();
            shapes.Add(s);
            int page = int.Parse(textBoxNumberPage.Text);
            ArrayList al = new ArrayList();
            al.Add(page);
            al.Add(s);
            _undo.Insert(0, al);
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            ArrayList shapes = getPage();
            Graphics g = e.Graphics;

            try
            {
                foreach (shape s in shapes)
                {
                    s.Draw(g);
                }
            }

            catch (Exception ex)
            {
            }
            #region ליפני ה class יש לשנות עם יש טעיות
            //try /////           
            //{
            //    int page = int.Parse(textBoxNumberPage.Text);
            //    ArrayList lines = (ArrayList)pages[page - 1];
            //    foreach (ArrayList line in lines)
            //    {
            //        for (int i = 0; i < line.Count - 1; i++)
            //        {
            //            ArrayList varibel1 = (ArrayList)line[i];
            //            Point p1 = (Point)varibel1[0];
            //            Pen pen1 = (Pen)varibel1[1];

            //            ArrayList varibel2 = (ArrayList)line[i + 1];
            //            Point p2 = (Point)varibel2[0];

            //            e.Graphics.DrawLine(pen1, p1, p2);
            //        }
            //    }
            //}
            //catch (Exception)
            //{ }
            #endregion ליפני ה class יש לשנות עם יש טעיות
        }

        #region text

        private shape handleText()
        {
            string str = textBoxContent.Text;
            Point point = new Point(textBoxContent.Location.X, textBoxContent.Location.Y);
            shape s = new text(textBoxContent.Font, str, _pen.Width, _pen.Color, point);
            Graphics g = panelDrawing.CreateGraphics();
            Point p = new Point(0, 0);
            s.Update(g, p);
            textBoxContent.Visible = false;
            return s;
        }

        private void textBoxFont_VisibleChanged(object sender, EventArgs e)
        {
            textBoxContent.Focus();
        }

        private void panelCurrentColor_BackColorChanged(object sender, EventArgs e)
        {
            Color c = panelCurrentColor.BackColor;

            _pen.Color = c;

            textBoxContent.ForeColor = c;

            if (SelectorShape != null)
            {
                SelectorShape._Color = c;
                panelDrawing.Invalidate();
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBoxContent.Font = fontDialog1.Font;
                textBoxContent.Focus();
            }
        }

        #endregion text

        #endregion panel Drawing

        #region pages Buttons

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int page = int.Parse(textBoxNumberPage.Text) + 1;
            int numberOfPages = pages.Count;

            textBoxNumberPage.Text = page.ToString();
            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            int page = int.Parse(textBoxNumberPage.Text);

            page = page - 1;
            textBoxNumberPage.Text = page.ToString();

            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            int count = pages.Count;
            textBoxNumberPage.Text = count.ToString();
            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            textBoxNumberPage.Text = "1";
            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            int page = int.Parse(textBoxNumberPage.Text);

            if (page == pages.Count)
            {
                textBoxNumberPage.Text = (page - 1).ToString();
            }
            pages.RemoveRange(page - 1, 1);
            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int numberOfPages = pages.Count + 1;
            textBoxNumberPage.Text = numberOfPages.ToString();

            ArrayList newPage = new ArrayList();
            pages.Add(newPage);

            HandleButtonsEnabled();
            panelDrawing.Invalidate();
        }

        private void buttonCleer_Click(object sender, EventArgs e)
        {
            SelectorShape = null;
            ArrayList lines = getPage();
            lines.RemoveRange(0, lines.Count);
            panelDrawing.Invalidate();
        }

        private void HandleButtonsEnabled()
        {
            SelectorShape = null;
            textBoxContent.Visible = false;

            int page = int.Parse(textBoxNumberPage.Text);

            bool last = page == pages.Count;
            buttonNext.Enabled = !last;
            buttonLast.Enabled = !last;

            bool first = page == 1;
            buttonPrev.Enabled = !first;
            buttonFirst.Enabled = !first;

            bool onlyOnePage = pages.Count == 1;
            buttonDelete.Enabled = !onlyOnePage;
        }

        #endregion pages Buttons

        #region panel color

        private void HandleSelectoeShapeColor(Color c)
        {
            if (SelectorShape != null)
            {
                SelectorShape._Color = c;
                Color ccc = SelectorShape._Color;
            }
        }

        private void panelRed_MouseClick(object sender, MouseEventArgs e)
        {
            HandleSelectoeShapeColor(panelRed.BackColor);

            panelCurrentColor.BackColor = panelRed.BackColor;
        }

        private void panelBlue_MouseClick(object sender, MouseEventArgs e)
        {
            HandleSelectoeShapeColor(panelBlue.BackColor);

            panelCurrentColor.BackColor = panelBlue.BackColor;
        }

        private void panelBlack_MouseClick(object sender, MouseEventArgs e)
        {
            HandleSelectoeShapeColor(panelBlack.BackColor);

            panelCurrentColor.BackColor = panelBlack.BackColor;
        }

        private void panelYellow_MouseClick(object sender, MouseEventArgs e)
        {
            HandleSelectoeShapeColor(panelYellow.BackColor);

            panelCurrentColor.BackColor = panelYellow.BackColor;
        }

        #endregion panel color

        #region panel of Widths

        private void HandleSizeOfLine(Panel p, Graphics g)
        {
            string h = (string)p.Tag;
            int height = int.Parse(h);
            Brush fg;
            if (_pen.Width == height)
            {
                p.BackColor = Color.Blue;
                fg = Brushes.White;
            }

            else
            {
                p.BackColor = Color.Empty;
                fg = Brushes.Black;
            }

            int x = 3;
            int y = (p.Height - height) / 2;
            int w = p.Width - x * 2;
            Rectangle rec = new Rectangle(x, y, w, height);
            g.FillRectangle(fg, rec);
        }

        private void panelWidth1_Paint(object sender, PaintEventArgs e)
        {
            HandleSizeOfLine(panelWidth1, e.Graphics);
        }

        private void panelWidth2_Paint(object sender, PaintEventArgs e)
        {
            HandleSizeOfLine(panelWidth2, e.Graphics);
        }

        private void panelWidth3_Paint(object sender, PaintEventArgs e)
        {
            HandleSizeOfLine(panelWidth3, e.Graphics);
        }

        private void panelWidth4_Paint(object sender, PaintEventArgs e)
        {
            HandleSizeOfLine(panelWidth4, e.Graphics);
        }

        private void changeWidthSelector(float f)
        {
            if (SelectorShape != null)
            {
                SelectorShape.Width = f;
                panelDrawing.Invalidate();
                return;
            }
        }

        private void panelWidth1_MouseClick(object sender, MouseEventArgs e)
        {
            float height = float.Parse((string)panelWidth1.Tag);

            changeWidthSelector(height);

            _pen.Width = height;
            InvalidatePanelWidths();
        }

        private void panelWidth2_MouseClick(object sender, MouseEventArgs e)
        {
            float height = float.Parse((string)panelWidth2.Tag);

            changeWidthSelector(height);

            _pen.Width = height;
            InvalidatePanelWidths();
        }

        private void panelWidth3_MouseClick(object sender, MouseEventArgs e)
        {
            float height = float.Parse((string)panelWidth3.Tag);
            changeWidthSelector(height);

            _pen.Width = height;
            InvalidatePanelWidths();
        }

        private void panelWidth4_MouseClick(object sender, MouseEventArgs e)
        {
            float height = float.Parse((string)panelWidth4.Tag);

            changeWidthSelector(height);

            _pen.Width = height;
            InvalidatePanelWidths();
        }

        private void InvalidatePanelWidths()
        {
            panelWidth1.Invalidate();
            panelWidth2.Invalidate();
            panelWidth3.Invalidate();
            panelWidth4.Invalidate();
        }

        #endregion panel of Widths

        #region panel Or Filled Non Filled

        private void HandleBackColorAndShape(Panel p)
        {
            Graphics g = p.CreateGraphics();
            int x = 6;
            int y = 6;
            int height = panelNonFilled.Size.Height - y * 2;
            int width = panelNonFilled.Size.Width - x * 2;
            Pen pen = new Pen(Brushes.Black);

            if (p.BackColor == Color.Blue)
            {
                pen.Brush = Brushes.White;
            }

            if ((string)p.Tag == "NonFilled")
            {
                if (radioButtonEllipse.Checked)
                {
                    g.DrawEllipse(pen, x, y, width, height);
                    return;
                }
                g.DrawRectangle(pen, x, y, width, height);
            }
            if ((string)p.Tag == "Filled")
            {
                pen.Brush = Brushes.Black;
                if (radioButtonEllipse.Checked)
                {
                    g.FillEllipse(pen.Brush, x, y, width, height);
                    return;
                }
                g.FillRectangle(pen.Brush, x, y, width, height);
            }
        }

        private void paneNonFilled_Paint(object sender, PaintEventArgs e)
        {
            HandleBackColorAndShape(panelNonFilled);
        }

        private void panelFilled_Paint(object sender, PaintEventArgs e)
        {
            HandleBackColorAndShape(panelFilled);
        }

        private void panelFilled_MouseDown(object sender, MouseEventArgs e)
        {
            panelFilled.BackColor = Color.Blue;
            panelNonFilled.BackColor = Color.Empty;

            checkedWidthsVisible();
            HandleBackColorAndShape(panelFilled);
        }

        private void panelNonFilled_MouseDown(object sender, MouseEventArgs e)
        {
            panelFilled.BackColor = Color.Empty;
            panelNonFilled.BackColor = Color.Blue;
            checkedWidthsVisible();

            HandleBackColorAndShape(panelNonFilled);
        }

        #endregion panel Or Filled Non Filled

        #region menuStrip & Right Menu

        private void frontOrBackward(bool front)
        {
            ArrayList shapes = getPage();

            if (SelectorShape != null)
            {
                shapes.Remove(SelectorShape);
                int i = front == true ? shapes.Count : 0;
                shapes.Insert(i, SelectorShape);
                panelDrawing.Invalidate();
            }
        }

        private void upOrDown(bool front)
        {
            ArrayList shapes = getPage();

            if (SelectorShape != null)
            {
                int currentIndex = shapes.IndexOf(SelectorShape);

                int i = front == true ? 1 : -1;
                if (currentIndex == shapes.Count - 1 && i == 1)
                {
                    return;
                }
                if (currentIndex == 0 && i == -1)
                {
                    return;
                }
                shapes.Remove(SelectorShape);
                shapes.Insert(currentIndex + i, SelectorShape);
                panelDrawing.Invalidate();
            }
        }

        private void bringToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frontOrBackward(true);
        }

        private void bringToBackwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frontOrBackward(false);
        }

        private void bringForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upOrDown(true);
        }

        private void bringBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upOrDown(false);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            editToolStripMenuItem1.Enabled = true;
            if (SelectorShape == null)
            {
                editToolStripMenuItem1.Enabled = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, pages);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = openFileDialog1.FileName;

            #region confirm load

            ArrayList pageOne = (ArrayList)pages[0];
            if (pageOne.Count != 0 && pages.Count == 1)
            {
                string message = "Are you sure you want to load? All the unsave detail will deleted";
                string caption = "Pinter";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            #endregion confirm load

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                SoapFormatter sf = new SoapFormatter();
                object o = sf.Deserialize(fs);
                pages = (ArrayList)o;
                HandleButtonsEnabled();
                panelDrawing.Invalidate();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(textBoxNumberPage.Text);
            ArrayList shapes = getPage();
            foreach (ArrayList al in _undo)
            {
                int page = (int)al[0];
                shape s = (shape)al[1];
                if (page == currentPage)
                {
                    shapes.Remove(s);
                    _undo.Remove(al);
                    _redo.Insert(0, al);
                    panelDrawing.Invalidate();
                    return;
                }
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentPage = int.Parse(textBoxNumberPage.Text);
            ArrayList shapes = getPage();
            foreach (ArrayList al in _redo)
            {
                int page = (int)al[0];
                shape s = (shape)al[1];
                if (page == currentPage)
                {
                    shapes.Add(s);
                    _redo.Remove(al);
                    _undo.Insert(0, al);
                    panelDrawing.Invalidate();
                    return;
                }
            }
        }

        #endregion menuStrip & Right Menu
    }
}