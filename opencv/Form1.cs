using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using opencv;
using System.Drawing;

namespace opencv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoCapture capture = new VideoCapture();
            capture.Start();
            capture.ImageGrabbed += (a, b) =>
            {
                Mat frame = new Mat();
                capture.Read(frame);
                var image = frame.ToImage<Bgr, byte>();
                var image2 = image.Convert<Gray, byte>();
                CascadeClassifier haaryuz = new CascadeClassifier("alt.xml");
                Rectangle[] yuzler = haaryuz.DetectMultiScale(
                    image2,
                    1.1,
                    10,

                    new System.Drawing.Size(20, 20)
                    );
                MCvFont font = new MCvFont(FontFace.HersheyComplex, 0.5, 0.5);
                foreach (System.Drawing.Rectangle yuz in yuzler)
                {
                    var sadeyuz = image2.Copy(yuz).Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                    pictureBox2.Image = sadeyuz.ToBitmap();
                    if (train != null)
                    {
                        if (train.IsTrained)
                        {

                            string name = train.Recognize(sadeyuz);
                            int match_value = (int)train.Get_Eigen_Distance;








                            // YENÝ METÝN ÇÝZME KODU BURADA
                            CvInvoke.PutText(
                                image,
                                name + "",
                                new System.Drawing.Point(yuz.X - 2, yuz.Y - 2),
                                FontFace.HersheyComplex,
                                0.5,
                                new Bgr(Color.LightGreen).MCvScalar,
                                2
                            );







                        }
                    }
                    image.Draw(yuz, new Bgr(Color.Red), 2);
                }
                pictureBox1.Image = image.ToBitmap();
            
            
            
                
            
            
                    
                
            };
        }  

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!recognation.SaveTrainingData(pictureBox2.Image, textBox1.Text)) MessageBox.Show("hata", "profil kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(100);
                    label1.Text = (i + 1) + "adet profil";
                }
                recognation = null;
                train = null;
                recognation = new BusinessRecognition("D:\\", "Facess", "yuz.xml");
                train = new Classifier_Train("D:\\", "Facess", "yuz.xml");
            });
            }

        
        BusinessRecognition recognation = new BusinessRecognition( "D:\\","Facess","yuz.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Facess", "yuz.xml");
    }

    internal class MCvFont
    {
        private FontFace hersheyComplex;
        private double v1;
        private double v2;

        public MCvFont(FontFace hersheyComplex, double v1, double v2)
        {
            this.hersheyComplex = hersheyComplex;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
