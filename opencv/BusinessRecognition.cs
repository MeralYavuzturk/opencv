using System;
using System.Drawing; // Bitmap için gerekli olabilir
using Emgu.CV.Structure;
using Emgu.CV;

namespace opencv
{
    // Yüz tanıma iş mantığını tutan sınıf
    public class BusinessRecognition
    {
        // Form1'deki kullanımınıza göre bir kurucu metot (constructor) tanımlıyoruz
        public BusinessRecognition(string path, string name, string xml)
        {
            // Kurucu metot boş kalabilir, sadece derleme hatasını çözmek için burada.
        }

        // Form1'deki kullanımınıza göre SaveTrainingData metodunu tanımlıyoruz
        public bool SaveTrainingData(Image faceImage, string personName)
        {
            // Burası eğitim verilerini kaydetme mantığını içerecek.
            // Şimdilik sadece başarılı olduğunu varsayalım.
            return true;
        }
    }
}
