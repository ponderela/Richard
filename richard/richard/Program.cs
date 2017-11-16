using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace richard
{
    class Progra
    {
        static void Main(string[] args)
        {

            //System.Console.WriteLine("Adjust program");
            //System.Console.ReadLine();
            //Thread.Sleep(1000);
            //var a = Screen.PrimaryScreen.WorkingArea.Heights;
            //Rectangle bounds = Screen.GetBounds(Point.Empty);

            /*Rectangle rec = new Rectangle(0, 0, 1920, 1080);
            using (Bitmap bitmap = new Bitmap(rec.Width,rec.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, rec.Size);
                }

                 bitmap.Save("out/test.jpg", ImageFormat.Jpeg);


            }*/
            string red = "fffc0200";
            /*using (Bitmap bmp = new Bitmap("out/template.jpg"))
            {
                for (int w = 1900; w >= 0; w--)
                {
                    for (int h = 804; h >= 140; h--)
                    {
                        Color c = bmp.GetPixel(w,h);
                        if (c.Name == red)
                        {
                            Console.WriteLine("found red at{0},{1}", w.ToString(), h.ToString());
                            Console.ReadLine();
                        }
                    }
                }*/
                //bmp.Save("out/test.jpg", ImageFormat.Jpeg);
                 
                 //fffc0200,255,252,2,0 >> reddot
                 //height range 140-890 in half size 
                //var col =  bmp.GetPixel(804, 479);

            }
        }
    }

