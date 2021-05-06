using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.Runtime.InteropServices;

namespace Lab6
{
    public partial class Form1 : Form
    {

        Bitmap show;
        List<Mat> tempArray = new List<Mat>();
        List<bool[]> codeArray = new List<bool[]>();

        Mat frame_in;
        Mat frame_out;

        bool cameraOpened = false;

        VideoCapture capture;
        private Thread camera;

        List<string> paths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddTemplate(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
                dlg.FileName = "Document";
                dlg.DefaultExt = ".png";
                dlg.Filter = "Text documents (.png)|*.png";

                DialogResult result = dlg.ShowDialog();

                paths.Add(dlg.FileName);

                tempArray.Add(new Mat(dlg.FileName));

                codeArray.Add(new bool[49]);

                int xR = -9;
                int yR = -9;
                int codeNum = -1;

                Bitmap displayBitmap = new Bitmap(dlg.FileName);

                for (int m = 0; m < 7; m++)
                {
                    yR = -9;
                    xR += 22;
                    for (int n = 0; n < 7; n++)
                    {
                        codeNum++;

                        yR += 22;

                        int white = 0;
                        int black = 0;

                        for (int q = xR; q < xR + 12; q++)
                        {
                            for (int r = yR; r < yR + 12; r++)
                            {
                                if (displayBitmap.GetPixel(q, r).R == 255)
                                    white++;
                                else
                                    black++;
                            }
                        }

                        if (white > black)
                        {
                            codeArray[codeArray.Count - 1][codeNum] = true;
                            Cv2.PutText(tempArray[tempArray.Count() - 1], "W", new OpenCvSharp.Point(xR + 3, yR + 9), HersheyFonts.Italic, 0.3, new Scalar(0, 0, 0));
                            Cv2.Rectangle(tempArray[tempArray.Count() - 1], new OpenCvSharp.Point(xR, yR), new OpenCvSharp.Point(xR + 12, yR + 12), new Scalar(0, 0, 0));
                        }
                        else
                        {
                            codeArray[codeArray.Count - 1][codeNum] = false;
                            Cv2.PutText(tempArray[tempArray.Count() - 1], "B", new OpenCvSharp.Point(xR + 3, yR + 9), HersheyFonts.Italic, 0.3, new Scalar(255, 255, 255));
                            Cv2.Rectangle(tempArray[tempArray.Count() - 1], new OpenCvSharp.Point(xR, yR), new OpenCvSharp.Point(xR + 12, yR + 12), new Scalar(255, 255, 255));
                        }
                    }
                }
            }
            catch { }
        }

