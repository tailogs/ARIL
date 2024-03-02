namespace ARIL
{
    partial class FormARIL
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
            panelDrawing=new Panel();
            menuStrip1=new MenuStrip();
            файлToolStripMenuItem=new ToolStripMenuItem();
            создатьToolStripMenuItem=new ToolStripMenuItem();
            открытьToolStripMenuItem=new ToolStripMenuItem();
            сохранитьToolStripMenuItem=new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem=new ToolStripMenuItem();
            экспортToolStripMenuItem=new ToolStripMenuItem();
            закрытьToolStripMenuItem=new ToolStripMenuItem();
            выходToolStripMenuItem=new ToolStripMenuItem();
            редактированиеToolStripMenuItem=new ToolStripMenuItem();
            отменаToolStripMenuItem=new ToolStripMenuItem();
            повторениеToolStripMenuItem=new ToolStripMenuItem();
            вырезатьToolStripMenuItem=new ToolStripMenuItem();
            копироватьToolStripMenuItem=new ToolStripMenuItem();
            вставитьToolStripMenuItem=new ToolStripMenuItem();
            копироватьВсеToolStripMenuItem=new ToolStripMenuItem();
            справкаToolStripMenuItem=new ToolStripMenuItem();
            оПрограммеToolStripMenuItem=new ToolStripMenuItem();
            оРазрабToolStripMenuItem=new ToolStripMenuItem();
            colorDialog1=new ColorDialog();
            btnColorPen=new Button();
            trackBarPenSize=new TrackBar();
            lblPenSize=new Label();
            textBoxSizePen=new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPenSize).BeginInit();
            SuspendLayout();
            // 
            // panelDrawing
            // 
            panelDrawing.BackColor=Color.White;
            panelDrawing.Location=new Point(192, 39);
            panelDrawing.Name="panelDrawing";
            panelDrawing.Size=new Size(700, 400);
            panelDrawing.TabIndex=0;
            panelDrawing.MouseDown+=panelDrawing_MouseDown;
            panelDrawing.MouseMove+=panelDrawing_MouseMove;
            panelDrawing.MouseUp+=panelDrawing_MouseUp;
            panelDrawing.PreviewKeyDown+=panelDrawing_PreviewKeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редактированиеToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(904, 24);
            menuStrip1.TabIndex=1;
            menuStrip1.Text="menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, экспортToolStripMenuItem, закрытьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name="файлToolStripMenuItem";
            файлToolStripMenuItem.Size=new Size(48, 20);
            файлToolStripMenuItem.Text="Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name="создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size=new Size(154, 22);
            создатьToolStripMenuItem.Text="Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name="открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size=new Size(154, 22);
            открытьToolStripMenuItem.Text="Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name="сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size=new Size(154, 22);
            сохранитьToolStripMenuItem.Text="Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name="сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size=new Size(154, 22);
            сохранитьКакToolStripMenuItem.Text="Сохранить как";
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name="экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size=new Size(154, 22);
            экспортToolStripMenuItem.Text="Экспорт";
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name="закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size=new Size(154, 22);
            закрытьToolStripMenuItem.Text="Закрыть";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name="выходToolStripMenuItem";
            выходToolStripMenuItem.Size=new Size(154, 22);
            выходToolStripMenuItem.Text="Выход";
            // 
            // редактированиеToolStripMenuItem
            // 
            редактированиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменаToolStripMenuItem, повторениеToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, копироватьВсеToolStripMenuItem });
            редактированиеToolStripMenuItem.Name="редактированиеToolStripMenuItem";
            редактированиеToolStripMenuItem.Size=new Size(108, 20);
            редактированиеToolStripMenuItem.Text="Редактирование";
            // 
            // отменаToolStripMenuItem
            // 
            отменаToolStripMenuItem.Name="отменаToolStripMenuItem";
            отменаToolStripMenuItem.Size=new Size(180, 22);
            отменаToolStripMenuItem.Text="Отмена";
            отменаToolStripMenuItem.Click+=отменаToolStripMenuItem_Click;
            // 
            // повторениеToolStripMenuItem
            // 
            повторениеToolStripMenuItem.Name="повторениеToolStripMenuItem";
            повторениеToolStripMenuItem.Size=new Size(180, 22);
            повторениеToolStripMenuItem.Text="Повторение";
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name="вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size=new Size(180, 22);
            вырезатьToolStripMenuItem.Text="Вырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name="копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size=new Size(180, 22);
            копироватьToolStripMenuItem.Text="Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name="вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size=new Size(180, 22);
            вставитьToolStripMenuItem.Text="Вставить";
            // 
            // копироватьВсеToolStripMenuItem
            // 
            копироватьВсеToolStripMenuItem.Name="копироватьВсеToolStripMenuItem";
            копироватьВсеToolStripMenuItem.Size=new Size(180, 22);
            копироватьВсеToolStripMenuItem.Text="Копировать все";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, оРазрабToolStripMenuItem });
            справкаToolStripMenuItem.Name="справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size=new Size(65, 20);
            справкаToolStripMenuItem.Text="Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name="оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size=new Size(162, 22);
            оПрограммеToolStripMenuItem.Text="О программе";
            // 
            // оРазрабToolStripMenuItem
            // 
            оРазрабToolStripMenuItem.Name="оРазрабToolStripMenuItem";
            оРазрабToolStripMenuItem.Size=new Size(162, 22);
            оРазрабToolStripMenuItem.Text="О разработчике";
            // 
            // btnColorPen
            // 
            btnColorPen.BackColor=Color.Black;
            btnColorPen.FlatStyle=FlatStyle.Flat;
            btnColorPen.Location=new Point(12, 39);
            btnColorPen.Name="btnColorPen";
            btnColorPen.Size=new Size(174, 39);
            btnColorPen.TabIndex=0;
            btnColorPen.UseVisualStyleBackColor=false;
            btnColorPen.Click+=btnColorPen_Click;
            // 
            // trackBarPenSize
            // 
            trackBarPenSize.Location=new Point(12, 99);
            trackBarPenSize.Maximum=100;
            trackBarPenSize.Minimum=1;
            trackBarPenSize.Name="trackBarPenSize";
            trackBarPenSize.Size=new Size(174, 45);
            trackBarPenSize.TabIndex=2;
            trackBarPenSize.TickStyle=TickStyle.None;
            trackBarPenSize.Value=5;
            trackBarPenSize.Scroll+=trackBarPenSize_Scroll;
            // 
            // lblPenSize
            // 
            lblPenSize.AutoSize=true;
            lblPenSize.Location=new Point(12, 81);
            lblPenSize.Name="lblPenSize";
            lblPenSize.Size=new Size(81, 15);
            lblPenSize.TabIndex=3;
            lblPenSize.Text="Размер кисти";
            // 
            // textBoxSizePen
            // 
            textBoxSizePen.BorderStyle=BorderStyle.None;
            textBoxSizePen.Location=new Point(99, 84);
            textBoxSizePen.Name="textBoxSizePen";
            textBoxSizePen.Size=new Size(36, 16);
            textBoxSizePen.TabIndex=4;
            textBoxSizePen.Text="5";
            textBoxSizePen.TextChanged+=textBoxSizePen_TextChanged;
            // 
            // FormARIL
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(904, 461);
            Controls.Add(textBoxSizePen);
            Controls.Add(lblPenSize);
            Controls.Add(trackBarPenSize);
            Controls.Add(btnColorPen);
            Controls.Add(panelDrawing);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="FormARIL";
            Text="ARIL - Рисование";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPenSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDrawing;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem отменаToolStripMenuItem;
        private ToolStripMenuItem повторениеToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem копироватьВсеToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem оРазрабToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Button btnColorPen;
        private TrackBar trackBarPenSize;
        private Label lblPenSize;
        private TextBox textBoxSizePen;
    }
}