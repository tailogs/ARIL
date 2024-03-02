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
        private Color penColor = Color.Black; // Цвет пера по умолчанию
        private int penSize = 5; // Размер пера по умолчанию
        private List<Bitmap> undoStack = new List<Bitmap>();

        public FormARIL()
        {
            InitializeComponent();
        }

        #region Обработчики событий

        // Обработчик события нажатия кнопки мыши на панели рисования
        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doDraw = true;
                previousPoint = e.Location;
                SaveCurrentDrawing(); // Сохранить текущий рисунок
            }
        }

        // Обработчик события отпускания кнопки мыши на панели рисования
        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doDraw = false;
            }
        }

        // Обработчик события перемещения мыши по панели рисования
        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                DrawOnPanel(e.Location); // Нарисовать на панели
            }
        }

        // Обработчик события клика на кнопке выбора цвета пера
        private void btnColorPen_Click(object sender, EventArgs e)
        {
            SetPenColor(); // Задать цвет пера
        }

        // Обработчик события изменения значения трекбара размера пера
        private void trackBarPenSize_Scroll(object sender, EventArgs e)
        {
            UpdatePenSize(trackBarPenSize.Value); // Обновить размер пера
        }

        // Обработчик события изменения текста в текстовом поле размера пера
        private void textBoxSizePen_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSizePen.Text, out int newSize))
            {
                UpdatePenSize(newSize); // Обновить размер пера
            }
        }

        // Обработчик события клика на пункте меню "Отмена"
        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoLastDrawing(); // Отменить последнее действие
        }

        #endregion

        #region Вспомогательные методы

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
                    penColor = colorDialog.Color; // Обновить цвет пера
                }
            }
        }

        private void UpdatePenSize(int newSize)
        {
            penSize = newSize; // Обновить размер пера
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
            undoStack.Add(currentDrawing); // Добавить текущий рисунок в список undoStack
        }

        // Метод для отмены последнего рисунка
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