        private void RecognizeTemp(object sender, EventArgs e)
        {
            OpenCvSharp.Point[][] contours;
            OpenCvSharp.Point[] contoursOut;

            HierarchyIndex[] hierarchy;

            Mat after_2gray = new Mat();
            Mat after_canny = new Mat();
            Mat after_blur = new Mat();
            Mat frame_range = new Mat();
            Mat after_after = new Mat();

            Cv2.Blur(frame_in, after_blur, new OpenCvSharp.Size(4, 4));
            Cv2.InRange(after_blur, new Scalar(0, 0, 0), new Scalar(70, 70, 70), frame_range);

            Cv2.FindContours(frame_range, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            for (int i = 0; i < contours.Count(); i++)
            {
                contoursOut = Cv2.ApproxPolyDP(contours[0], 4, false);

                Mat display = new Mat(170, 170, MatType.CV_8U);

                Point2d[] pointsList = new Point2d[4];

                IEnumerable<Point2d> points = new List<Point2d>();

                ///ищем верхнюю правую точку

                //////ищем диагональную ей точку, сравниваем их X и Y, и смотрим на знаки

                for (int p = 0; p < 4; p++)
                {
                    int indexL = 0;
                    double maxL = 0;
                    for (int q = 0; q < 4; q++)
                    {
                        if (p != q)
                        {
                            double l = Math.Sqrt(Math.Pow(contoursOut[p].X - contoursOut[q].X, 2) + Math.Pow(contoursOut[p].Y - contoursOut[q].Y, 2));
                            if (maxL < l)
                            {
                                maxL = l;
                                indexL = q;
                            }
                            double rage = ((150 / 80) * l)/3;
                            divis.Text = "Рвсстояние: " + Convert.ToInt32(rage);
                        }
                    }

                    if ((contoursOut[indexL].X - contoursOut[p].X < 0) && (contoursOut[indexL].Y - contoursOut[p].Y > 0))
                        pointsList[0] = contoursOut[p];
                    if ((contoursOut[indexL].X - contoursOut[p].X > 0) && (contoursOut[indexL].Y - contoursOut[p].Y > 0))
                        pointsList[1] = contoursOut[p];
                    if ((contoursOut[indexL].X - contoursOut[p].X > 0) && (contoursOut[indexL].Y - contoursOut[p].Y < 0))
                        pointsList[2] = contoursOut[p];
                    if ((contoursOut[indexL].X - contoursOut[p].X < 0) && (contoursOut[indexL].Y - contoursOut[p].Y < 0))
                        pointsList[3] = contoursOut[p];
                }

                points = pointsList;
                

                IEnumerable<Point2d> needhom = new List<Point2d>()
                {
                    new Point2d(170, 0),
                    new Point2d(0, 0),
                    new Point2d(0, 170),
                    new Point2d(170, 170)
                };

                Mat h = Cv2.FindHomography(points, needhom);

                Cv2.WarpPerspective(frame_in, display, h, new OpenCvSharp.Size(170, 170));

                Cv2.InRange(display, new Scalar(0, 0, 0), new Scalar(70, 70, 70), display);

                int xR = -9;
                int yR = -9;
                bool[] code = new bool[49];
                int codeNum = -1;

                Bitmap displayBitmap = BitmapConverter.ToBitmap(display);

                for (int m = 0; m < 7; m++)
                {
                    yR = -9;
                    xR += 22;
                    for (int n = 0; n < 7; n++)
                    {
                        codeNum++;

                        yR += 22;

                        int white = 0;
                        int black = 0;

                        for (int q = xR; q < xR + 12; q++)
                        {
                            for (int r = yR; r < yR + 12; r++)
                            {
                                if (displayBitmap.GetPixel(q, r).R == 255)
                                    white++;
                                else
                                    black++;
                            }
                        }

                        if (white > black)
                        {
                            code[codeNum] = true;
                            Cv2.PutText(display, "W", new OpenCvSharp.Point(xR + 3, yR + 9), HersheyFonts.Italic, 0.3, new Scalar(0, 0, 0));
                            Cv2.Rectangle(display, new OpenCvSharp.Point(xR, yR), new OpenCvSharp.Point(xR + 12, yR + 12), new Scalar(0, 0, 0));
                        }
                        else
                        {
                            code[codeNum] = false;
                            Cv2.PutText(display, "B", new OpenCvSharp.Point(xR + 3, yR + 9), HersheyFonts.Italic, 0.3, new Scalar(255, 255, 255));
                            Cv2.Rectangle(display, new OpenCvSharp.Point(xR, yR), new OpenCvSharp.Point(xR + 12, yR + 12), new Scalar(255, 255, 255));
                        }
                    }
                }

                double max = 0;
                int index = 0;
                //сравнение с шаблоном
                for (int temple = 0; temple < codeArray.Count; temple++)
                {
                    int equ = 0;

                    for (int len = 0; len < 49; len++)
                    {
                        if (code[len] == codeArray[temple][len])
                            equ++;
                    }

                    if (equ > max)
                    {
                        max = equ;
                        index = temple;
                    }
                }

                displayBitmap = BitmapConverter.ToBitmap(display);


                if (codeArray.Count() != 0)
                {
                   // tempNum.Text = "Шаблон №" + (index + 1);

                   // divis.Text = "Совпадение: " + Convert.ToInt32(max / (49.0) * 100) + "%";
                }
            }
        }

        private void OpenCamera(object sender, EventArgs e)
        {
            try
            {
                if (cameraSwitch.Text.Equals("Включить камеру"))
                {
                    camera = new Thread(new ThreadStart(CaptureCameraCallback));
                    camera.Start();
                    cameraSwitch.Text = "Выключить камеру";
                    cameraOpened = true;
                }
                else
                {
                    capture.Release();
                    cameraSwitch.Text = "Включить камеру";
                    cameraOpened = false;
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        void CaptureCameraCallback()
        {
            frame_in = new Mat();
            frame_out = new Mat();

            capture = new VideoCapture(0); // (0) -встроенная, (1) - первая подключенная
            capture.Open(0);

            if (capture.IsOpened())
            {
                try
                {
                    while (cameraOpened == true) //если камера запущена
                    {
                        capture.Read(frame_in);
                        frame_out = frame_in;

                        FindRect();

                        show = BitmapConverter.ToBitmap(frame_out);

                        img.Image = show;
                    }
                }
                catch(InvalidCastException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        void FindRect()
        {
            OpenCvSharp.Point[][] contours;
            OpenCvSharp.Point[] contoursOut;

            HierarchyIndex[] hierarchy;

            Mat after_2gray = new Mat();
            Mat after_canny = new Mat();
            Mat after_blur = new Mat();
            Mat frame_range = new Mat();
            Mat after_after = new Mat();

            Cv2.Blur(frame_in, after_blur, new OpenCvSharp.Size(4, 4));
            Cv2.InRange(after_blur, new Scalar(0, 0, 0), new Scalar(70, 70, 70), frame_range);

            Cv2.FindContours(frame_range, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            for (int i = 0; i < contours.Count(); i++)
            {
                contoursOut = Cv2.ApproxPolyDP(contours[0], 4, false);
                Cv2.DrawContours(frame_out, contours, 0, new Scalar(0, 0, 255), 5);
            }
        }
    }
}
