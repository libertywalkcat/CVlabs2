namespace Lab6
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
            this.img = new System.Windows.Forms.PictureBox();
            this.divis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cameraSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.img.Location = new System.Drawing.Point(135, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(227, 216);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // divis
            // 
            this.divis.AutoSize = true;
            this.divis.Location = new System.Drawing.Point(-2, 106);
            this.divis.Name = "divis";
            this.divis.Size = new System.Drawing.Size(67, 13);
            this.divis.TabIndex = 0;
            this.divis.Text = "Расстояние";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Определить расстояние";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RecognizeTemp);
            // 
            // cameraSwitch
            // 
            this.cameraSwitch.Location = new System.Drawing.Point(1, 11);
            this.cameraSwitch.Name = "cameraSwitch";
            this.cameraSwitch.Size = new System.Drawing.Size(99, 43);
            this.cameraSwitch.TabIndex = 6;
            this.cameraSwitch.Text = "Включить камеру";
            this.cameraSwitch.UseVisualStyleBackColor = true;
            this.cameraSwitch.Click += new System.EventHandler(this.OpenCamera);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 249);
            this.Controls.Add(this.divis);
            this.Controls.Add(this.cameraSwitch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img);
            this.Name = "Form1";
            this.Text = "Инженерный проект";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label divis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cameraSwitch;
    }
}

