using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Vision;
using AForge.Vision.Motion;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO.Ports;


namespace Benimki_geliyoooor
{
    public partial class esnakod : Form
    {
        public esnakod()
        {
            InitializeComponent();
        }

        int kırmızı, yesil, mavi, k1, m1, y1, x, y;
        Graphics g;
        Bitmap goruntu1;
        int mod;
        int sure = 3;
        bool ackapat = false;

        private FilterInfoCollection kameralar;
        private VideoCaptureDevice kameram;


        private void esnakod_Load(object sender, EventArgs e)
        {
            KırmızıButton.Checked = true;
            kameralar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in kameralar)
            {
                kamerasec.Items.Add(Device.Name);

            }
            kamerasec.SelectedIndex = 0;
            kameram = new VideoCaptureDevice();
        }

        private void Basla_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(kameralar[kamerasec.SelectedIndex].MonikerString);

            kameram.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

            kameram.Start();

        }
        private void ScrollBark_Scroll(object sender, ScrollEventArgs e)
        {
            labelk.Text = ScrollBark.Value.ToString();
            kırmızı = ScrollBark.Value;
        }

        private void ScrollBary_Scroll(object sender, ScrollEventArgs e)
        {
            labely.Text = ScrollBary.Value.ToString();
            yesil = ScrollBary.Value;
        }

        private void ScrollBarm_Scroll(object sender, ScrollEventArgs e)
        {
            labelm.Text = ScrollBarm.Value.ToString();
            mavi = ScrollBarm.Value;
        }

        public Rectangle nesne;
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                goruntu1 = (Bitmap)eventArgs.Frame.Clone();
                Bitmap goruntu2 = (Bitmap)eventArgs.Frame.Clone();

                switch (mod)
                {
                    case 2:
                        {
                            g = Graphics.FromImage(goruntu2);
                            g.DrawString(sure.ToString() + "cerceve", new Font("Segoe Script", 10), new SolidBrush(Color.White), new PointF(2, 2));
                            g.Dispose();

                        }
                        break;
                    case 1:
                        {
                            ColorFiltering filtre = new ColorFiltering();
                            filtre.Red = new IntRange(kırmızı, k1);
                            filtre.Green = new IntRange(yesil, y1);
                            filtre.Blue = new IntRange(mavi, m1);
                            filtre.ApplyInPlace(goruntu2);
                            
                            BlobCounter sayac = new BlobCounter();
                            sayac.MinHeight = 20;
                            sayac.MaxWidth = 20;
                            sayac.ObjectsOrder = ObjectsOrder.Size;

                            sayac.ProcessImage(goruntu2);
                            Rectangle[] rect = sayac.GetObjectsRectangles();
                            if (rect.Length > 0)
                            {
                                Rectangle nesne = rect[0];
                                Graphics graphic = Graphics.FromImage(goruntu2);
                                using (Pen pen = new Pen(Color.White, 3))
                                {
                                    graphic.DrawRectangle(pen, nesne);
                                }

                                x = nesne.X;
                                y = nesne.Y;

                                graphic.Dispose();

                            }
                            islem.Image = goruntu2;
                        }
                        break;
                }

                kaynak.Image = goruntu1;
            }
     
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            if (sure == 0)
            {
                timer1.Enabled = false;
                ackapat = false;
                islem.Image = goruntu1;
            }

        }

        private void Takipet_Click(object sender, EventArgs e)
        {
            mod = 1;
        }

      
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = x + "  " + y;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (y >= 0 && y <= 150 && x >= 0 && x <= 200)
            {
                serialPort.WriteLine("-1");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            // ilk satır

            else if (y >= 0 && y <= 150 && x > 200 && x <= 400)
            {
                serialPort.WriteLine("-2");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            else if (y >= 0 && y <= 150 && x > 400 && x <= 600)
            {
                serialPort.WriteLine("-3");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            // ikinci satır

            else if (y >= 150 && y <= 300 && x >= 0 && x <= 200)
            {
                serialPort.WriteLine("-4");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            else if (y >= 150 && y <= 300 && x > 200 && x <= 400)
            {
                serialPort.WriteLine("-5");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            else if (y >= 150 && y <= 300 && x > 400 && x <= 600)
            {
                serialPort.WriteLine("-6");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            //üçüncü satır

            else if (y >= 300 && y <= 450 && x >= 0 && x <= 200)
            {
                serialPort.WriteLine("-7");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            else if (y >= 300 && y <= 450 && x > 200 && x <= 400)
            {
                serialPort.WriteLine("-8");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }

            else if (y >= 300 && y <= 450 && x > 400 && x <= 600)
            {
                serialPort.WriteLine("-9");
                serialPort.WriteLine(x + "");
                serialPort.WriteLine(y + "");

            }
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            timer3.Enabled = true;
        }
        
        private void KırmızıButton_CheckedChanged(object sender, EventArgs e)
        {
            if (KırmızıButton.Checked == true)
            {
                k1 = 255;
                m1 = 90;
                y1 = 90;
            }
        }

        private void MaviButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaviButton.Checked == true)
            {
                k1 = 0;
                m1 = 200;
                y1 = 115;
            }
        }
       
        private void YesilButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YesilButton.Checked == true)
            {
               
                k1 = 50;
                m1 = 100;
                y1 = 255;
            }
        }

        private void esnakod_FormClosing(object sender, FormClosingEventArgs e)
        {
            kameram.Stop();
            Application.Exit();
        }
        

        

        

        
       

        

        

        
        

        

        

       
    }

}

