# English Readme : [README-EN.MD](https://github.com/yemrecoskun/ETicaret/blob/master/README-EN.md)
<h1 align="center">Covid-19 TR</h1>
<p align="center">
<img src="https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR.ScreenShot/giphy.gif"/>
</p>
<p align="center">Mobil cihazlar(IOS/Android) için Türkiye'deki Koronavirüs verilerini gün gün verilen program.</p>

## Projemizin Amacı
- Çinde ortaya çıkan koronavirüsün dünyaya yayılmasıyla beraber Türkiye'deki vakaların artışını ve geçmişten günümüze sağlık bakanlığı tarafından
açıklanan Korona verilerimizi görüntüleyen ve veri grafiği oluşturan uygulama. 

## Kullanılan Program ve Dilleri
- Xamarin
- C#
- Xaml

## Yazılım Mimarisi ve Prensib
### Projemizde MVVM(Model-View-ViewModel) katmanlı mimariyle çalışmaktadır.
- Model katmanı;[Covid19.cs](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/Model/Covid19.cs) sınıfı oluşturuyoruz.
- ViewModel; [Covid19ViewModel.cs](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/ViewModel/Covid19ViewModel.cs) oluşturduğumuz sınıfta Viewa gidecek Model verilerini(Covid verileri) 
döndürüyoruz. Covid verileri Web_Api_TR.json dan gelmektedir. Json işlemleri kullanılmaktadır. 
- View katmanı; [Covid19View.xaml](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/View/MainPage.xaml) uygulamamızın arayüz kısımları View'a ekliyoruz.
Arayüze ViewModelden verileri çekiyoruz. 

### Veri Grafiği 
- Verileri apiden çektiğimizde [Charts](https://devblogs.microsoft.com/xamarin/microcharts-elegant-cross-platform-charts-for-any-app/) kullanarak veri grafiğimizi oluşturuyoruz.
<img src="https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR.ScreenShot/Screen4.png" width="250" height="500"/>
