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

namespace lab5
{
    public partial class Form1 : Form
    {
        string filename;

        int xNew1;
        int yNew1;
        int xNew2;
        int yNew2;
        int xNew3;
        int yNew3;

        double ang1Rad;
        double ang2Rad;
        double ang3Rad;

        double ang1;
        double ang2;
        double ang3;

        double l11;
        double l22;
        double l33;

        Mat tempLitMat;
        Mat tempBigMat;
        Mat tempMat;

        Mat detMat;

        Bitmap show;

        Bitmap temp;
        Graphics tempGr;

        Bitmap det;
        Graphics detGr;

        Graphics showGr;

        Mat frame_in;
        Mat frame_out;

        bool cameraOpened = false;

        VideoCapture capture;
        private Thread camera;

        public Form1()
        {
            InitializeComponent();
        }

        private void Browse(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.FileName = "HUI";
            dlg.DefaultExt = ".csv";

            DialogResult result = dlg.ShowDialog();
            filename = dlg.FileName;   
            scr.Text = filename;
        }

        private void Loading(object sender, EventArgs e)
        {
            int num = -1;
            list.Items.Clear();

                using (StreamReader file = new StreamReader(filename))
                {
                    while (file.Peek() >= 0)
                    {
                        num++;
                        list.Items.Insert(num, "Шаблон №" + num + ": " + file.ReadLine());
                    }
                }
            list.SelectedIndex = list.Items.Count - 1;
        }

        private void ListChecked(object sender, EventArgs e)
        {

            string listParse1 = list.Items[list.SelectedIndex].ToString().Split(':')[1].Substring(1);
            string[] coord = listParse1.Split(';');

            double x1 = Convert.ToDouble(coord[0]);
            double y1 = Convert.ToDouble(coord[1]);

            double x2 = Convert.ToDouble(coord[2]);
            double y2 = Convert.ToDouble(coord[3]);

            double x3 = Convert.ToDouble(coord[4]);
            double y3 = Convert.ToDouble(coord[5]);

            tempGr.Clear(Color.Black);

            tempGr.FillPolygon(new SolidBrush(Color.White), GetCurve(x1, y1, x2, y2, x3, y3, 0.8));
            tempLitMat = BitmapConverter.ToMat(temp);

            tempGr.FillPolygon(new SolidBrush(Color.White), GetCurve(x1, y1, x2, y2, x3, y3, 1.2));
            tempBigMat = BitmapConverter.ToMat(temp);

            tempGr.Clear(Color.Black);

            tempGr.FillPolygon(new SolidBrush(Color.White), GetCurve(x1, y1, x2, y2, x3, y3, 1));
            tempMat = BitmapConverter.ToMat(temp);

            imgComp.Image = BitmapConverter.ToBitmap(tempMat);
        }

        PointF[] GetCurve(double x1, double y1, double x2, double y2, double x3, double y3, double kl)
        {
            coordinatesL.Text = "X1: " + x1 + ";  Y1: " + y1 + ";  X2: " + x2 + ";  Y2: " + y1 + ";  X3: " + x3 + "; Y3: " + y3;

            double xMid = (x1 + x2 + x3) / 3.0;
            double yMid = (y1 + y2 + y3) / 3.0;

            double l1 = Math.Sqrt(Math.Pow(x1 - xMid, 2) + Math.Pow(y1 - yMid, 2));
            double l2 = Math.Sqrt(Math.Pow(x2 - xMid, 2) + Math.Pow(y2 - yMid, 2));
            double l3 = Math.Sqrt(Math.Pow(x3 - xMid, 2) + Math.Pow(y3 - yMid, 2));

            ang1 = Math.Asin((y1 - yMid) / l1);

            ang1 = ang1 * 180.0 / Math.PI;

            if (x1 < xMid)
                ang1 = ang1 + (180 - ang1 * 2);

            ang2 = Math.Asin((y2 - yMid) / l2);

            ang2 = ang2 * 180.0 / Math.PI;

            if (x2 < xMid)
                ang2 = ang2 + (180 - ang2 * 2);

            ang3 = Math.Asin((y3 - yMid) / l3);

            ang3 = ang3 * 180.0 / Math.PI;

            if (x3 < xMid)
                ang3 = ang3 + (180 - ang3 * 2);

            double lMax = Math.Max(l1, Math.Max(l2, l3));

            double k = 60.0 / lMax;

            l11 = l1 * 8 * kl;  
            l22 = l2 * 8 * kl;
            l33 = l3 * 8 * kl;

            ang1Rad = ang1 / 180.0 * Math.PI;
            ang2Rad = ang2 / 180.0 * Math.PI;
            ang3Rad = ang3 / 180.0 * Math.PI;

            xNew1 = Convert.ToInt32(Math.Cos(ang1Rad) * l11);
            yNew1 = Convert.ToInt32(Math.Sin(ang1Rad) * l11);
            xNew2 = Convert.ToInt32(Math.Cos(ang2Rad) * l22);
            yNew2 = Convert.ToInt32(Math.Sin(ang2Rad) * l22);
            xNew3 = Convert.ToInt32(Math.Cos(ang3Rad) * l33);
            yNew3 = Convert.ToInt32(Math.Sin(ang3Rad) * l33);

            PointF point1 = new PointF(xNew1 + 75, yNew1 + 75);
            PointF point2 = new PointF(xNew2 + 75, yNew2 + 75);
            PointF point3 = new PointF(xNew3 + 75, yNew3 + 75);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
             };

