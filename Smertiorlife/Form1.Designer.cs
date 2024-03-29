namespace Smertiorlife
{
    partial class TheGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bblue = new System.Windows.Forms.Button();
            this.bred = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LifeBox = new System.Windows.Forms.PictureBox();
            this.LifeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.bblue);
            this.splitContainer1.Panel1.Controls.Add(this.bred);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LifeBox);
            this.splitContainer1.Size = new System.Drawing.Size(903, 423);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // bblue
            // 
            this.bblue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bblue.Location = new System.Drawing.Point(7, 160);
            this.bblue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bblue.Name = "bblue";
            this.bblue.Size = new System.Drawing.Size(153, 36);
            this.bblue.TabIndex = 9;
            this.bblue.Text = "Синие";
            this.bblue.UseVisualStyleBackColor = false;
            this.bblue.Click += new System.EventHandler(this.BlueClick);
            // 
            // bred
            // 
            this.bred.BackColor = System.Drawing.Color.LightCoral;
            this.bred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bred.Location = new System.Drawing.Point(7, 118);
            this.bred.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bred.Name = "bred";
            this.bred.Size = new System.Drawing.Size(153, 36);
            this.bred.TabIndex = 8;
            this.bred.Text = "Красные";
            this.bred.UseVisualStyleBackColor = false;
            this.bred.Click += new System.EventHandler(this.RedClick);
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Tomato;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(14, 361);
            this.bStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(146, 33);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Стоп ";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.LimeGreen;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(14, 322);
            this.bStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(146, 33);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Старт ";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(7, 92);
            this.nudDensity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(153, 20);
            this.nudDensity.TabIndex = 4;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плотность клеток ";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(7, 43);
            this.nudResolution.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(153, 20);
            this.nudResolution.TabIndex = 2;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение ";
            // 
            // LifeBox
            // 
            this.LifeBox.BackColor = System.Drawing.Color.Lavender;
            this.LifeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifeBox.Location = new System.Drawing.Point(0, 0);
            this.LifeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(721, 419);
            this.LifeBox.TabIndex = 0;
            this.LifeBox.TabStop = false;
            this.LifeBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // LifeTimer
            // 
            this.LifeTimer.Interval = 40;
            this.LifeTimer.Tick += new System.EventHandler(this.LifeTick);
            // 
            // TheGameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(903, 423);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TheGameOfLife";
            this.Text = "Игра Жизнь ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LifeBox;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer LifeTimer;
        private System.Windows.Forms.Button bblue;
        private System.Windows.Forms.Button bred;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label label2;
    }
}

