namespace CompGraphics_Lab
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            Move = new Button();
            UpDownMovePutZ = new NumericUpDown();
            UpDownMovePutY = new NumericUpDown();
            UpDownMovePutX = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox2 = new GroupBox();
            Rotate = new Button();
            UpDownRotPutZ = new NumericUpDown();
            UpDownRotPutX = new NumericUpDown();
            UpDownRotPutY = new NumericUpDown();
            Canvas = new PictureBox();
            groupBox3 = new GroupBox();
            UpDownPutScale = new NumericUpDown();
            Scale = new Button();
            checkBoxIsPerspective = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutX).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownPutScale).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Move);
            groupBox1.Controls.Add(UpDownMovePutZ);
            groupBox1.Controls.Add(UpDownMovePutY);
            groupBox1.Controls.Add(UpDownMovePutX);
            groupBox1.Location = new Point(566, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Position";
            // 
            // Move
            // 
            Move.Location = new Point(50, 109);
            Move.Name = "Move";
            Move.Size = new Size(75, 23);
            Move.TabIndex = 3;
            Move.Text = "Move";
            Move.UseVisualStyleBackColor = true;
            Move.Click += Move_Click;
            // 
            // UpDownMovePutZ
            // 
            UpDownMovePutZ.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownMovePutZ.Location = new Point(50, 80);
            UpDownMovePutZ.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            UpDownMovePutZ.Name = "UpDownMovePutZ";
            UpDownMovePutZ.Size = new Size(120, 23);
            UpDownMovePutZ.TabIndex = 2;
            // 
            // UpDownMovePutY
            // 
            UpDownMovePutY.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownMovePutY.Location = new Point(50, 51);
            UpDownMovePutY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            UpDownMovePutY.Name = "UpDownMovePutY";
            UpDownMovePutY.Size = new Size(120, 23);
            UpDownMovePutY.TabIndex = 1;
            // 
            // UpDownMovePutX
            // 
            UpDownMovePutX.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownMovePutX.Location = new Point(50, 22);
            UpDownMovePutX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            UpDownMovePutX.Name = "UpDownMovePutX";
            UpDownMovePutX.Size = new Size(120, 23);
            UpDownMovePutX.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Rotate);
            groupBox2.Controls.Add(UpDownRotPutZ);
            groupBox2.Controls.Add(UpDownRotPutX);
            groupBox2.Controls.Add(UpDownRotPutY);
            groupBox2.Location = new Point(567, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 139);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rotation";
            // 
            // Rotate
            // 
            Rotate.Location = new Point(49, 109);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(75, 23);
            Rotate.TabIndex = 7;
            Rotate.Text = "Rotate";
            Rotate.UseVisualStyleBackColor = true;
            Rotate.Click += Rotate_Click;
            // 
            // UpDownRotPutZ
            // 
            UpDownRotPutZ.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownRotPutZ.Location = new Point(49, 80);
            UpDownRotPutZ.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            UpDownRotPutZ.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            UpDownRotPutZ.Name = "UpDownRotPutZ";
            UpDownRotPutZ.Size = new Size(120, 23);
            UpDownRotPutZ.TabIndex = 6;
            // 
            // UpDownRotPutX
            // 
            UpDownRotPutX.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownRotPutX.Location = new Point(49, 22);
            UpDownRotPutX.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            UpDownRotPutX.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            UpDownRotPutX.Name = "UpDownRotPutX";
            UpDownRotPutX.Size = new Size(120, 23);
            UpDownRotPutX.TabIndex = 4;
            // 
            // UpDownRotPutY
            // 
            UpDownRotPutY.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownRotPutY.Location = new Point(49, 51);
            UpDownRotPutY.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            UpDownRotPutY.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            UpDownRotPutY.Name = "UpDownRotPutY";
            UpDownRotPutY.Size = new Size(120, 23);
            UpDownRotPutY.TabIndex = 5;
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.Desktop;
            Canvas.Location = new Point(12, 12);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(548, 336);
            Canvas.TabIndex = 4;
            Canvas.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(UpDownPutScale);
            groupBox3.Controls.Add(Scale);
            groupBox3.Location = new Point(567, 281);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 67);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Scale";
            // 
            // UpDownPutScale
            // 
            UpDownPutScale.Location = new Point(55, 24);
            UpDownPutScale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownPutScale.Name = "UpDownPutScale";
            UpDownPutScale.Size = new Size(114, 23);
            UpDownPutScale.TabIndex = 1;
            UpDownPutScale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Scale
            // 
            Scale.Location = new Point(6, 22);
            Scale.Name = "Scale";
            Scale.Size = new Size(46, 25);
            Scale.TabIndex = 0;
            Scale.Text = "Scale";
            Scale.UseVisualStyleBackColor = true;
            Scale.Click += Scale_Click;
            // 
            // checkBoxIsPerspective
            // 
            checkBoxIsPerspective.AutoSize = true;
            checkBoxIsPerspective.CheckAlign = ContentAlignment.TopLeft;
            checkBoxIsPerspective.Location = new Point(477, 329);
            checkBoxIsPerspective.Name = "checkBoxIsPerspective";
            checkBoxIsPerspective.Size = new Size(86, 19);
            checkBoxIsPerspective.TabIndex = 6;
            checkBoxIsPerspective.Text = "Perspective";
            checkBoxIsPerspective.UseVisualStyleBackColor = true;
            checkBoxIsPerspective.CheckedChanged += CheckBoxIsPerspective_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 353);
            Controls.Add(checkBoxIsPerspective);
            Controls.Add(groupBox3);
            Controls.Add(Canvas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutY).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownMovePutX).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutX).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRotPutY).EndInit();
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UpDownPutScale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private NumericUpDown UpDownMovePutZ;
        private NumericUpDown UpDownMovePutY;
        private NumericUpDown UpDownMovePutX;
        private Button Move;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox2;
        private Button Rotate;
        private NumericUpDown UpDownRotPutZ;
        private NumericUpDown UpDownRotPutX;
        private NumericUpDown UpDownRotPutY;
        private PictureBox Canvas;
        private GroupBox groupBox3;
        private NumericUpDown UpDownPutScale;
        private Button Scale;
        private CheckBox checkBoxIsPerspective;
    }
}
