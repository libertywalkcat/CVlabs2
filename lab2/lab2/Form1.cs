using  System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Media;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
        }

        Bitmap buf;       
        Graphics paint;
        Graphics rectangle;
    
        //Foolder
        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();
            FDB.SelectedPath = @"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\";
            if (FDB.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FDB.SelectedPath);                  
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
        }

        //From listbox to bitmap
        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Load(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\TL1.bmp"));  
                    buf = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\TL1.bmp")); //buf for next work
                }
        }

        //point or sqare
        bool Mode = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (Mode == true)
            {
                Mode = true;
            }
            else if (Mode == false) { Mode = true; }
        }

        private void button5_Click(object sender, EventArgs e)//mods
        {
            if (Mode == false)
            {
                Mode = false;
            }
            else if (Mode == true) { Mode = false; }
        }

        int X1, X2, Y1, Y2 = 0;
        int r, g, b = 0;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)//mouse снимает move
        {
            X1 = e.X;
            Y1 = e.Y;
            pictureBox1.Invalidate();
        }

        //sqare and color
        int width, height = 0;
        double S;
        int X;
        int Y;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (Mode == false)
            {
                buf = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\" + listBox1.SelectedItem));
                paint = Graphics.FromImage(buf);

                X2 = e.X;
                Y2 = e.Y;

                

                height = Math.Abs(Y2 - Y1);
                width = Math.Abs(X2 - X1);

                if (X2 > X1)
                    X = X1;
                else
                    X = X1 - width;

                if (Y2 > Y1)
                    Y = Y1;
                else
                    Y = Y1 - height;

                double k = 0;
           

                //Color in sqare
                for (int i = X; i <= X + width; i++)
                {
                    for (int j = Y; j <= Y + height; j++)
                    {
                        r += buf.GetPixel(i, j).R;
                        g += buf.GetPixel(i, j).G;
                        b += buf.GetPixel(i, j).B;
                        k++;
                    }
                }
                paint.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(X, Y, width, height));
                pictureBox1.Image = buf;

                r = (int)Math.Floor((double)r / k);
                g = (int)Math.Floor((double)g / k);
                b = (int)Math.Floor((double)b / k);
                label1.BackColor = Color.FromArgb(r, g, b);
                S = (r + g + b) / 3;



            }
            else
            {
                //point color
                Graphics gr = pictureBox1.CreateGraphics();
                b = buf.GetPixel(e.X, e.Y).B;
                g = buf.GetPixel(e.X, e.Y).G;
                r = buf.GetPixel(e.X, e.Y).R;
                gr.DrawString("R: " + r + "\r\n" + "G: " + g + "\r\n " + "B: " + " " + b,
                   new Font("Roboto", 12),
                   new SolidBrush(Color.Red),
                   new PointF(e.X + 8, e.Y - 14));
                label2.BackColor = Color.FromArgb(buf.GetPixel(e.X, e.Y).R, buf.GetPixel(e.X, e.Y).G, buf.GetPixel(e.X, e.Y).B);
            }
        }

        //Seriy mir
        private void button4_Click(object sender, EventArgs e)
        {
            double coefB = 0, coefG = 0, coefR = 0;
            Bitmap gray = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\" + listBox1.SelectedItem));


            //coef
            coefR = S / r;
            coefG = S / g;
            coefB = S / b;

            for (int i = X; i < X+width; i++)    //+coef
            {
                for (int j = Y; j < Y+height; j++)
                {
                    if (gray != null)
                    {
                        
                        int Rg = gray.GetPixel(i, j).R;
                        int Gg= gray.GetPixel(i, j).G;
                        int Bg = gray.GetPixel(i, j).B;

                        double corR_test = Math.Round(Rg * coefR);
                        int corR = (int)corR_test;
                        if (corR < 0) { corR = 0; }
                        else if (corR > 255) { corR = 255; }

                        double corG_test = Math.Round(Gg * coefG);
                        int corG = (int)corG_test;
                        if (corG < 0) { corG = 0; }
                        else if (corG > 255) { corG = 255; }

                        double corB_test = Math.Round(Bg * coefB);
                        int corB = (int)corB_test;
                        if (corB < 0) { corB = 0; }
                        else if (corB > 255) { corB = 255; }
                        gray.SetPixel(i, j, Color.FromArgb(corR, corG, corB));
                    }
                }
            }
            pictureBox1.Image = gray;
            buf = gray;
        }

        //presets
        private void Yellow_Click(object sender, EventArgs e){ Rmin.Value = 205; Rmax.Value = 255; Gmin.Value = 205; Gmax.Value = 255; Bmin.Value = 10; Bmax.Value = 110;}
        private void Green_Click_1(object sender, EventArgs e) { Rmin.Value = 120; Rmax.Value = 240; Gmin.Value = 250; Gmax.Value = 255; Bmin.Value = 200; Bmax.Value = 255;}
        private void Red_Click_1(object sender, EventArgs e){ Rmin.Value = 183; Rmax.Value = 255; Gmin.Value = 0; Gmax.Value = 179; Bmin.Value = 0; Bmax.Value = 115; }


        //binar
        Graphics cl_paint;
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap binar = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\" + listBox1.SelectedItem));          
            double k = 0;           
            for (int i = 0; i < 400; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int r= binar.GetPixel(i, j).R; //get color from all pixels
                    int g = binar.GetPixel(i, j).G;
                    int b = binar.GetPixel(i, j).B;
                    //if color not in diap -> set black
                    if (!((r <= Rmax.Value) && (r >= Rmin.Value) && (g <= Gmax.Value) && (g >= Gmin.Value) && (b <= Bmax.Value) && (b >= Bmin.Value)))
                        binar.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                    {
                        binar.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        k++;
                    }
                }
            }
           
                pictureBox2.Image = binar;
                buf = binar;
                cl_paint = Graphics.FromImage(buf);
            

        }

        
        int r_rect, i_rect, j_rect;
        bool find = false;
        bool fromDetector = false;   
        List<List<int>> clustersArray = new List<List<int>>();

        //КЛАСТЕРИЗАЦИЯ
        private void button11_Click(object sender, EventArgs e)
        {
            clustersArray.Clear();
            int k = -1;

            for (int i = 10; i <= 390; i += 10)
            {
                for (int j = 10; j <= 390; j += 10)
                {
                    if (buf.GetPixel(i, j).R != 0)
                    {
                        double div = 1;
                        int r = 4;

                        double white = 0;
                        double black = 0;

                        while ((div > 0.3) && (r < 40))
                        {
                            white = 0;
                            black = 0;
                            r++;
                                for (int m = i-r; m < i + r; m++)
                                {
                                    for (int n = j-r; n < j + r; n++)
                                    {
                                        if (buf.GetPixel(m, n).R != 0)
                                        {
                                            white++;
                                        }
                                        else
                                            black++;
                                    }
                                }

                            div = white / (white + black);
                        }

                        k++;

                        clustersArray.Add(new List<int>());
                        clustersArray[k].Add(i);
                        clustersArray[k].Add(j);
                        clustersArray[k].Add(r);
                    }
                }
            }

            for (int i = 0; i < clustersArray.Count; i++)
            {
                if ((!fromDetector) && (clustersArray[i].Count !=0))
                {
                    cl_paint.DrawRectangle(new Pen(Color.FromArgb(255, 30, 30), 2), clustersArray[i][0] - clustersArray[i][2], clustersArray[i][1] - clustersArray[i][2], clustersArray[i][2] * 2, clustersArray[i][2] * 2);
                }
                else
                if ((clustersArray[i].Count != 0) && (clustersArray[i][2] > 5) && (find == false) )
                {
                    find = true;
                    i_rect = clustersArray[i][0];
                    j_rect = clustersArray[i][1];
                    r_rect = clustersArray[i][2];

                }
            }

            for (int i = 10; i <= 390; i += 10)
                for (int j = 10; j <= 390; j += 10)
                    if (!fromDetector)
                        buf.SetPixel(i, j, Color.FromArgb(0, 255, 130));

            pictureBox1.Image = buf;
        }

        //Sign
        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap picturebox1 = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab2\TrafficLights\" + listBox1.SelectedItem));
            rectangle = Graphics.FromImage(picturebox1);
            fromDetector = true;
            bool type_R = false;
            bool type_Y = false;
            bool type_G = false;
            
                Red_Click_1(sender, e);
                button7_Click(sender, e);
                button11_Click(sender, e);

                if (find == true)
                {
                    type_R = true;
                    find = false;
                }
    
     
                Yellow_Click(sender, e);
                button7_Click(sender, e);
                button11_Click(sender, e); 

                if (find == true)
                {
                    type_Y = true;
                    find = false;
                }
            
          
                Green_Click_1(sender, e);
                button7_Click(sender, e);
                button11_Click(sender, e); 

                if (find == true)
                {
                    type_G = true;
                    find = false;              
                }
            
            
            if ((type_R == true)&&(type_Y == false)&&(type_G == false))
            {
                rectangle.DrawRectangle(new Pen(Color.FromArgb(255, 30, 30), 2), i_rect - r_rect, j_rect - r_rect, r_rect * 2, r_rect * 2);
                pictureBox1.Image = picturebox1;
                MessageBox.Show("Красный");
            }
            else if ((type_R == false) && (type_Y == true) && (type_G == false))
            {
                rectangle.DrawRectangle(new Pen(Color.FromArgb(255, 30, 30), 2), i_rect - r_rect, j_rect - r_rect, r_rect * 2, r_rect * 2);
                pictureBox1.Image = picturebox1;
                MessageBox.Show("Желтый");
            }
            else if ((type_R == false) && (type_Y == false) && (type_G == true))
            {
                rectangle.DrawRectangle(new Pen(Color.FromArgb(255, 30, 30), 2), i_rect - r_rect, j_rect - r_rect, r_rect * 2, r_rect * 2);
                pictureBox1.Image = picturebox1;
                MessageBox.Show("Зеленый");
            }
            else if ((type_R == true) && (type_Y == false) && (type_G == true))
            {
                MessageBox.Show("красный и зеленый");
            }

       
        }

    }

}









