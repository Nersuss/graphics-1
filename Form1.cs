using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        private float[,] P;
        private float[,] proection;
        private int cenX;
        private int cenY;
        private Graphics _graphics;

        public Form1()
            => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cenX = Size.Width / 2;
            cenY = Size.Height / 2;
            SetDefaultPosition();
            //кабинетное проецирование относительно центра правосторонней системы координат
            float[,] p =
            {
                { 1, 0, 0, 0},
                { 0, -1, 0, 0},
                { -(float)(Math.Cos(Math.PI/4))/2, (float)(Math.Cos(Math.PI/4))/2, 0, 0},
                { cenX, cenY, 0, 1}
            };
            proection = p;
            DrawP();
        }

        //умножение матриц
        private float[,] Mult(float[,] X, float[,] Y)
        {
            float[,] result = new float[X.GetLength(0), Y.GetLength(1)];
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < Y.GetLength(1); j++)
                    for (int k = 0; k < Y.GetLength(0); k++)
                        result[i, j] += X[i, k] * Y[k, j];
            return result;
        }

        //отрисовка осей
        private void DrawAxis()
        {
            _graphics = CreateGraphics();
            _graphics.Clear(Color.White);
            float[,] Axis =
            {
                { 0, 0, 0, 1},
                { 500, 0, 0, 1},
                { 0, 400, 0, 1},
                { 0, 0, 500, 1},
                { 490, 5, 0, 1},
                { 490, -5, 0, 1},
                { 5, 390, 0, 1},
                { -5, 390, 0, 1},
                { 12, 0, 495, 1},
                { -10, 0, 480, 1}
            };
            Axis = Mult(Axis, proection);
            #region X
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[1, 0], Axis[1, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[4, 0], Axis[4, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[5, 0], Axis[5, 1]);
            #endregion
            #region Y
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[2, 0], Axis[2, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[6, 0], Axis[6, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[7, 0], Axis[7, 1]);
            #endregion
            #region Z
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[3, 0], Axis[3, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[8, 0], Axis[8, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[9, 0], Axis[9, 1]);
            #endregion
        }

        //начальные значения P
        private void SetDefaultPosition()
        {
            float[,] DefP =
            {
                { 0, 0, 0, 1 },
                { 0, 100, 0, 1 },
                { 60, 100, 0, 1 },
                { 60, 40, 0, 1 },
                { 20, 40, 0, 1 },
                { 20, 0, 0, 1 },

                { 0, 0, 20, 1 },
                { 0, 100, 20, 1 },
                { 60, 100, 20, 1 },
                { 60, 40, 20, 1 },
                { 20, 40, 20, 1 },
                { 20, 0, 20, 1 },

                { 20, 60, 0, 1 },
                { 20, 80, 0, 1 },
                { 40, 80, 0, 1 },
                { 40, 60, 0, 1 },

                { 20, 60, 20, 1 },
                { 20, 80, 20, 1 },
                { 40, 80, 20, 1 },
                { 40, 60, 20, 1 },
            };
            P = DefP;
        }


        //отрисовка проекции буквы P
        private void DrawP()
        {
            _graphics = CreateGraphics();
            DrawAxis();
            float[,] matrixDraw = Mult(P, proection);

            // Рисуем переднюю часть буквы P
            _graphics.DrawLine(Pens.Red, matrixDraw[0, 0], matrixDraw[0, 1], matrixDraw[1, 0], matrixDraw[1, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[1, 0], matrixDraw[1, 1], matrixDraw[2, 0], matrixDraw[2, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[2, 0], matrixDraw[2, 1], matrixDraw[3, 0], matrixDraw[3, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[3, 0], matrixDraw[3, 1], matrixDraw[4, 0], matrixDraw[4, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[4, 0], matrixDraw[4, 1], matrixDraw[5, 0], matrixDraw[5, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[5, 0], matrixDraw[5, 1], matrixDraw[0, 0], matrixDraw[0, 1]);

            // Рисуем заднюю часть буквы P
            _graphics.DrawLine(Pens.Red, matrixDraw[6, 0], matrixDraw[6, 1], matrixDraw[7, 0], matrixDraw[7, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[7, 0], matrixDraw[7, 1], matrixDraw[8, 0], matrixDraw[8, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[8, 0], matrixDraw[8, 1], matrixDraw[9, 0], matrixDraw[9, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[9, 0], matrixDraw[9, 1], matrixDraw[10, 0], matrixDraw[10, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[10, 0], matrixDraw[10, 1], matrixDraw[11, 0], matrixDraw[11, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[11, 0], matrixDraw[11, 1], matrixDraw[6, 0], matrixDraw[6, 1]);

            //Рисуем задний вырез в букве
            _graphics.DrawLine(Pens.Red, matrixDraw[12, 0], matrixDraw[12, 1], matrixDraw[13, 0], matrixDraw[13, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[13, 0], matrixDraw[13, 1], matrixDraw[14, 0], matrixDraw[14, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[14, 0], matrixDraw[14, 1], matrixDraw[15, 0], matrixDraw[15, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[15, 0], matrixDraw[15, 1], matrixDraw[12, 0], matrixDraw[12, 1]);

            //Рисуем передний вырез в букве
            _graphics.DrawLine(Pens.Red, matrixDraw[16, 0], matrixDraw[16, 1], matrixDraw[17, 0], matrixDraw[17, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[17, 0], matrixDraw[17, 1], matrixDraw[18, 0], matrixDraw[18, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[18, 0], matrixDraw[18, 1], matrixDraw[19, 0], matrixDraw[19, 1]);
            _graphics.DrawLine(Pens.Red, matrixDraw[19, 0], matrixDraw[19, 1], matrixDraw[16, 0], matrixDraw[16, 1]);

            // Соединяем переднюю и заднюю части буквы
            for (int i = 0; i < 6; i++)
            {
                _graphics.DrawLine(Pens.Red, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 6, 0], matrixDraw[i + 6, 1]);
            }
            // Соединяем переднюю и заднюю части выреза
            for (int i = 12; i < 16; i++)
            {
                _graphics.DrawLine(Pens.Red, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 4, 0], matrixDraw[i + 4, 1]);
            }
        }


        //поместить букву начального размера в центр системы координат
        private void buttonDeffaultPosition_Click(object sender, EventArgs e)
        {
            SetDefaultPosition();
            DrawP();
        }

        //движение вдоль OX в положительном направлении
        private void MovePlusX_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { toMove, 0, 0, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //движение вдоль OX в отрицательном направлении
        private void MoveMinusX_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { -toMove, 0, 0, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //движение вдоль OY в положительном направлении
        private void MovePlusY_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, toMove, 0, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //движение вдоль OY в отрицательном направлении
        private void MoveMinusY_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, -toMove, 0, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //движение вдоль OZ в положительном направлении
        private void MovePlusZ_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, toMove, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //движение вдоль OZ в отрицательном направлении
        private void MoveMinusZ_Click(object sender, EventArgs e)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, -toMove, 1}
            };
            P = Mult(P, Move);
            DrawP();
        }

        //вращение вокруг OX вправо
        private void RotateRightX_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)(Math.Cos(angle)), (float)(Math.Sin(angle)), 0},
                { 0, -(float)(Math.Sin(angle)), (float)(Math.Cos(angle)), 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //вращение вокруг OX влево
        private void RotateLeftX_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)Math.Cos(angle), -((float)(Math.Sin(angle))), 0},
                { 0, ((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //вращение вокруг OY вправо
        private void RotateRightY_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, ((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { -((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //вращение вокруг OY влево
        private void RotateLeftY_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, -((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { ((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //вращение вокруг OZ вправо
        private void RotateRightZ_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), -((float)(Math.Sin(angle))), 0, 0},
                { ((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //вращение вокруг OZ влево
        private void RotateLeftZ_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), ((float)(Math.Sin(angle))), 0, 0},
                { -((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Rotate);
            DrawP();
        }

        //отражение относительно плоскости XY
        private void MirrorXY_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, -1, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Mirror);
            DrawP();
        }

        //отражение относительно плоскости XZ
        private void MirrorXZ_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { 1, 0, 0, 0},
                { 0, -1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Mirror);
            DrawP();
        }

        //отражение относительно плоскости YZ
        private void MirrorYZ_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { -1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Mirror);
            DrawP();
        }

        //растяжение
        private void Stretch_Click(object sender, EventArgs e)
        {
            float[,] Stretch =
            {
                { 2, 0, 0, 0},
                { 0, 2, 0, 0},
                { 0, 0, 2, 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Stretch);
            DrawP();
        }

        //сжатие
        private void Clench_Click(object sender, EventArgs e)
        {
            float[,] Clench =
            {
                { (float)(0.5), 0, 0, 0},
                { 0, (float)(0.5), 0, 0},
                { 0, 0, (float)(0.5), 0},
                { 0, 0, 0, 1}
            };
            P = Mult(P, Clench);
            DrawP();
        }

        // Анимация прыжка буквы
        private void jump_Click(object sender, EventArgs e)
        {
            int way = 100; //продолжительность прыжка
            int count = 0;
            float step = 5f; //размер шага

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler((o, ev) =>
            {
                count++;

                if (count < way)
                {
                    step -= 0.1f;
                    P = Mult(P, new float[,]
                    {
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, step, 0, 1 }
                    });
                }

                if (count == way)
                {
                    System.Windows.Forms.Timer t = o as System.Windows.Forms.Timer;
                    t.Stop();
                }
                DrawP();
            });
            timer.Start();
        }

    }

}