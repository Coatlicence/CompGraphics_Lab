namespace CompGraphics_Lab
{
    public partial class Form1 : Form
    {
        public double[,] OriginalCoordinates =
        {
            { -5,   -5, -5, 1},
            {  5,   -5, -5, 1},
            {  5,    5, -5, 1},
            { -5,    5, -5, 1},

            { -5,   -5, 5, 1},
            {  5,   -5, 5, 1},
            {  5,    5, 5, 1},
            { -5,    5, 5, 1},

        };

        public double[,] WorldCoordinates =
        {
            { -5,   -5, -5, 1},
            {  5,   -5, -5, 1},
            {  5,    5, -5, 1},
            { -5,    5, -5, 1},

            { -5,   -5, 5, 1},
            {  5,   -5, 5, 1},
            {  5,    5, 5, 1},
            { -5,    5, 5, 1},
        };


        public double[] Moved = [0, 0, 0];
        public float[] Rotated = [0, 0, 0];

        public int[,] Transitions =
        {
            { 0, 1 },
            { 1, 2 },
            { 2, 3 },
            { 3, 0 },
            { 4, 5 },
            { 5, 6 },
            { 6, 7 },
            { 7, 4 },

            { 0, 4 },
            { 1, 5 },
            { 2, 6 },
            { 3, 7 },
        };

        // Character
        /*
        public double[,] Coordinates =
        {
            { -8, 4, 1 },
            { -8, 2, 1 },
            { -4, 2, 1 },
            { -4, -8, 1 },
            { -2, -8, 1 },
            { -2, -4, 1 },
            { 2, -4, 1 },
            { 2, -8, 1 },
            { 4, -8, 1 },
            { 4, 2, 1 },
            { 8, 2, 1 },
            { 8, 4, 1 },
            { 0, 4, 1 },
            { -6, 10, 1 },
            { 6, 10, 1 },
            { 0, 7, 1 },
            { 0, 9, 1 },
            { 1, 9, 1 },
            { 1, 7, 1 },
            { 0, 8, 1 },
            { -1.5, 8, 1 },
            { 0, 6.5, 1 },
        };
        */

        static double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new Exception("Cant mult matrixes. count of rows in A != columns in B");
            }

            var matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (var i = 0; i < matrixA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        ///----------------------------------------------------
        // Math Functions
        public void MoveFigure(double x, double y, double z, bool ChangeParameters = true)
        {
            double[,] MoveMatrix =
{
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { x, y, z, 1 },
            };

            if (ChangeParameters)
            {
                Moved[0] += x;
                Moved[1] += y;
                Moved[2] += z;
            }

            WorldCoordinates = MatrixMultiplication(WorldCoordinates, MoveMatrix);
        }

        public void RotateFigure(float x, float y, float z, bool ChangeParameters = true)
        {
            // Return Figure to zero for correct rotation
            // Also can use Original coods
            MoveFigure(-Moved[0], -Moved[1], -Moved[2], false);

            x = x * MathF.PI / 180;
            y = y * MathF.PI / 180;
            z = z * MathF.PI / 180;

            double[,] RotX =
            {
                { 1,    0,              0,                  0 },
                { 0,    MathF.Cos(x),   -MathF.Sin(x),      0 },
                { 0,    MathF.Sin(x),   MathF.Cos(x),       0 },
                { 0,    0,              0,                  1 },
            };

            double[,] RotY =
            {
                { MathF.Cos(y),     0, MathF.Sin(y), 0 },
                { 0,                1, 0,            0 },
                { -MathF.Sin(y),    0, MathF.Cos(y), 0 },
                { 0,                0, 0,            1 }
            };

            double[,] RotZ =
            {
                { MathF.Cos(z), -MathF.Sin(z), 0, 0 },
                { MathF.Sin(z),  MathF.Cos(z), 0, 0 },
                { 0,             0,            1, 0 },
                { 0,             0,            0, 1 }
            };

            if (ChangeParameters)
            {
                Rotated[0] = x;
                Rotated[1] = y;
                Rotated[2] = z;
            }

            WorldCoordinates = MatrixMultiplication(WorldCoordinates, RotZ);
            WorldCoordinates = MatrixMultiplication(WorldCoordinates, RotY);
            WorldCoordinates = MatrixMultiplication(WorldCoordinates, RotX);

            // Return Figure to back
            MoveFigure(Moved[0], Moved[1], Moved[2], false);
        }

        public void Draw(Color color, double[,] Matrix)
        {
            var p = new Pen(color, 1);

            Graphics g = Canvas.CreateGraphics();

            var ScrCoords = WorldToScreen(Matrix);

            for (int i = 0; i < Transitions.GetLength(0); i++)
            {
                var x1 = ScrCoords[Transitions[i, 0], 0];
                var y1 = ScrCoords[Transitions[i, 0], 1];

                var x2 = ScrCoords[Transitions[i, 1], 0];
                var y2 = ScrCoords[Transitions[i, 1], 1];

                g.DrawLine(p, x1, y1, x2, y2);
            }
        }

        public int[,] WorldToScreen(double[,] Coordinates)
        {
            int CenterX = Canvas.Width / 2;
            int CenterY = Canvas.Height / 2;

            int Scale = 20;

            int[,] ScreenCoords =
                new int[Coordinates.GetLength(0), Coordinates.GetLength(1)];

            for (int i = 0; i < Coordinates.GetLength(0); i++)
            {
                ScreenCoords[i, 0] = (int)(CenterX + Coordinates[i, 0] * Scale / Coordinates[i, 3]);
                ScreenCoords[i, 1] = (int)(CenterY + Coordinates[i, 1] * Scale / Coordinates[i, 3]);
            }

            return ScreenCoords;
        }

        private double[,] GetPerspective()
        {
            float n = -1;
            float f = -1000;
            float fovy = 20;

            var radians = MathF.PI / 180 * fovy;
            var sx = (1 / MathF.Tan(radians / 2));
            var sy = (1 / MathF.Tan(radians / 2));
            var sz = (f + n) / (f - n);
            var dz = (-2 * f * n) / (f - n);
            double[,] M =
            {
                { sx, 0, 0, 0 },
                { 0, sy, 0, 0 },
                { 0, 0, sz, dz },
                { 0, 0, -1, 0},
            };

            return MatrixMultiplication(WorldCoordinates, M);
        }

        private void UpdateToPerspective(bool Checked)
        {
            if (Checked)
            {
                Draw(Color.Black, WorldCoordinates);

                Draw(Color.White, GetPerspective());
            }
            else
            {
                Draw(Color.Black, GetPerspective());

                Draw(Color.White, WorldCoordinates);
            }

        }

        ///-------------------------------------------------------
        // Forms Event
        private void Move_Click(object sender, EventArgs e)
        {
            if (checkBoxIsPerspective.Checked)
                Draw(Color.Black, GetPerspective());
            else
                Draw(Color.Black, WorldCoordinates);

            double x = (double)UpDownMovePutX.Value;
            double y = (double)UpDownMovePutY.Value;
            double z = (double)UpDownMovePutZ.Value;

            MoveFigure(x, y, z);

            if (checkBoxIsPerspective.Checked)
                Draw(Color.White, GetPerspective());
            else
                Draw(Color.White, WorldCoordinates);
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (checkBoxIsPerspective.Checked)
                Draw(Color.Black, GetPerspective());
            else
                Draw(Color.Black, WorldCoordinates);

            float x = (float)UpDownRotPutX.Value;
            float y = (float)UpDownRotPutY.Value;
            float z = (float)UpDownRotPutZ.Value;

            RotateFigure(x, y, z);

            if (checkBoxIsPerspective.Checked)
                Draw(Color.White, GetPerspective());
            else
                Draw(Color.White, WorldCoordinates);
        }

        private void CheckBoxIsPerspective_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPerspective(checkBoxIsPerspective.Checked);
        }

        private void Scale_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