            return curvePoints;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp = new Bitmap(150, 150);
            det = new Bitmap(150, 150);

            tempGr = Graphics.FromImage(temp);
            detGr = Graphics.FromImage(det);
        }

        private void CameraGo(object sender, EventArgs e)
        {
            if (cameraSwitch.Text.Equals("Start"))
            {
                camera = new Thread(new ThreadStart(CaptureCameraCallback));
                camera.Start();
                cameraSwitch.Text = "Stop";
                cameraOpened = true;
            }
            else
            {
                capture.Release();
                cameraSwitch.Text = "Start";
                cameraOpened = false;
            }
        }

        void CaptureCameraCallback()
        {
            show = new Bitmap(150, 150);
            showGr = Graphics.FromImage(show);

            frame_in = new Mat();
            frame_out = new Mat();

            capture = new VideoCapture(1);
            capture.Open(1);

            if (capture.IsOpened())
            {
                try
                {
                    while (cameraOpened == true)
                    {
                        capture.Read(frame_in);

                        FindTri();

                        frame_out = frame_in;

                        show = BitmapConverter.ToBitmap(frame_out);

                        img.Image = show;
                    }
                }
                catch { }
            }
        }

        void FindTri()
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
                contoursOut = Cv2.ApproxPolyDP(contours[0], 3, false);

