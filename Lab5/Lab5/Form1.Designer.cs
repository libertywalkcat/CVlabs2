namespace lab5
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
            this.cameraSwitch = new System.Windows.Forms.Button();
            this.shot = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.imgComp = new System.Windows.Forms.PictureBox();
            this.browse = new System.Windows.Forms.Button();
            this.zagr = new System.Windows.Forms.Button();
            this.scr = new System.Windows.Forms.TextBox();
            this.coordinatesL = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.prob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraSwitch
            // 
            this.cameraSwitch.Location = new System.Drawing.Point(12, 12);
            this.cameraSwitch.Name = "cameraSwitch";
            this.cameraSwitch.Size = new System.Drawing.Size(61, 49);
            this.cameraSwitch.TabIndex = 13;
            this.cameraSwitch.Text = "Start";
            this.cameraSwitch.UseVisualStyleBackColor = true;
            this.cameraSwitch.Click += new System.EventHandler(this.CameraGo);
            // 
            // shot
            // 
            this.shot.Location = new System.Drawing.Point(88, 12);
            this.shot.Name = "shot";
            this.shot.Size = new System.Drawing.Size(61, 49);
            this.shot.TabIndex = 14;
            this.shot.Text = "Compare";
            this.shot.UseVisualStyleBackColor = true;
            this.shot.Click += new System.EventHandler(this.Shot);
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.img.Location = new System.Drawing.Point(12, 67);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(320, 240);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 17;
            this.img.TabStop = false;
            // 
            // imgComp
            // 
            this.imgComp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imgComp.Location = new System.Drawing.Point(401, 107);
            this.imgComp.Name = "imgComp";
            this.imgComp.Size = new System.Drawing.Size(150, 150);
            this.imgComp.TabIndex = 6;
            this.imgComp.TabStop = false;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(313, 14);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(29, 20);
            this.browse.TabIndex = 22;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse);
            // 
            // zagr
            // 
            this.zagr.Location = new System.Drawing.Point(155, 38);
            this.zagr.Name = "zagr";
            this.zagr.Size = new System.Drawing.Size(187, 23);
            this.zagr.TabIndex = 21;
            this.zagr.Text = "Загрузить";
            this.zagr.UseVisualStyleBackColor = true;
            this.zagr.Click += new System.EventHandler(this.Loading);
            // 
            // scr
            // 
            this.scr.Enabled = false;
            this.scr.Location = new System.Drawing.Point(155, 14);
            this.scr.Name = "scr";
            this.scr.Size = new System.Drawing.Size(152, 20);
            this.scr.TabIndex = 20;
            this.scr.Text = "Выберите CSV файл...";
            // 
            // coordinatesL
            // 
            this.coordinatesL.AutoSize = true;
            this.coordinatesL.Location = new System.Drawing.Point(348, 60);
            this.coordinatesL.Name = "coordinatesL";
            this.coordinatesL.Size = new System.Drawing.Size(128, 13);
            this.coordinatesL.TabIndex = 19;
            this.coordinatesL.Text = "Шаблоны не загружены";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(348, 14);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(254, 43);
            this.list.TabIndex = 18;
            this.list.SelectedIndexChanged += new System.EventHandler(this.ListChecked);
            // 
            // prob
            // 
            this.prob.AutoSize = true;
            this.prob.Location = new System.Drawing.Point(436, 260);
            this.prob.Name = "prob";
            this.prob.Size = new System.Drawing.Size(88, 13);
            this.prob.TabIndex = 10;
            this.prob.Text = "Совпадение: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.prob);
            this.Controls.Add(this.imgComp);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.zagr);
            this.Controls.Add(this.scr);
            this.Controls.Add(this.coordinatesL);
            this.Controls.Add(this.list);
            this.Controls.Add(this.img);
            this.Controls.Add(this.cameraSwitch);
            this.Controls.Add(this.shot);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cameraSwitch;
        private System.Windows.Forms.Button shot;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox imgComp;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button zagr;
        private System.Windows.Forms.TextBox scr;
        private System.Windows.Forms.Label coordinatesL;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label prob;
    }
}

