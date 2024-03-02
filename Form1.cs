using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ARIL
{
    public partial class FormARIL : Form
    {
        private bool doDraw = false;
        private Point previousPoint;
        private Color penColor = Color.Black; // ���� ���� �� ���������
        private int penSize = 5; // ������ ���� �� ���������
        private List<Bitmap> undoStack = new List<Bitmap>();

        public FormARIL()
        {
            InitializeComponent();
        }

        #region ����������� �������

        // ���������� ������� ������� ������ ���� �� ������ ���������
        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doDraw = true;
                previousPoint = e.Location;
                SaveCurrentDrawing(); // ��������� ������� �������
            }
        }

        // ���������� ������� ���������� ������ ���� �� ������ ���������
        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doDraw = false;
            }
        }

        // ���������� ������� ����������� ���� �� ������ ���������
        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                DrawOnPanel(e.Location); // ���������� �� ������
            }
        }

        // ���������� ������� ����� �� ������ ������ ����� ����
        private void btnColorPen_Click(object sender, EventArgs e)
        {
            SetPenColor(); // ������ ���� ����
        }

        // ���������� ������� ��������� �������� �������� ������� ����
        private void trackBarPenSize_Scroll(object sender, EventArgs e)
        {
            UpdatePenSize(trackBarPenSize.Value); // �������� ������ ����
        }

        // ���������� ������� ��������� ������ � ��������� ���� ������� ����
        private void textBoxSizePen_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSizePen.Text, out int newSize))
            {
                UpdatePenSize(newSize); // �������� ������ ����
            }
        }

        // ���������� ������� ����� �� ������ ���� "������"
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoLastDrawing(); // �������� ��������� ��������
        }

        #endregion

        #region ��������������� ������

        private void DrawOnPanel(Point currentPoint)
        {
            using (Graphics g = panelDrawing.CreateGraphics())
            {
                using (SolidBrush brush = new SolidBrush(penColor))
                {
                    g.FillRectangle(brush, currentPoint.X, currentPoint.Y, penSize, penSize);
                    g.DrawLine(new Pen(brush, penSize), previousPoint, currentPoint);
                }
            }
            previousPoint = currentPoint;
        }

        private void SetPenColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    penColor = colorDialog.Color; // �������� ���� ����
                }
            }
        }

        private void UpdatePenSize(int newSize)
        {
            penSize = newSize; // �������� ������ ����
            textBoxSizePen.Text = penSize.ToString();
        }

        private void SaveCurrentDrawing()
        {
            Bitmap currentDrawing = new Bitmap(panelDrawing.Width, panelDrawing.Height);
            using (Graphics g = Graphics.FromImage(currentDrawing))
            {
                if (panelDrawing.BackgroundImage != null)
                {
                    g.DrawImage(panelDrawing.BackgroundImage, Point.Empty);
                }

                using (SolidBrush brush = new SolidBrush(penColor))
                {
                    g.FillRectangle(brush, previousPoint.X, previousPoint.Y, penSize, penSize);
                    g.DrawLine(new Pen(brush, penSize), previousPoint, previousPoint);
                }
            }
            undoStack.Add(currentDrawing); // �������� ������� ������� � ������ undoStack
        }

        // ����� ��� ������ ���������� �������
        private void UndoLastDrawing()
        {
            if (undoStack.Count > 0)
            {
                undoStack.RemoveAt(undoStack.Count - 1);
                panelDrawing.Refresh();

                using (var bmp = new Bitmap(panelDrawing.Width, panelDrawing.Height))
                {
                    using (var g = Graphics.FromImage(bmp))
                    {
                        foreach (var action in undoStack)
                        {
                            g.DrawImage(action, Point.Empty);
                        }
                    }

                    panelDrawing.BackgroundImage?.Dispose();
                    panelDrawing.BackgroundImage = (Bitmap)bmp.Clone();
                }
            }
        }

        #endregion

        private void panelDrawing_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                UndoLastDrawing();
            }
        }
    }
}