                if (contoursOut.Length == 4)
                {
                    int x1 = contoursOut[1].X;
                    int y1 = contoursOut[1].Y;

                    int x2 = contoursOut[2].X;
                    int y2 = contoursOut[2].Y;

                    int x3 = contoursOut[3].X;
                    int y3 = contoursOut[3].Y;

                    Cv2.Line(frame_in, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), new Scalar(0, 0, 255), 5);
                    Cv2.Line(frame_in, new OpenCvSharp.Point(x3, y3), new OpenCvSharp.Point(x2, y2), new Scalar(0, 0, 255), 5);
                    Cv2.Line(frame_in, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x3, y3), new Scalar(0, 0, 255), 5);
                }
            }
        }

        private void Shot(object sender, EventArgs e)
        {
            OpenCvSharp.Point[][] contours;
            OpenCvSharp.Point[] contoursOut;
            HierarchyIndex[] hierarchy;
            Mat after_2gray = new Mat();
            Mat after_canny = new Mat();
            Mat after_blur = new Mat();
            Mat frame_range = new Mat();
            Mat after_after = new Mat();

            Cv2.Blur(frame_in, after_blur, new OpenCvSharp.Size(3, 3));
            Cv2.InRange(after_blur, new Scalar(0, 0, 0), new Scalar(70, 70, 70), frame_range);

            Cv2.FindContours(frame_range, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            contoursOut = new OpenCvSharp.Point[0];
            contoursOut = Cv2.ApproxPolyDP(contours[0], 3, false);

            if (contoursOut.Length == 4)
                Detail(contoursOut);

            void Detail(OpenCvSharp.Point[] points)
            {
                double x1 = points[1].X;
                double y1 = points[1].Y;

                double x2 = points[2].X;
                double y2 = points[2].Y;

                double x3 = points[3].X;
                double y3 = points[3].Y;

                coordinatesL.Text = "X1: " + x1 + ";  Y1: " + y1 + ";  X2: " + x2 + ";  Y2: " + y1 + ";  X3: " + x3 + "; Y3: " + y3;

                double xMid = (x1 + x2 + x3) / 3.0;
                double yMid = (y1 + y2 + y3) / 3.0;

                double l1 = Math.Sqrt(Math.Pow(x1 - xMid, 2) + Math.Pow(y1 - yMid, 2));
                double l2 = Math.Sqrt(Math.Pow(x2 - xMid, 2) + Math.Pow(y2 - yMid, 2));
                double l3 = Math.Sqrt(Math.Pow(x3 - xMid, 2) + Math.Pow(y3 - yMid, 2));

                double max = 0;
                int iSave = 0;

                Bitmap bitmap = new Bitmap(150, 150);
                Graphics bitmapGr = Graphics.FromImage(bitmap); ;

                for (int i = 0; i < 359; i++)
                {

                    ang1 = Math.Asin((y1 - yMid) / l1);

                    ang1 = ang1 * 180.0 / Math.PI;

                    if (x1 < xMid)
                        ang1 = ang1 + (180 - ang1 * 2);

                    ang2 = Math.Asin((y2 - yMid) / l2);

                    ang2 = ang2 * 180.0 / Math.PI;

                    if (x2 < xMid)
                        ang2 = ang2 + (180 - ang2 * 2);

                    ang3 = Math.Asin((y3 - yMid) / l3);

                    ang3 = ang3 * 180.0 / Math.PI;

                    if (x3 < xMid)
                        ang3 = ang3 + (180 - ang3 * 2);

                    double lMax2 = Math.Max(l1, Math.Max(l2, l3));

                    double k2 = 60.0 / lMax2;

                    l11 = l1 * k2;
                    l22 = l2 * k2;
                    l33 = l3 * k2;

                    ang1Rad = (ang1 + i) / 180.0 * Math.PI;
                    ang2Rad = (ang2 + i) / 180.0 * Math.PI;
                    ang3Rad = (ang3 + i) / 180.0 * Math.PI;

                    xNew1 = Convert.ToInt32(Math.Cos(ang1Rad) * l11);

                    yNew1 = Convert.ToInt32(Math.Sin(ang1Rad) * l11);

                    xNew2 = Convert.ToInt32(Math.Cos(ang2Rad) * l22);

                    yNew2 = Convert.ToInt32(Math.Sin(ang2Rad) * l22);

                    xNew3 = Convert.ToInt32(Math.Cos(ang3Rad) * l33);

                    yNew3 = Convert.ToInt32(Math.Sin(ang3Rad) * l33);

                    bitmap = new Bitmap(150, 150);
                    bitmapGr = Graphics.FromImage(bitmap);
                    bitmapGr.Clear(Color.Black);

                    PointF point1q = new PointF(xNew1 + 75, yNew1 + 75);
                    PointF point2q = new PointF(xNew2 + 75, yNew2 + 75);
                    PointF point3q = new PointF(xNew3 + 75, yNew3 + 75);
                    PointF[] curvePointsq =
                    {
                    point1q,
                    point2q,
                    point3q,
                    };

                    bitmapGr.Clear(Color.Black);

                    detGr.Clear(Color.Black);

                    detGr.FillPolygon(new SolidBrush(Color.White), curvePointsq);

                    detMat = BitmapConverter.ToMat(det);

                    Mat andMat = new Mat();
                    Mat orMat = new Mat();

                    Mat a = new Mat();
                    Mat o = new Mat();

                    Mat dM = new Mat();
                    Mat tM = new Mat();

                    Cv2.CvtColor(detMat, dM, ColorConversionCodes.RGB2GRAY);
                    Cv2.CvtColor(tempMat, tM, ColorConversionCodes.RGB2GRAY);
                    Cv2.InRange(dM, new Scalar(20, 20, 20), new Scalar(255, 255, 255), dM);
                    Cv2.InRange(tM, new Scalar(20, 20, 20), new Scalar(255, 255, 255), tM);

                    imgComp.Image = BitmapConverter.ToBitmap(dM);

                    Cv2.BitwiseAnd(dM, tM, a);

                    Cv2.BitwiseOr(dM, tM, o);

                    double and = Cv2.CountNonZero(a);

                    double or = Cv2.CountNonZero(o);

                    if (and / or > max)
                    {
                        max = and / or;
                        iSave = i;
                    }
                }

                ang1 = Math.Asin((y1 - yMid) / l1);

                ang1 = ang1 * 180.0 / Math.PI;

                if (x1 < xMid)
                    ang1 = ang1 + (180 - ang1 * 2);

                ang2 = Math.Asin((y2 - yMid) / l2);

                ang2 = ang2 * 180.0 / Math.PI;

                if (x2 < xMid)
                    ang2 = ang2 + (180 - ang2 * 2);

                ang3 = Math.Asin((y3 - yMid) / l3);

                ang3 = ang3 * 180.0 / Math.PI;

                if (x3 < xMid)
                    ang3 = ang3 + (180 - ang3 * 2);

                double lMax = Math.Max(l1, Math.Max(l2, l3));

                //Коэффицент пропроции треугольника

                double k = 60.0 / lMax;

                l11 = l1 * 0.3;
                l22 = l2 * 0.3;
                l33 = l3 * 0.3;

                //Узнаем координаты новых точек

                ang1Rad = (ang1 + iSave) / 180.0 * Math.PI;
                ang2Rad = (ang2 + iSave) / 180.0 * Math.PI;
                ang3Rad = (ang3 + iSave) / 180.0 * Math.PI;

                xNew1 = Convert.ToInt32(Math.Cos(ang1Rad) * l11);

                yNew1 = Convert.ToInt32(Math.Sin(ang1Rad) * l11);

                xNew2 = Convert.ToInt32(Math.Cos(ang2Rad) * l22);

                yNew2 = Convert.ToInt32(Math.Sin(ang2Rad) * l22);

                xNew3 = Convert.ToInt32(Math.Cos(ang3Rad) * l33);

                yNew3 = Convert.ToInt32(Math.Sin(ang3Rad) * l33);

                //Отрисовываем треугольник

                bitmap = new Bitmap(150, 150);
                bitmapGr = Graphics.FromImage(bitmap);
                bitmapGr.Clear(Color.Black);

                PointF point1 = new PointF(xNew1 + 75, yNew1 + 75);
                PointF point2 = new PointF(xNew2 + 75, yNew2 + 75);
                PointF point3 = new PointF(xNew3 + 75, yNew3 + 75);
                PointF[] curvePoints =
                {
                    point1,
                    point2,
                    point3,
                };

                bitmapGr.Clear(Color.Black);

                detGr.Clear(Color.Black);

                detGr.FillPolygon(new SolidBrush(Color.White), curvePoints);

                double green = 0;
                double red = 0;

                Bitmap tempLit = BitmapConverter.ToBitmap(tempLitMat);
                Bitmap tempBig = BitmapConverter.ToBitmap(tempBigMat);

                for (int i = 0; i < 150; i++)
                {
                    for (int j = 0; j < 150; j++)
                    {
                        if ((det.GetPixel(i, j).R == 255) && (tempLit.GetPixel(i, j).R == 255))
                        {
                            bitmap.SetPixel(i, j, Color.GreenYellow);
                            green++;
                        }
                        else
                        if ((det.GetPixel(i, j).R == 0) && (tempLit.GetPixel(i, j).R == 255))
                        {
                            bitmap.SetPixel(i, j, Color.Red);
                            red++;
                        }
                        else
                        if ((det.GetPixel(i, j).R == 255) && (tempBig.GetPixel(i, j).R == 255))
                        {
                            bitmap.SetPixel(i, j, Color.Green);
                            green++;
                        }
                        else
                        if ((det.GetPixel(i, j).R == 0) && (tempBig.GetPixel(i, j).R == 255))
                        {
                            bitmap.SetPixel(i, j, Color.DeepSkyBlue);
                            green++;
                        }
                        else
                        if ((det.GetPixel(i, j).R == 255) && (tempBig.GetPixel(i, j).R == 0))
                        {
                            bitmap.SetPixel(i, j, Color.Red);
                            red++;
                        }
                        else
                            bitmap.SetPixel(i, j, Color.Black);
                    }
                }
                if ((red != 0) || (green != 0))
                    prob.Text = "Совпадение: " + Convert.ToString(Convert.ToInt32((green / (green + red)) * 100)) + "%";

                imgComp.Image = bitmap;
            }
        }
    }
}