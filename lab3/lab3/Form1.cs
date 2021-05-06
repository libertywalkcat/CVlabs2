using System;
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

namespace lab3
{
    
    public class Cluster
    {
        public int centroidX = 0;
        public int centroidY = 0;
        public List<int> points = new List<int>();

        public int R = 0;
        public double Density = 0;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxTemplate.Load(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\ONE WAY SIGNS\ONE WAY.bmp"));
        }
        Bitmap buffer;
        Bitmap buffer_mask;
        int k, R_min, R_max, Density; 
       
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();
            FDB.SelectedPath = @"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\";
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
        
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
                if (listBox1.SelectedItem.ToString()== "Signs.jpg")
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Load(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\Signs.jpg")); 
                    buffer = new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\Signs.jpg"));              
                }
                analysis();
        }

        //preset color
        private void button4_Click(object sender, EventArgs e)  { Rmin.Value = 0; Rmax.Value = 61; Gmin.Value = 0; Gmax.Value = 122; Bmin.Value = 108; Bmax.Value = 255; }

        //binar
        private void button5_Click(object sender, EventArgs e)
        {
            white.Clear();
            buffer_mask = new Bitmap(buffer);
            int i = 0;
            for (int x = 0; x < 640; x++)
            {
                for (int y = 0; y < 480; y++)
                {
                    int b = buffer_mask.GetPixel(x, y).B;
                    int g = buffer_mask.GetPixel(x, y).G;
                    int r = buffer_mask.GetPixel(x, y).R;

                    if (b >= Bmin.Value && b <= Bmax.Value && g >= Gmin.Value && g <= Gmax.Value && r >= Rmin.Value && r <= Rmax.Value)
                    {
                        buffer_mask.SetPixel(x, y, Color.White);
                        white.Add(new List<int>());
                        white[i].Add(x);
                        white[i].Add(y);
                        i++;
                    }
                    else
                    {
                        buffer_mask.SetPixel(x, y, Color.Black);
                    }
                }
            }
            pictureBox1.Image = buffer_mask;

        }
        //+ color
        List<List<int>> white = new List<List<int>>();  // [num][x,y]
        private void button2_Click(object sender, EventArgs e)
        {      
                buffer_mask = new Bitmap(buffer);
                for (int x = 0; x < 640; x++)
                {
                    for (int y = 0; y < 480; y++)
                    {
                        int b = buffer_mask.GetPixel(x, y).B;
                        int g = buffer_mask.GetPixel(x, y).G;
                        int r = buffer_mask.GetPixel(x, y).R;

                        if (b >= Bmin.Value && b <= Bmax.Value && g >= Gmin.Value && g <= Gmax.Value && r >= Rmin.Value && r <= Rmax.Value)
                        {
                            
                        }
                        else
                        {
                            buffer_mask.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                pictureBox1.Image = buffer_mask;
        }
        
        
        Bitmap bmp_clusters;
        List<Cluster> clusters = new List<Cluster>();
        private void button6_Click(object sender, EventArgs e)
        {
            k = (int)numericUpDown4.Value;
            R_min = (int)numericUpDown1.Value;
            R_max = (int)numericUpDown2.Value;
            Density = (int)numericUpDown3.Value;       
            clusters.Clear();

            //ochen' slozhno centroidy vsyakie
            Random rand = new Random();
            for (int n = 0; n < k; n++)
            {
                clusters.Add(new Cluster());
                clusters[n].centroidX = white[rand.Next(640)][0];  
                clusters[n].centroidY = white[rand.Next(480)][1]; 
            }

             double len, lenOld;               
             //кол-во повторений поиска центроидов
             for (int n = 0; n < 10; n++)
             {

                //cl
                for (int c = 0; c < k; c++) { clusters[c].points.Clear(); }

                //Распределение точек на кластеры
                for (int j = 0; j < white.Count; j++)
                {
                    int x2 = white[j][0];
                    int y2 = white[j][1];

                    // Ищем расстояние от точки до центроида
                    int x1 = clusters[0].centroidX;
                    int y1 = clusters[0].centroidY;
                    len = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    lenOld = len;
                    int clNum = 0;

                    // далее проходим по всем центроидам
                    for (int c = 1; c < k; c++)
                    {
                        x1 = clusters[c].centroidX;
                        y1 = clusters[c].centroidY;
                        // calc length to centroid
                        len = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                        if (len < lenOld) { lenOld = len; clNum = c; }
                    }

                    // если точка вошла то добавляем её в список
                    if (clNum != -1)
                    {
                        clusters[clNum].points.Add(j);
                    }
                }


                // считаем среднее ареф. для центроида
                for (int c = 0; c < k; c++)
                {
                      if (clusters[c].points.Count != 0)
                      {
                          clusters[c].centroidX = 0;
                          clusters[c].centroidY = 0;
                      }      
                      // count all points
                      foreach (int point in clusters[c].points)
                      {
                          clusters[c].centroidX += white[point][0];
                          clusters[c].centroidY += white[point][1];
                      }
                      // calculate  average (new) centroid
                      if (clusters[c].points.Count != 0)
                      {
                          clusters[c].centroidX = clusters[c].centroidX / clusters[c].points.Count;
                          clusters[c].centroidY = clusters[c].centroidY / clusters[c].points.Count;
                      }
                }   
             }

                //tusa
                bmp_clusters = new Bitmap(buffer_mask);
                for (int i = 0; i < k; i++)
                {
                    Color color = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                    for (int c = 0; c < clusters[i].points.Count; c++)
                    {
                        int x = white[clusters[i].points[c]][0];
                        int y = white[clusters[i].points[c]][1];
                        bmp_clusters.SetPixel(x, y, color);
                    }
                }
                pictureBox1.Image = bmp_clusters;


                //rad + plot
                for (int i = 0; i < k; i++)
                {
                    for (int c = 0; c < clusters[i].points.Count; c++)
                    {
                        if (Math.Abs(white[clusters[i].points[c]][0] - clusters[i].centroidX) > clusters[i].R ||
                            Math.Abs(white[clusters[i].points[c]][1] - clusters[i].centroidY) > clusters[i].R) 
                        {
                            clusters[i].R = Math.Max(Math.Abs(white[clusters[i].points[c]][0] - clusters[i].centroidX), Math.Abs(white[clusters[i].points[c]][1] - clusters[i].centroidY));
                        }
                    }
                    clusters[i].Density = (double)clusters[i].points.Count * 100 / (double)(4 * clusters[i].R * clusters[i].R);
                }

                // Проверка на условия кластера
                List<int> cluster_paint = new List<int>();
                for (int i = 0; i < k; i++)
                {
                    if (clusters[i].R < R_max && clusters[i].R > R_min && clusters[i].Density > Density) { cluster_paint.Add(i); }
                }
                listBox2.DataSource = cluster_paint;
        }         

        
     
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                Bitmap rect_bmp = new Bitmap(bmp_clusters);
                Graphics rect_graph = Graphics.FromImage(rect_bmp);
                    int num = listBox2.SelectedIndex;
                    Rectangle rect = new Rectangle(clusters[num].centroidX - clusters[num].R,clusters[num].centroidY- clusters[num].R, 2*clusters[num].R,2* clusters[num].R);
                    rect_graph.DrawRectangle(new Pen(Color.Green, 2), rect);
                    pictureBox1.Image = rect_bmp;
                    Bitmap bmp_crop = new Bitmap(buffer.Clone(rect,buffer.PixelFormat), new Size(80,80));
                    pictureBoxCrop.Image = bmp_crop;
            }
        }

       
        private Bitmap Binarization(Bitmap bmp_bin, int bmin, int bmax, int gmin, int gmax, int rmin, int rmax) 
        {
            if (bmp_bin != null)
            {
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 80; y++)
                    {
                        int b = bmp_bin.GetPixel(x, y).B;
                        int g = bmp_bin.GetPixel(x, y).G;
                        int r = bmp_bin.GetPixel(x, y).R;

                        if (b >= bmin && b <= bmax &&
                            g >= gmin && g <= gmax &&
                            r >= rmin && r <= rmax)
                        {
                            bmp_bin.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            bmp_bin.SetPixel(x, y, Color.Black);
                        }
                    }
                }
            }
            return bmp_bin;
        }

        //comparing
        int Result;
        private void Button7_Click(object sender, EventArgs e) { if (buffer != null) { Compare(); } }
        private int Compare()
        {
            Bitmap bmp_check_temp= new Bitmap(@"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\ONE WAY SIGNS\ONE_WAY_binar.jpg");
            Bitmap bmp_check_crop = Binarization(new Bitmap(pictureBoxCrop.Image), 0,80,0,80,100,255);
            Bitmap bmp_check_temp_square = Binarization(new Bitmap(Convert.ToString(@"C:\Users\LibertyCat\Desktop\Зрение\lab3\Signs\ONE WAY SIGNS\circle.bmp")), 0,80,0,80,100,255);
            Bitmap bmp_check_res = new Bitmap(80, 80);
            int equal = 0;  // count equaling pixels

           

            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 80; y++) //zonirovanie
                {
                    if (bmp_check_crop.GetPixel(x, y) == Color.FromArgb(255, 255, 255) &&
                        bmp_check_temp_square.GetPixel(x, y) == Color.FromArgb(255, 255, 255)) { bmp_check_res.SetPixel(x, y, Color.LightBlue); }  // светло-синий - пиксель белый 
                    if (bmp_check_crop.GetPixel(x, y) == Color.FromArgb(255, 255, 255) && 
                        bmp_check_temp.GetPixel(x, y) == Color.FromArgb(255, 255, 255)) { bmp_check_res.SetPixel(x, y, Color.LightGreen); equal++; } // светло-зеленый - белый и белый
                    if (bmp_check_crop.GetPixel(x, y) == Color.FromArgb(0, 0, 0) &&
                        bmp_check_temp.GetPixel(x, y) == Color.FromArgb(0, 0, 0)) { bmp_check_res.SetPixel(x, y, Color.DarkGreen); equal++; }  // темно-зеленый - черный и черный
                    if (bmp_check_crop.GetPixel(x, y) == Color.FromArgb(0, 0, 0) && 
                        bmp_check_temp.GetPixel(x, y) == Color.FromArgb(255, 255, 255)) { bmp_check_res.SetPixel(x, y, Color.Red); }      // светло-красный
                    if (bmp_check_crop.GetPixel(x, y) == Color.FromArgb(255, 255, 255) &&
                        bmp_check_temp.GetPixel(x, y) == Color.FromArgb(0, 0, 0)) { bmp_check_res.SetPixel(x, y, Color.DarkRed); }  // темно-красный                   
                    
                }
            }
            pictureBinarizationResult.Image = bmp_check_res;
            Result = equal * 100 / (80*80 - 5000);
            textBox1.Text =  Result.ToString()+"%";
            return Result;
        }
        

       public void analysis()
       {
            if ((checkBox6.Checked == true)&&(pictureBox1.Image !=null))
            {
                button4_Click(null, null);
                button5_Click(null,null); 
                button6_Click(null, null);
                int trustLevel = (int)numericUpDown5.Value;
                List<int> signs = new List<int>();
                for (int i = 0; i < listBox2.Items.Count; i++)  
                {
                    listBox2.SelectedIndex = i;
                    if (Compare() > trustLevel) { signs.Add(i); }
                }
                listBox2.SelectedIndex = -1;
                pictureBox1.Image = buffer;
                foreach (int sign in signs) 
                {
                    listBox2.SelectedIndex = sign;
                    if (listBox2.SelectedIndex != -1)
                    {
                        Bitmap bmp_detect = new Bitmap(buffer);
                        Graphics rect_graph = Graphics.FromImage(bmp_detect);
                            int num = listBox2.SelectedIndex;
                            Rectangle rect = new Rectangle(clusters[num].centroidX - clusters[num].R, clusters[num].centroidY - clusters[num].R, 2 * clusters[num].R, 2 * clusters[num].R);
                            rect_graph.DrawRectangle(new Pen(Color.Red, 4), rect);
                            rect_graph.DrawString("Начало дороги с односторонним движением",
                             new Font("Roboto", 10),
                             new SolidBrush(Color.Red),
                             new PointF(clusters[num].centroidX - clusters[num].R - 5, clusters[num].centroidY - clusters[num].R - 20));
                            pictureBox1.Image = bmp_detect;
                    }
                }
            }
       }
    }
}
