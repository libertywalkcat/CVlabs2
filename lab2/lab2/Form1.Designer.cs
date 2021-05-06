namespace lab2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gmax = new System.Windows.Forms.NumericUpDown();
            this.Gmin = new System.Windows.Forms.NumericUpDown();
            this.Bmax = new System.Windows.Forms.NumericUpDown();
            this.Rmax = new System.Windows.Forms.NumericUpDown();
            this.Bmin = new System.Windows.Forms.NumericUpDown();
            this.Rmin = new System.Windows.Forms.NumericUpDown();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 56);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выбор папки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "точка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Серый мир";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(198, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "Выделяем область";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(347, 100);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(115, 31);
            this.button11.TabIndex = 19;
            this.button11.Text = "Кластеризация";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(347, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 32);
            this.button7.TabIndex = 18;
            this.button7.Text = "Бинаризация";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(716, 77);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(75, 23);
            this.Yellow.TabIndex = 16;
            this.Yellow.Text = "Желтый";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(617, 79);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(75, 23);
            this.Green.TabIndex = 16;
            this.Green.Text = "Зеленый";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click_1);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(520, 79);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(75, 23);
            this.Red.TabIndex = 16;
            this.Red.Text = "Красный ";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(480, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rmax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(586, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(695, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bmax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(586, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gmin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(695, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bmin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(480, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rmin";
            // 
            // Gmax
            // 
            this.Gmax.Location = new System.Drawing.Point(626, 53);
            this.Gmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Gmax.Name = "Gmax";
            this.Gmax.Size = new System.Drawing.Size(56, 20);
            this.Gmax.TabIndex = 5;
            this.Gmax.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // Gmin
            // 
            this.Gmin.Location = new System.Drawing.Point(626, 27);
            this.Gmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Gmin.Name = "Gmin";
            this.Gmin.Size = new System.Drawing.Size(56, 20);
            this.Gmin.TabIndex = 5;
            // 
            // Bmax
            // 
            this.Bmax.Location = new System.Drawing.Point(735, 51);
            this.Bmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Bmax.Name = "Bmax";
            this.Bmax.Size = new System.Drawing.Size(56, 20);
            this.Bmax.TabIndex = 5;
            this.Bmax.Value = new decimal(new int[] {
            115,
            0,
            0,
            0});
            // 
            // Rmax
            // 
            this.Rmax.Location = new System.Drawing.Point(520, 53);
            this.Rmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Rmax.Name = "Rmax";
            this.Rmax.Size = new System.Drawing.Size(56, 20);
            this.Rmax.TabIndex = 5;
            this.Rmax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Bmin
            // 
            this.Bmin.Location = new System.Drawing.Point(735, 25);
            this.Bmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Bmin.Name = "Bmin";
            this.Bmin.Size = new System.Drawing.Size(56, 20);
            this.Bmin.TabIndex = 5;
            // 
            // Rmin
            // 
            this.Rmin.Location = new System.Drawing.Point(520, 27);
            this.Rmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Rmin.Name = "Rmin";
            this.Rmin.Size = new System.Drawing.Size(56, 20);
            this.Rmin.TabIndex = 5;
            this.Rmin.Value = new decimal(new int[] {
            155,
            0,
            0,
            0});
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(347, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(115, 35);
            this.button12.TabIndex = 16;
            this.button12.Text = "Определить сигнал";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "                  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "                  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(428, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 571);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gmax);
            this.Controls.Add(this.Gmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bmax);
            this.Controls.Add(this.Rmin);
            this.Controls.Add(this.Rmax);
            this.Controls.Add(this.Bmin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Gmax;
        private System.Windows.Forms.NumericUpDown Gmin;
        private System.Windows.Forms.NumericUpDown Bmax;
        private System.Windows.Forms.NumericUpDown Rmax;
        private System.Windows.Forms.NumericUpDown Bmin;
        private System.Windows.Forms.NumericUpDown Rmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

