## OPENCV İLE YÜZ TANIMA
### Bu proje, bir web kamerası akışı üzerinden gerçek zamanlı yüz algılama ve temel yüz tanıma gerçekleştiren bir windows form uygulamasıdır. Proje,görüntü işleme için .NET ortamında popüler olan **EMGUCV** kütüphanesini kullanır.

### ✨Özellikler
* Gerçek Zamanlı Görüntü Akışı(Web kamerasından anlık görüntü yakalama.)
* Yüz Algılama(Görüntüdeki yüzleri hızlı bir şekilde tespit etme ve kırmızı çerçeve içine alma.)
* Yüz Tanıma(Tespit edilen yüzü tanıma algoritmasıyla karşılaştırma ve ekranda isim/etiket gösterme (Tanıma sınıfları -BusinessRecognition ve Classifier_Train- model eğitim altyapısını içerir)
* Profil Kayıt(Tanıma modelini eğitmek için yüz görüntüsü kaydetme (button1_Click fonksiyonu ile))
### 💻Gereksinimler
* Emgu Cv Kütüphanaleri
* Emgu.CV
* Emgu.CV.runtime.windows
* Emgu.CV.Bitmap
* alt.xml dosyası
### ⚒️Kurulum ve Çalıştırma
* Visual Studio da projeyi açın
* Derleyin ve çalıştırın
* Program başlatıldığında, ana pencere de kamera görüntüsü açılmalı ve yüzünüzü tespit ettiğinde kırmızı bir çerçeve çizmelidir.
* Projenin çalıştırılabilir dosyası release kısmına eklenmiştir ordan da çalıştırabilirsiniz.
