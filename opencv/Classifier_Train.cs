using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace opencv
{
    // Yüz tanıma modelini (Eğitici) tutan sınıf
    public class Classifier_Train
    {
        // Form1'deki kullanımınıza göre bir kurucu metot (constructor) tanımlıyoruz
        public Classifier_Train(string path, string name, string xml)
        {
            // Kurucu metot boş kalabilir.
        }

        // Form1'deki kullanımınıza göre Recognize metodunu tanımlıyoruz
        public string Recognize(Image<Gray, byte> faceImage)
        {
            // Burası yüz tanıma mantığını içerecek.
            // Şimdilik sadece bir isim döndürelim.
            return "Tanınan Kisi";
        }

        // Form1'deki kullanımınıza göre IsTrained özelliğini tanımlıyoruz
        public bool IsTrained { get; set; } = true;

        // Form1'deki kullanımınıza göre Get_Eigen_Distance özelliğini tanımlıyoruz
        public double Get_Eigen_Distance { get; set; } = 0;
    }
}
