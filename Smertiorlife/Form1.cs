using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Smertiorlife
{
    public partial class TheGameOfLife : Form
    {
        private int generationCount = 0;
        private Graphics Graphics;
        private int resolution;
        private int rows;
        private int cols;
        private int[,] MainField;   //Принимает значения от 0 до 2
        int Color = 1;

        public TheGameOfLife()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функции NeighborRed и NeighborBlue высчитывают количество количество соседних
        /// клеток одного и того же цвета, принимая в входные параметры координаты челевой
        /// клетки, возвращая количество соседей.
        /// </summary>
        private int NeighborRed(int x, int y)
        {
            int count = 0;// Счетчик соседей
            for (int i = -1; i < 2; i++)
            {
                for (int e = -1; e < 2; e++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + e + rows) % rows;
                    var central = ((col == x) && (row == y));
                    var thisThing = MainField[col, row];
                    if (thisThing == 1 && !central)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private int NeighborBlue(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int e = -1; e < 2; e++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + e + rows) % rows;
                    var central = ((col == x) && (row == y));
                    var thisThing = MainField[col, row];
                    if (thisThing == 2 && !central)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void LifeTick(object sender, EventArgs e)
        {
            Graphics.Clear(System.Drawing.Color.Black);
            bool newGeneration = false;// переключатель, отображающий появление хотя бы одного поколения
            var newField = new int[cols, rows]; // новое поле для положения клеток
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var Neighbor = NeighborRed(x, y);
                    var thisThing = MainField[x, y];
                    if (thisThing == 1 && (Neighbor == 2 || Neighbor == 3))// если клетка живая и имеет 3 или 3 соседа
                    {
                        newField[x, y] = 1;
                        Graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        // клетка остается
                        continue;
                    }
                    else if (thisThing == 1 && (Neighbor > 2 || Neighbor < 3))
                    {   // если меньше 2 или больше 3 соседей
                        newField[x, y] = 0;
                        Graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        // клетка становится церного цвета
                        continue;
                    }
                    if (thisThing != 1 && Neighbor == 3)
                    {// если клетка не занята, и имеет 3 соседа, она становится занятой
                        newField[x, y] = 1;
                        Graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        newGeneration = true; // это новое поколение
                        continue;
                    }
                }
            }
            for (int x = 0; x < cols; x++)
            {// тот же самый цикл, только для синих клеток с той же логикой
                for (int y = 0; y < rows; y++)
                {
                    var Neighbor = NeighborBlue(x, y);
                    var thisThing = MainField[x, y];
                    if (thisThing == 2 && (Neighbor == 2 || Neighbor == 3))
                    {
                        newField[x, y] = 2;
                        Graphics.FillRectangle(Brushes.Blue, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        continue;
                    }
                    else if (thisThing == 2 && (Neighbor > 2 || Neighbor < 3))
                    {
                        newField[x, y] = 0;
                        Graphics.FillRectangle(Brushes.Blue, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        continue;
                    }
                    if (thisThing != 2 && Neighbor == 3)
                    {
                        newField[x, y] = 2;
                        Graphics.FillRectangle(Brushes.Blue, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        newGeneration = true;
                        continue;
                    }
                }
            }
            if (newGeneration)// если есть хотя бы одна новая клетка
            {
                generationCount++;// увеличение счетчика
            }
            Text = $"Поколение {generationCount}";// отображение поколений
            MainField = newField;// обновление поля
            LifeBox.Refresh();// обновление графики
        }
        /// <summary>
        /// кнопка старт, запускающая циклы
        /// </summary>>
        private void Start_Click(object sender, EventArgs e)
        {
            if (LifeTimer.Enabled)
                return;//защита от повторного нажатия
            generationCount = 0;// счетчик поколений тановится равен 0
            Text = $"Поколение {generationCount}";
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            resolution = (int)nudResolution.Value;
            rows = LifeBox.Height / resolution;
            cols = LifeBox.Width / resolution;
            MainField = new int[cols, rows];
            for (int i = 0; i < cols; i++)  // Заполнение при старте пустым пространством
            {
                for (int j = 0; j < rows; j++)
                {
                    MainField[i, j] = 0;
                }
            }
            LifeBox.Image = new Bitmap(LifeBox.Width, LifeBox.Height);
            Graphics = Graphics.FromImage(LifeBox.Image);
            LifeTimer.Start(); // Запуск игры и обновление 
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            if (!LifeTimer.Enabled)
                return;
            LifeTimer.Stop();  //остановка игры
            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (!LifeTimer.Enabled)
                return;
            if (e.Button == MouseButtons.Left)  // рисование клеток
            {
                Random random = new Random();
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var ValidatePosition = ValidateMousePosition(x, y);
                if (ValidatePosition)
                    MainField[x, y] = Color;
            }
            if (e.Button == MouseButtons.Right) // удаление клеток
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var ValidatePosition = ValidateMousePosition(x, y);
                if (ValidatePosition)
                    MainField[x, y] = 0;
            }
        }
        private bool ValidateMousePosition(int x, int y)    // защита
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void RedClick(object sender, EventArgs e) // позволяет рисовать красными клетками
        {
            Color = 1;  //
        }

        private void BlueClick(object sender, EventArgs e) // позволяет рисовать синими клетками
        {
            Color = 2;
        }
    }
}

