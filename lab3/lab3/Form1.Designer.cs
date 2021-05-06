namespace lab3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bmax = new System.Windows.Forms.NumericUpDown();
            this.Rmax = new System.Windows.Forms.NumericUpDown();
            this.Bmin = new System.Windows.Forms.NumericUpDown();
            this.Gmin = new System.Windows.Forms.NumericUpDown();
            this.Rmin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Gmax = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBinarizationResult = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBoxTemplate = new System.Windows.Forms.PictureBox();
            this.pictureBoxCrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBinarizationResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(69, 43);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(97, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 20);
            this.button5.TabIndex = 53;
            this.button5.Text = "черно-белое";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 20);
            this.button2.TabIndex = 52;
            this.button2.Text = "черно-цветное";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bmax
            // 
            this.Bmax.Location = new System.Drawing.Point(232, 75);
            this.Bmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Bmax.Name = "Bmax";
            this.Bmax.Size = new System.Drawing.Size(47, 20);
            this.Bmax.TabIndex = 39;
            // 
            // Rmax
            // 
            this.Rmax.Location = new System.Drawing.Point(126, 75);
            this.Rmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Rmax.Name = "Rmax";
            this.Rmax.Size = new System.Drawing.Size(47, 20);
            this.Rmax.TabIndex = 41;
            // 
            // Bmin
            // 
            this.Bmin.Location = new System.Drawing.Point(232, 28);
            this.Bmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Bmin.Name = "Bmin";
            this.Bmin.Size = new System.Drawing.Size(47, 20);
            this.Bmin.TabIndex = 36;
            // 
            // Gmin
            // 
            this.Gmin.Location = new System.Drawing.Point(179, 28);
            this.Gmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Gmin.Name = "Gmin";
            this.Gmin.Size = new System.Drawing.Size(47, 20);
            this.Gmin.TabIndex = 37;
            // 
            // Rmin
            // 
            this.Rmin.Location = new System.Drawing.Point(126, 28);
            this.Rmin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Rmin.Name = "Rmin";
            this.Rmin.Size = new System.Drawing.Size(47, 20);
            this.Rmin.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "min";
            // 
            // Gmax
            // 
            this.Gmax.Location = new System.Drawing.Point(179, 75);
            this.Gmax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Gmax.Name = "Gmax";
            this.Gmax.Size = new System.Drawing.Size(47, 20);
            this.Gmax.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "r";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "b";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 79);
            this.button4.TabIndex = 51;
            this.button4.Text = "синий";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "g";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(393, 95);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown4.TabIndex = 21;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(393, 70);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(392, 44);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(392, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Count";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(451, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(103, 43);
            this.listBox2.TabIndex = 15;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 26);
            this.button6.TabIndex = 14;
            this.button6.Text = "Найти кластеры";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(352, 75);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 15);
            this.label33.TabIndex = 11;
            this.label33.Text = "Plot";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(352, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 15);
            this.label32.TabIndex = 12;
            this.label32.Text = "Rmax";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(352, 23);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 15);
            this.label31.TabIndex = 13;
            this.label31.Text = "Rmin";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(511, 95);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown5.TabIndex = 2;
            this.numericUpDown5.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Точность";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 121);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Анализ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Совпадение";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(600, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 39);
            this.button7.TabIndex = 3;
            this.button7.Text = "Сопоставить изображения";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // pictureBinarizationResult
            // 
            this.pictureBinarizationResult.Location = new System.Drawing.Point(686, 108);
            this.pictureBinarizationResult.Name = "pictureBinarizationResult";
            this.pictureBinarizationResult.Size = new System.Drawing.Size(80, 80);
            this.pictureBinarizationResult.TabIndex = 0;
            this.pictureBinarizationResult.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(700, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Образец";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(614, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Кластер";
            // 
            // pictureBoxTemplate
            // 
            this.pictureBoxTemplate.Location = new System.Drawing.Point(686, 18);
            this.pictureBoxTemplate.Name = "pictureBoxTemplate";
            this.pictureBoxTemplate.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxTemplate.TabIndex = 0;
            this.pictureBoxTemplate.TabStop = false;
            // 
            // pictureBoxCrop
            // 
            this.pictureBoxCrop.Location = new System.Drawing.Point(600, 18);
            this.pictureBoxCrop.Name = "pictureBoxCrop";
            this.pictureBoxCrop.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxCrop.TabIndex = 0;
            this.pictureBoxCrop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 659);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBoxTemplate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxCrop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBinarizationResult);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.Bmax);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.Rmax);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.Bmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Rmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gmax);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBinarizationResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown Bmax;
        private System.Windows.Forms.NumericUpDown Rmax;
        private System.Windows.Forms.NumericUpDown Bmin;
        private System.Windows.Forms.NumericUpDown Gmin;
        private System.Windows.Forms.NumericUpDown Rmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Gmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBinarizationResult;
        private System.Windows.Forms.PictureBox pictureBoxTemplate;
        private System.Windows.Forms.PictureBox pictureBoxCrop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

