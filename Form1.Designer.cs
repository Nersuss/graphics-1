namespace Graphics1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDeffaultPosition = new Button();
            label1 = new Label();
            MoveTextBox = new TextBox();
            MovePlusX = new Button();
            MovePlusY = new Button();
            MovePlusZ = new Button();
            MoveMinusZ = new Button();
            MoveMinusY = new Button();
            MoveMinusX = new Button();
            RotateTextBox = new TextBox();
            label2 = new Label();
            RotateLeftZ = new Button();
            RotateLeftY = new Button();
            RotateLeftX = new Button();
            RotateRightZ = new Button();
            RotateRightY = new Button();
            RotateRightX = new Button();
            MirrorXY = new Button();
            MirrorXZ = new Button();
            MirrorYZ = new Button();
            Stretch = new Button();
            Clench = new Button();
            jump = new Button();
            SuspendLayout();
            // 
            // buttonDeffaultPosition
            // 
            buttonDeffaultPosition.Location = new Point(11, 11);
            buttonDeffaultPosition.Name = "buttonDeffaultPosition";
            buttonDeffaultPosition.Size = new Size(160, 28);
            buttonDeffaultPosition.TabIndex = 0;
            buttonDeffaultPosition.Text = "Начльная позиция";
            buttonDeffaultPosition.UseVisualStyleBackColor = true;
            buttonDeffaultPosition.Click += buttonDeffaultPosition_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Перемещение";
            // 
            // MoveTextBox
            // 
            MoveTextBox.Location = new Point(103, 42);
            MoveTextBox.Name = "MoveTextBox";
            MoveTextBox.Size = new Size(69, 23);
            MoveTextBox.TabIndex = 2;
            MoveTextBox.Text = "10";
            // 
            // MovePlusX
            // 
            MovePlusX.Location = new Point(14, 68);
            MovePlusX.Name = "MovePlusX";
            MovePlusX.Size = new Size(44, 28);
            MovePlusX.TabIndex = 3;
            MovePlusX.Text = "X+";
            MovePlusX.UseVisualStyleBackColor = true;
            MovePlusX.Click += MovePlusX_Click;
            // 
            // MovePlusY
            // 
            MovePlusY.Location = new Point(71, 68);
            MovePlusY.Name = "MovePlusY";
            MovePlusY.Size = new Size(44, 28);
            MovePlusY.TabIndex = 4;
            MovePlusY.Text = "Y+";
            MovePlusY.UseVisualStyleBackColor = true;
            MovePlusY.Click += MovePlusY_Click;
            // 
            // MovePlusZ
            // 
            MovePlusZ.Location = new Point(128, 68);
            MovePlusZ.Name = "MovePlusZ";
            MovePlusZ.Size = new Size(44, 28);
            MovePlusZ.TabIndex = 5;
            MovePlusZ.Text = "Z+";
            MovePlusZ.UseVisualStyleBackColor = true;
            MovePlusZ.Click += MovePlusZ_Click;
            // 
            // MoveMinusZ
            // 
            MoveMinusZ.Location = new Point(128, 102);
            MoveMinusZ.Name = "MoveMinusZ";
            MoveMinusZ.Size = new Size(44, 28);
            MoveMinusZ.TabIndex = 8;
            MoveMinusZ.Text = "Z-";
            MoveMinusZ.UseVisualStyleBackColor = true;
            MoveMinusZ.Click += MoveMinusZ_Click;
            // 
            // MoveMinusY
            // 
            MoveMinusY.Location = new Point(71, 102);
            MoveMinusY.Name = "MoveMinusY";
            MoveMinusY.Size = new Size(44, 28);
            MoveMinusY.TabIndex = 7;
            MoveMinusY.Text = "Y-";
            MoveMinusY.UseVisualStyleBackColor = true;
            MoveMinusY.Click += MoveMinusY_Click;
            // 
            // MoveMinusX
            // 
            MoveMinusX.Location = new Point(14, 102);
            MoveMinusX.Name = "MoveMinusX";
            MoveMinusX.Size = new Size(44, 28);
            MoveMinusX.TabIndex = 6;
            MoveMinusX.Text = "X-";
            MoveMinusX.UseVisualStyleBackColor = true;
            MoveMinusX.Click += MoveMinusX_Click;
            // 
            // RotateTextBox
            // 
            RotateTextBox.Location = new Point(103, 136);
            RotateTextBox.Name = "RotateTextBox";
            RotateTextBox.Size = new Size(69, 23);
            RotateTextBox.TabIndex = 10;
            RotateTextBox.Text = "45";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 139);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "Вращение";
            // 
            // RotateLeftZ
            // 
            RotateLeftZ.Location = new Point(128, 199);
            RotateLeftZ.Name = "RotateLeftZ";
            RotateLeftZ.Size = new Size(44, 28);
            RotateLeftZ.TabIndex = 16;
            RotateLeftZ.Text = "Z-l";
            RotateLeftZ.UseVisualStyleBackColor = true;
            RotateLeftZ.Click += RotateLeftZ_Click;
            // 
            // RotateLeftY
            // 
            RotateLeftY.Location = new Point(71, 199);
            RotateLeftY.Name = "RotateLeftY";
            RotateLeftY.Size = new Size(44, 28);
            RotateLeftY.TabIndex = 15;
            RotateLeftY.Text = "Y-l";
            RotateLeftY.UseVisualStyleBackColor = true;
            RotateLeftY.Click += RotateLeftY_Click;
            // 
            // RotateLeftX
            // 
            RotateLeftX.Location = new Point(14, 199);
            RotateLeftX.Name = "RotateLeftX";
            RotateLeftX.Size = new Size(44, 28);
            RotateLeftX.TabIndex = 14;
            RotateLeftX.Text = "X-l";
            RotateLeftX.UseVisualStyleBackColor = true;
            RotateLeftX.Click += RotateLeftX_Click;
            // 
            // RotateRightZ
            // 
            RotateRightZ.Location = new Point(128, 165);
            RotateRightZ.Name = "RotateRightZ";
            RotateRightZ.Size = new Size(44, 28);
            RotateRightZ.TabIndex = 13;
            RotateRightZ.Text = "Z-r";
            RotateRightZ.UseVisualStyleBackColor = true;
            RotateRightZ.Click += RotateRightZ_Click;
            // 
            // RotateRightY
            // 
            RotateRightY.Location = new Point(71, 165);
            RotateRightY.Name = "RotateRightY";
            RotateRightY.Size = new Size(44, 28);
            RotateRightY.TabIndex = 12;
            RotateRightY.Text = "Y-r";
            RotateRightY.UseVisualStyleBackColor = true;
            RotateRightY.Click += RotateRightY_Click;
            // 
            // RotateRightX
            // 
            RotateRightX.Location = new Point(14, 165);
            RotateRightX.Name = "RotateRightX";
            RotateRightX.Size = new Size(44, 28);
            RotateRightX.TabIndex = 11;
            RotateRightX.Text = "X-r";
            RotateRightX.UseVisualStyleBackColor = true;
            RotateRightX.Click += RotateRightX_Click;
            // 
            // MirrorXY
            // 
            MirrorXY.Location = new Point(14, 232);
            MirrorXY.Name = "MirrorXY";
            MirrorXY.Size = new Size(160, 28);
            MirrorXY.TabIndex = 17;
            MirrorXY.Text = "Отражение OXY";
            MirrorXY.UseVisualStyleBackColor = true;
            MirrorXY.Click += MirrorXY_Click;
            // 
            // MirrorXZ
            // 
            MirrorXZ.Location = new Point(14, 266);
            MirrorXZ.Name = "MirrorXZ";
            MirrorXZ.Size = new Size(160, 28);
            MirrorXZ.TabIndex = 18;
            MirrorXZ.Text = "Отражение OXZ";
            MirrorXZ.UseVisualStyleBackColor = true;
            MirrorXZ.Click += MirrorXZ_Click;
            // 
            // MirrorYZ
            // 
            MirrorYZ.Location = new Point(14, 300);
            MirrorYZ.Name = "MirrorYZ";
            MirrorYZ.Size = new Size(160, 28);
            MirrorYZ.TabIndex = 19;
            MirrorYZ.Text = "Отражение OYZ";
            MirrorYZ.UseVisualStyleBackColor = true;
            MirrorYZ.Click += MirrorYZ_Click;
            // 
            // Stretch
            // 
            Stretch.Location = new Point(14, 334);
            Stretch.Name = "Stretch";
            Stretch.Size = new Size(160, 28);
            Stretch.TabIndex = 20;
            Stretch.Text = "Растяжение";
            Stretch.UseVisualStyleBackColor = true;
            Stretch.Click += Stretch_Click;
            // 
            // Clench
            // 
            Clench.Location = new Point(14, 368);
            Clench.Name = "Clench";
            Clench.Size = new Size(160, 28);
            Clench.TabIndex = 21;
            Clench.Text = "Сжатие";
            Clench.UseVisualStyleBackColor = true;
            Clench.Click += Clench_Click;
            // 
            // jump
            // 
            jump.Location = new Point(14, 402);
            jump.Name = "jump";
            jump.Size = new Size(160, 28);
            jump.TabIndex = 25;
            jump.Text = "Прыжок";
            jump.UseVisualStyleBackColor = true;
            jump.Click += jump_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 441);
            Controls.Add(jump);
            Controls.Add(Clench);
            Controls.Add(Stretch);
            Controls.Add(MirrorYZ);
            Controls.Add(MirrorXZ);
            Controls.Add(MirrorXY);
            Controls.Add(RotateLeftZ);
            Controls.Add(RotateLeftY);
            Controls.Add(RotateLeftX);
            Controls.Add(RotateRightZ);
            Controls.Add(RotateRightY);
            Controls.Add(RotateRightX);
            Controls.Add(RotateTextBox);
            Controls.Add(label2);
            Controls.Add(MoveMinusZ);
            Controls.Add(MoveMinusY);
            Controls.Add(MoveMinusX);
            Controls.Add(MovePlusZ);
            Controls.Add(MovePlusY);
            Controls.Add(MovePlusX);
            Controls.Add(MoveTextBox);
            Controls.Add(label1);
            Controls.Add(buttonDeffaultPosition);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная №1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonDeffaultPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MoveTextBox;
        private System.Windows.Forms.Button MovePlusX;
        private System.Windows.Forms.Button MovePlusY;
        private System.Windows.Forms.Button MovePlusZ;
        private System.Windows.Forms.Button MoveMinusZ;
        private System.Windows.Forms.Button MoveMinusY;
        private System.Windows.Forms.Button MoveMinusX;
        private System.Windows.Forms.TextBox RotateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RotateLeftZ;
        private System.Windows.Forms.Button RotateLeftY;
        private System.Windows.Forms.Button RotateLeftX;
        private System.Windows.Forms.Button RotateRightZ;
        private System.Windows.Forms.Button RotateRightY;
        private System.Windows.Forms.Button RotateRightX;
        private System.Windows.Forms.Button MirrorXY;
        private System.Windows.Forms.Button MirrorXZ;
        private System.Windows.Forms.Button MirrorYZ;
        private System.Windows.Forms.Button Stretch;
        private System.Windows.Forms.Button Clench;
        private Button jump;
    }
}
