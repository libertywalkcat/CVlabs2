namespace lab4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.Bmin = new System.Windows.Forms.NumericUpDown();
            this.Gmin = new System.Windows.Forms.NumericUpDown();
            this.Rmin = new System.Windows.Forms.NumericUpDown();
            this.Bmax = new System.Windows.Forms.NumericUpDown();
            this.Gmax = new System.Windows.Forms.NumericUpDown();
            this.Rmax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load/Update ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "HSV";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Filter2D";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(80, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "Ez color";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 109);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 17);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Smooth";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(80, 109);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(119, 17);
            this.checkBox8.TabIndex = 18;
            this.checkBox8.Text = "Значение пикселя";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // Bmin
            // 
            this.Bmin.Location = new System.Drawing.Point(29, 229);
            this.Bmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Bmin.Name = "Bmin";
            this.Bmin.Size = new System.Drawing.Size(47, 20);
            this.Bmin.TabIndex = 19;
            // 
            // Gmin
            // 
            this.Gmin.Location = new System.Drawing.Point(28, 189);
            this.Gmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Gmin.Name = "Gmin";
            this.Gmin.Size = new System.Drawing.Size(47, 20);
            this.Gmin.TabIndex = 20;
            // 
            // Rmin
            // 
            this.Rmin.Location = new System.Drawing.Point(29, 152);
            this.Rmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Rmin.Name = "Rmin";
            this.Rmin.Size = new System.Drawing.Size(47, 20);
            this.Rmin.TabIndex = 21;
            // 
            // Bmax
            // 
            this.Bmax.Location = new System.Drawing.Point(110, 229);
            this.Bmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Bmax.Name = "Bmax";
            this.Bmax.Size = new System.Drawing.Size(47, 20);
            this.Bmax.TabIndex = 22;
            // 
            // Gmax
            // 
            this.Gmax.Location = new System.Drawing.Point(110, 191);
            this.Gmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Gmax.Name = "Gmax";
            this.Gmax.Size = new System.Drawing.Size(47, 20);
            this.Gmax.TabIndex = 23;
            // 
            // Rmax
            // 
            this.Rmax.Location = new System.Drawing.Point(110, 152);
            this.Rmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Rmax.Name = "Rmax";
            this.Rmax.Size = new System.Drawing.Size(47, 20);
            this.Rmax.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "r";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "r";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "b";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(8, 265);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(57, 17);
            this.checkBox9.TabIndex = 31;
            this.checkBox9.Text = "Бинар";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "max";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(16, 108);
            this.button4.TabIndex = 35;
            this.button4.Text = "синий";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(102, 265);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(65, 17);
            this.checkBox10.TabIndex = 37;
            this.checkBox10.Text = "В цвете";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(8, 299);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(159, 17);
            this.checkBox11.TabIndex = 38;
            this.checkBox11.Text = "Поиск объектов интереса";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(80, 63);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(56, 17);
            this.checkBox7.TabIndex = 53;
            this.checkBox7.Text = "Canny";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 324);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(87, 17);
            this.checkBox6.TabIndex = 44;
            this.checkBox6.Text = "Ищем знак ";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Кластер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "По маске";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 322);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(110, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.Bmax);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Bmin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Gmin);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.Rmin);
            this.Controls.Add(this.Gmax);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rmax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.NumericUpDown Bmin;
        private System.Windows.Forms.NumericUpDown Gmin;
        private System.Windows.Forms.NumericUpDown Rmin;
        private System.Windows.Forms.NumericUpDown Bmax;
        private System.Windows.Forms.NumericUpDown Gmax;
        private System.Windows.Forms.NumericUpDown Rmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

